using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Projeto_POO_ESI_25444
{
    public class GestorUtilizadores
    {
        /// <summary>
        /// Caminho para o arquivo de armazenamento de utilizadores
        /// </summary>
        private readonly string caminhoFicheiro = "../../BD/utilizadores.txt";

        /// <summary>
        /// Método para registrar um novo utilizador no sistema
        /// </summary>
        /// <param name="utilizador">Nome do Utilziador </param>
        /// <returns>verdadeiro para confirmar o registro bem-sucedido</returns>
        public bool RegistarUtilizador(Utilizador utilizador)
        {
            // Verifica se o arquivo existe e se já há um utilizador com o mesmo nome de utilizador
            if (File.Exists(caminhoFicheiro) && File.ReadAllLines(caminhoFicheiro).Any(linha => linha.Split(',')[0] == utilizador.Username))
            {
                return false; // Retorna falso se o nome de utilizador já existir
            }

            // Se não houver duplicatas, adiciona o utilizador ao arquivo
            using (StreamWriter sw = File.AppendText(caminhoFicheiro))
            {
                // Escreve as informações do utilizador: Username, Password e Tipo
                sw.WriteLine($"{utilizador.Username},{utilizador.Password},{utilizador.ObterTipo()}");
            }

            return true; 
        }

        /// <summary>
        /// Método para autenticar um utilizador com base em username e password
        /// </summary>
        /// <param name="username">Verificação do Utilizador</param>
        /// <param name="password">Verificação da Password</param>
        /// <returns>null se não houver correspondência</returns>
        public Utilizador AutenticarUtilizador(string username, string password)
        {
            // Se o arquivo não existir, retorna null, indicando que o utilizador não existe
            if (!File.Exists(caminhoFicheiro)) return null;

            // Lê todas as linhas do arquivo para procurar o utilizador
            foreach (string linha in File.ReadAllLines(caminhoFicheiro))
            {
                var dados = linha.Split(','); // Separa a linha em campos (Username, Password, Tipo)

                // Verifica se o username e password fornecidos correspondem aos dados do arquivo
                if (dados[0] == username && dados[1] == password)
                {
                    // Retorna a instância apropriada de acordo com o tipo do utilizador
                    if (dados[2] == "Cliente")
                        return new Cliente(username, password);
                    else if (dados[2] == "Técnico")
                        return new Tecnico(username, password);
                    else if (dados[2] == "Administrador")
                        return new Administrador(username, password);
                }
            }

            return null; 
        }

        /// <summary>
        /// Construtor da classe GestorUtilizadores
        /// </summary>
        public GestorUtilizadores()
        {
            VerificarAdministrador(); // Garante que um administrador exista ao iniciar
        }

        /// <summary>
        /// Método para criar um administrador padrão com credenciais predefinidas
        /// </summary>
        public void CriarAdministrador()
        {
            // Instancia um novo administrador com username e password "dev"
            Administrador admin = new Administrador("dev", "dev");

            // Adiciona o administrador ao arquivo
            using (StreamWriter sw = File.AppendText(caminhoFicheiro))
            {
                // Escreve as informações do administrador: Username, Password, Tipo
                sw.WriteLine($"{admin.Username},{admin.Password},{admin.ObterTipo()}");
               
            }
        }

        /// <summary>
        /// Método para verificar se existe um administrador no sistema
        /// </summary>
        public void VerificarAdministrador()
        {
            // Se o arquivo de utilizadores não existir, cria-o e adiciona o administrador
            if (!File.Exists(caminhoFicheiro))
            {
                CriarAdministrador(); // Cria o arquivo e adiciona o administrador padrão
            }
            else
            {
                // Verifica se o administrador padrão já está presente no arquivo
                bool adminExiste = File.ReadAllLines(caminhoFicheiro).Any(linha => linha.Split(',')[0] == "dev");

                if (!adminExiste)
                {
                    CriarAdministrador(); // Se não encontrar o admin, cria-o
                }
            }
        }

        /// <summary>
        /// Método para gerar uma senha básica para novos utilizadores técnicos
        /// </summary>
        /// <returns>senha gerada como uma string</returns>
        public string GerarSenhaBasica()
        {
            // Define o conjunto de caracteres permitidos na senha
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random(); // Inicializa o gerador de números aleatórios
            char[] senhaArray = new char[5]; // Array de caracteres para construir a senha de 5 dígitos

            // Preenche cada caractere da senha com um caractere aleatório do conjunto
            for (int i = 0; i < senhaArray.Length; i++)
            {
                senhaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(senhaArray); 
        }
    }
}
