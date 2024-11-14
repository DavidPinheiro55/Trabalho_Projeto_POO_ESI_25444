using System;
using System.Collections.Generic;
using System.IO;
using Trabalho_Projeto_POO_ESI_25444.Enum;
using System.Reflection.Emit;
using System.Linq;
using System.Windows.Forms;

namespace Trabalho_Projeto_POO_ESI_25444
{
    public class GestorIncidentes
    {
        private static string caminhoFicheiroIncidentes = "../../BD/incidentes.txt";
        private static List<Incidente> listaIncidentes = new List<Incidente>();

        // Método para salvar um incidente no ficheiro
        public static void SalvarIncidente(Incidente incidente)
        {
            // Formata os dados do incidente para uma linha de texto e salva no ficheiro.
            string linha = $"{incidente.Id},{incidente.Criador},{incidente.Descricao},{incidente.DataCriacao},{incidente.TipoPrioridade},{incidente.Status},{incidente.TecnicoAtribuido}";
            File.AppendAllText(caminhoFicheiroIncidentes, linha + Environment.NewLine);
        }

        // Método para carregar todos os incidentes do ficheiro
        public static List<Incidente> CarregarIncidentes()
        {
            List<Incidente> listaIncidentes = new List<Incidente>();

            if (File.Exists(caminhoFicheiroIncidentes))
            {
                foreach (var linha in File.ReadAllLines(caminhoFicheiroIncidentes))
                {
                    var dados = linha.Split(',');

                    // Parsea os dados de acordo com o formato
                    int id = int.Parse(dados[0]);
                    string criador = dados[1];
                    string descricao = dados[2];
                    DateTime dataCriacao = DateTime.Parse(dados[3]);

                    // Prioridade prioridade = (Prioridade)Enum.(typeof(Prioridade), dados[4]);
                    //Prioridade prioridade = (Prioridade)Enum.Parse(typeof(Prioridade), dados[4]);

                    Prioridade prioridade;

                    switch (dados[4])
                    {
                        case "Baixa":
                            prioridade = Prioridade.Baixa;
                            break;
                        case "Media":
                            prioridade = Prioridade.Media;
                            break;
                        case "Alta":
                            prioridade = Prioridade.Alta;
                            break;
                        default:
                            Console.WriteLine("Prioridade inválida");
                            continue; 
                    }



                    Incidente incidente = new Incidente(criador, descricao, prioridade)
                    {
                        Id = id,
                        DataCriacao = dataCriacao
                    };

                    listaIncidentes.Add(incidente);
                }
            }

            return listaIncidentes;
        }



        // Método para obter o próximo ID disponível para um novo incidente
        public static int ObterProximoId()
        {
            int proximoId = 1; // Começa com o ID 1

            if (File.Exists(caminhoFicheiroIncidentes))
            {
                // Lê todas as linhas do ficheiro e encontra o maior ID
                var linhas = File.ReadAllLines(caminhoFicheiroIncidentes);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');
                    int id = int.Parse(dados[0]);
                    if (id >= proximoId)
                    {
                        proximoId = id + 1;  // Atualiza o próximo ID se encontrar um maior
                    }
                }
            }

            return proximoId;
        }

        // Método para adicionar um novo incidente
        public static void AdicionarIncidente(Incidente incidente)
        {
            int id = ObterProximoId(); // Obtém o próximo ID disponível
            incidente.Id = id;  // Define o ID como o próximo ID disponível
            SalvarIncidente(incidente); // Salva o incidente no arquivo
        }

        // Método para obter os incidentes de um determinado utilizador
        public static List<Incidente> ObterIncidentesPorUtilizador(string username)
        {
            List<Incidente> incidentesDoUtilizador = new List<Incidente>();

            var todosIncidentes = CarregarIncidentes(); // Carrega todos os incidentes

            foreach (var incidente in todosIncidentes)
            {
                if (incidente.Criador == username) // Filtra apenas os incidentes do utilizador logado
                {
                    incidentesDoUtilizador.Add(incidente);
                }
            }

            return incidentesDoUtilizador;
        }



        // Método para atualizar a lista de incidentes na ListBox do FormUtilizador
        public static void AtualizarListaIncidentes(ListBox lstIncidentes, string usuario)
        {
            // Limpa a lista de incidentes na ListBox
            lstIncidentes.Items.Clear();

            // Carregar todos os incidentes
            var listaIncidentes = CarregarIncidentes();

            // Filtra os incidentes do utilizador atual
            var incidentesDoUtilizador = listaIncidentes.Where(i => i.Criador == usuario).ToList();

            // Adiciona cada incidente filtrado à ListBox
            foreach (var incidente in incidentesDoUtilizador)
            {
                // Adiciona um texto representativo do incidente, como o ID e a descrição
                lstIncidentes.Items.Add($"ID: {incidente.Id} - {incidente.Descricao}");
                //lstIncidentes.Items.Add(incidente.ToString());
            }
        }

