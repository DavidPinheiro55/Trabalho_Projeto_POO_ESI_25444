using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Projeto_POO_ESI_25444.Enum;

namespace Trabalho_Projeto_POO_ESI_25444
{
    public class Incidente
    {
        private static int proximoId = 1; // Variável estática para gerar IDs únicos para cada incidente criado

        // Propriedades públicas da classe Incidente
        public int Id { get; set; } // ID único do incidente
        public string Criador { get; set; } // Nome ou identificação do criador do incidente
        public string Descricao { get; set; } // Descrição do incidente fornecida pelo criador
        public DateTime DataCriacao { get; set; } // Data e hora em que o incidente foi criado
        public Prioridade TipoPrioridade { get; set; } // Prioridade do incidente, definida com o enum `Prioridade`
        public StatusIncidente Status { get; set; } // Status do incidente, usando o enum `StatusIncidente`
        public string TecnicoAtribuido { get; set; } // Técnico designado para tratar o incidente, inicialmente vazio
        public string Resolucao { get; set; } // Propriedade de resolução

        // Construtor da classe Incidente
        public Incidente(string criador, string descricao, Prioridade prioridade)
        {
            this.Id = proximoId++; // Atribui um ID único ao incidente e incrementa o valor de `proximoId` para o próximo incidente
            this.Criador = criador; // Define o criador do incidente com o valor fornecido
            this.Descricao = descricao; // Define a descrição com o valor fornecido
            this.DataCriacao = DateTime.Now; // Define a data de criação como a data e hora atuais
            this.TipoPrioridade = prioridade; // Define a prioridade com o valor fornecido
            Status = StatusIncidente.NãoTratado; // Define o status inicial como "NãoTratado" por padrão
            this.TecnicoAtribuido = ""; // Inicializa o campo `TecnicoAtribuido` vazio
            this.Resolucao = "";
        }

        // Método para representar o objeto Incidente como string
        public override string ToString()
        {
            // Retorna uma string formatada com todos os dados do incidente
            return $"ID: {Id}, Criador: {Criador}, Data: {DataCriacao}, Prioridade: {TipoPrioridade}, Status: {Status}\nDescrição: {Descricao}, Técnico Atribuído: {TecnicoAtribuido}";
        }

        // Método para salvar o incidente usando a classe GestorIncidentes
        public void Salvar()
        {
            // Chama o método SalvarIncidente da classe GestorIncidentes e passa o próprio incidente como parâmetro
            GestorIncidentes.SalvarIncidente(this);
        }
    }
}