        public static Incidente ObterIncidentePorDescricao(string descricao)
        {
            // Busca o incidente na lista (ou no arquivo) com base na descrição
            return listaIncidentes.FirstOrDefault(i => i.Descricao == descricao);
        }



        public static List<Incidente> CarregarIncidentesPorCriador(string nomeUtilizador)
        {
            // Aqui você obtém todos os incidentes
            List<Incidente> todosIncidentes = CarregarIncidentes(); // Suponha que este método carrega todos os incidentes

            // Agora você filtra os incidentes pelo criador, que é o nome do usuário logado
            List<Incidente> incidentesDoCriador = todosIncidentes.Where(i => i.Criador == nomeUtilizador).ToList();

            return incidentesDoCriador;
        }

        public static List<Incidente> CarregarIncidentesDoArquivo(string nomeUtilizador)
        {
            List<Incidente> incidentes = new List<Incidente>();

            // Caminho do arquivo (ajuste conforme necessário)
            string caminhoArquivo = caminhoFicheiroIncidentes;
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                foreach (var linha in linhas)
                {
                    string[] partes = linha.Split(',');

                    if (partes.Length == 7) // Verifica se a linha tem todos os dados necessários
                    {
                        // Converte e cria o incidente
                        int id;
                        if (!int.TryParse(partes[0], out id))
                        {
                            MessageBox.Show("ID inválido");
                            continue;
                        }

                        string criador = partes[1]; // Nome do criador
                        string descricao = partes[2]; // Descrição do incidente

                        DateTime dataCriacao;
                        if (!DateTime.TryParseExact(partes[3], "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out dataCriacao))
                        {
                            MessageBox.Show("Data inválida");
                            continue;
                        }

                        Prioridade prioridade;
                        //if (!Enum.TryParse(partes[4], true, out prioridade)) // 'true' ignora maiúsculas/minúsculas
                        //{
                        //    MessageBox.Show("Prioridade inválida");
                        //    continue;
                        //}
                        switch (partes[4])
                        {
                            case "Baixa":
                                prioridade = Prioridade.Baixa;
                                break;
                            case "Media":
                                prioridade = Prioridade.Media;
                                break;
                            case "Alta":
                                prioridade = Prioridade.Alta;
                                break;
                            default:
                                Console.WriteLine("Prioridade inválida");
                                continue; // Ou outro método de erro
                        }

                        // Criação do objeto Incidente usando o construtor correto
                        // Usando o construtor com ID, Criador, Descricao, DataCriacao, e TipoPrioridade
                        Incidente incidente = new Incidente(criador, descricao, prioridade);

                        // Adiciona o incidente à lista
                        incidentes.Add(incidente);
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo de incidentes não encontrado.");
            }
            return incidentes;
            // Aqui você pode retornar ou armazenar a lista de incidentes como necessário
        }

        // Tecnico 
        public static int ContarIncidentesPorAtribuir()
        {
            int count = 0;

            if (File.Exists(caminhoFicheiroIncidentes))
            {
                var linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');

                    // Assume que o campo de status é o índice 5 e o técnico atribuído é o índice 6
                    if (dados.Length > 6 && dados[5] == "NãoTratado" && string.IsNullOrWhiteSpace(dados[6]))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        public static int ContarIncidentesNaoTratados()
        {
            int count = 0;

            if (File.Exists(caminhoFicheiroIncidentes))
            {
                var linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

                foreach (var linha in linhas)
                {
                    var dados = linha.Split(',');

                    // Verificar se o incidente tem o status "NãoTratado"
                    if (dados.Length >= 6 && dados[5] == "NãoTratado")
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static List<Incidente> ObterIncidentesNaoAtribuidos()
        {
            List<Incidente> incidentesNaoAtribuidos = new List<Incidente>();

            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            // Percorre cada linha para verificar os incidentes
            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');

                // Verifica se o técnico atribuído está vazio (ou seja, incidente não atribuído)
                if (string.IsNullOrWhiteSpace(dados[6]))
                {
                    // Convertendo a Prioridade com Switch
                    Prioridade prioridade;
                    switch (dados[4])
                    {
                        case "Baixa":
                            prioridade = Prioridade.Baixa;
                            break;
                        case "Media":
                            prioridade = Prioridade.Media;
                            break;
                        case "Alta":
                            prioridade = Prioridade.Alta;
                            break;
                        default:
                            prioridade = Prioridade.Baixa; // Definido como padrão se não for encontrado
                            break;
                    }

                    // Convertendo o StatusIncidente com Switch
                    StatusIncidente status;
                    switch (dados[5])
                    {
                        case "NãoTratado":
                            status = StatusIncidente.NãoTratado;
                            break;
                        case "Tratado":
                            status = StatusIncidente.Tratado;
                            break;
                        default:
                            status = StatusIncidente.NãoTratado; // Definido como padrão se não for encontrado
                            break;
                    }

                    // Cria um novo objeto Incidente e adiciona à lista
                    Incidente incidente = new Incidente(dados[1], dados[2], prioridade)
                    {
                        Id = int.Parse(dados[0]),
                        Status = status
                    };

                    incidentesNaoAtribuidos.Add(incidente);
                }
            }

            return incidentesNaoAtribuidos;
        }

        public static void ResgatarIncidente(int id, string tecnicoResponsavel)
        {
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            for (int i = 0; i < linhas.Length; i++)
            {
                var dados = linhas[i].Split(',');

                // Verifica se o ID do incidente corresponde e se o técnico ainda não foi atribuído
                if (int.Parse(dados[0]) == id && string.IsNullOrWhiteSpace(dados[6]))
                {
                    // Atualiza o técnico atribuído
                    dados[6] = tecnicoResponsavel;

                    // Atualiza o status para "Tratado" ou "Em andamento", conforme necessário
                    dados[5] = StatusIncidente.NãoTratado.ToString(); // Se quiser marcar como "NãoTratado" ou "Tratado", ajuste aqui.

                    // Atualiza a linha com os novos dados
                    linhas[i] = string.Join(",", dados);
                }
            }

            // Salva as alterações de volta ao arquivo
            File.WriteAllLines(caminhoFicheiroIncidentes, linhas);
        }

        // Método para obter a lista de incidentes atribuídos a um técnico
        public static List<Incidente> ObterIncidentesAtribuidos(string tecnicoResponsavel)
        {
            List<Incidente> incidentesAtribuidos = new List<Incidente>();
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');

                // Verifica se o incidente está atribuído ao técnico (tecnicoResponsavel)
                if (!string.IsNullOrWhiteSpace(dados[6]) && dados[6] == tecnicoResponsavel)
                {
                    Incidente incidente = CriarIncidente(dados); // Método para criar o incidente
                    incidentesAtribuidos.Add(incidente);
                }
            }

            return incidentesAtribuidos;
        }

        // Método para criar o objeto incidente a partir dos dados do arquivo
        private static Incidente CriarIncidente(string[] dados)
        {
            int id = int.Parse(dados[0]);
            string criador = dados[1];
            string descricao = dados[2];
            DateTime dataCriacao = DateTime.Parse(dados[3]);

            //Prioridade prioridade = (Prioridade)Enum.Parse(typeof(Prioridade), dados[4]);
            //StatusIncidente status = (StatusIncidente)Enum.Parse(typeof(StatusIncidente), dados[5]);

            // Convertendo a Prioridade com Switch
            Prioridade prioridade;
            switch (dados[4])
            {
                case "Baixa":
                    prioridade = Prioridade.Baixa;
                    break;
                case "Media":
                    prioridade = Prioridade.Media;
                    break;
                case "Alta":
                    prioridade = Prioridade.Alta;
                    break;
                default:
                    prioridade = Prioridade.Baixa; // Definido como padrão se não for encontrado
                    break;
            }

            // Convertendo o StatusIncidente com Switch
            StatusIncidente status;
            switch (dados[5])
            {
                case "NãoTratado":
                    status = StatusIncidente.NãoTratado;
                    break;
                case "Tratado":
                    status = StatusIncidente.Tratado;
                    break;
                default:
                    status = StatusIncidente.NãoTratado; // Definido como padrão se não for encontrado
                    break;
            }

            Incidente incidente = new Incidente(criador, descricao, prioridade)
            {
                Id = id,
                DataCriacao = dataCriacao,
                Status = status
            };

            return incidente;
        }

        public static void AtualizarIncidente(Incidente incidente, string informacoesResolucao)
        {
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            for (int i = 0; i < linhas.Length; i++)
            {
                var dados = linhas[i].Split(',');

                // Verifica se a linha tem o número esperado de colunas (mínimo 8)
                if (dados.Length < 8)
                {
                    Console.WriteLine($"Linha {i} mal formatada. Não tem o número esperado de colunas.");
                    // Adiciona uma coluna de resolução vazia, caso não exista
                    Array.Resize(ref dados, 8);
                    dados[7] = ""; // Inicializa a resolução vazia
                }

                // Verifica se o ID corresponde ao incidente
                if (int.Parse(dados[0]) == incidente.Id)
                {
                    // Atualiza o status para "Tratado"
                    dados[5] = StatusIncidente.Tratado.ToString();

                    // Atualiza a resolução (coluna 7)
                    dados[7] = informacoesResolucao;

                    // Atualiza a linha com os novos dados
                    linhas[i] = string.Join(",", dados);
                }
            }

            // Salva as alterações no arquivo
            File.WriteAllLines(caminhoFicheiroIncidentes, linhas);
        }



        public static List<Incidente> ObterIncidentesTratadosPorUtilizador(string utilizadorAtual)
        {
            List<Incidente> incidentesTratados = new List<Incidente>();
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            // Exibir todas as linhas para ver o que está sendo lido
            foreach (var linha in linhas)
            {
                MessageBox.Show($"Lida linha: {linha}");
            }

            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');

                // Exibe para verificar as comparações
                MessageBox.Show($"Utilizador: {dados[6].Trim()}, Status: {dados[5].Trim()}, Status Esperado: {StatusIncidente.Tratado.ToString().Trim()}");

                // Adicionando .Trim() para remover espaços extras ao redor das strings
                if (dados[6].Trim().Equals(utilizadorAtual.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    dados[5].Trim().Equals(StatusIncidente.Tratado.ToString().Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    // Se as comparações estiverem corretas, continuamos o processamento
                    Prioridade prioridade;
                    switch (dados[4].Trim())
                    {
                        case "Baixa":
                            prioridade = Prioridade.Baixa;
                            break;
                        case "Media":
                            prioridade = Prioridade.Media;
                            break;
                        case "Alta":
                            prioridade = Prioridade.Alta;
                            break;
                        default:
                            throw new ArgumentException("Prioridade inválida");
                    }

                    Incidente incidente = new Incidente(dados[1], dados[2], prioridade)
                    {
                        Id = int.Parse(dados[0]),
                        DataCriacao = DateTime.Parse(dados[3]),
                        Status = StatusIncidente.Tratado,
                        Resolucao = dados[7]
                    };

                    incidentesTratados.Add(incidente);
                }
            }

            return incidentesTratados;
        }





        // Método para obter um incidente pelo ID
        public static Incidente ObterIncidentePorId(int id)
        {
            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');

                // Verifica se o ID do incidente corresponde ao ID fornecido
                if (int.Parse(dados[0]) == id)
                {
                    // Cria o incidente a partir dos dados e o retorna
                    return CriarIncidente(dados);
                }
            }

            // Caso o incidente não seja encontrado, retorna null
            return null;
        }



        // Método auxiliar para criar um objeto Incidente a partir dos dados do arquivo
        public static void CarregarIncidentesNaoAtribuidos(ListBox checklistIncidentes)
        {
            // Limpa a Checklist antes de adicionar novos itens
            checklistIncidentes.Items.Clear();

            // Lê todas as linhas do arquivo de incidentes
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            // Percorre todas as linhas e verifica se o incidente não tem técnico atribuído
            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');

                // Verifica se o incidente não tem técnico atribuído (o campo "dados[6]" está vazio)
                if (string.IsNullOrWhiteSpace(dados[6]))
                {
                    // Cria uma string representando o incidente, incluindo o ID e a descrição
                    string descricaoIncidente = $"ID: {dados[0]} - {dados[2]}"; // Exemplo: ID, Descrição

                    // Adiciona o incidente à Checklist
                    checklistIncidentes.Items.Add(descricaoIncidente);
                }
            }
        }

        public static List<Incidente> ObterIncidentesNaoTratadosPorTecnico(string tecnicoResponsavel)
        {
            List<Incidente> incidentesNaoTratados = new List<Incidente>();
            string[] linhas = File.ReadAllLines(caminhoFicheiroIncidentes);

            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');

                // Verifica se o incidente tem o técnico atribuído e está com o status "NãoTratado"
                if (dados[6] == tecnicoResponsavel && dados[5] == StatusIncidente.NãoTratado.ToString())
                {
                    // Utiliza switch para converter a string em Prioridade
                    Prioridade prioridade;
                    switch (dados[4])
                    {
                        case "Baixa":
                            prioridade = Prioridade.Baixa;
                            break;
                        case "Media":
                            prioridade = Prioridade.Media;
                            break;
                        case "Alta":
                            prioridade = Prioridade.Alta;
                            break;
                        default:
                            throw new ArgumentException("Prioridade inválida");
                    }

                    // Utiliza switch para converter a string em StatusIncidente
                    StatusIncidente status;
                    switch (dados[5])
                    {
                        case "NãoTratado":
                            status = StatusIncidente.NãoTratado;
                            break;
                        case "Tratado":
                            status = StatusIncidente.Tratado;
                            break;
                        default:
                            throw new ArgumentException("Status inválido");
                    }

                    // Cria o incidente a partir dos dados
                    Incidente incidente = new Incidente(dados[1], dados[2], prioridade)
                    {
                        Id = int.Parse(dados[0]),
                        DataCriacao = DateTime.Parse(dados[3]),
                        Status = status // Usando o status mapeado
                    };

                    incidentesNaoTratados.Add(incidente);
                }
            }

            return incidentesNaoTratados;
        }


    }
}





