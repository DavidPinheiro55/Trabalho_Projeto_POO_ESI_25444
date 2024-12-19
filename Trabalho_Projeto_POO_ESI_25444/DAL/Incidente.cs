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
        /// <summary>
        /// Variável estática para gerar IDs únicos para cada incidente criado
        /// </summary>
        private static int proximoId = 1; 

        /// <summary>
        /// ID único do incidente
        /// </summary>
        private int _id; 
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        /// <summary>
        /// Nome ou identificação do criador do incidente
        /// </summary>
        private string _criador; 
        public string Criador
        {
            get { return this._criador; }
            set { this._criador = value; }
        }

        /// <summary>
        /// Descrição do incidente fornecida pelo criador
        /// </summary>
        private string _descricao;
        public string Descricao
        {
            get { return this._descricao; }
            set { this._descricao = value; }
        }
        /// <summary>
        /// Data e hora em que o incidente foi criado
        /// </summary>
        public DateTime DataCriacao {get;set;}

        /// <summary>
        /// Prioridade do incidente, definida com o enum `Prioridade`
        /// </summary>
        public Prioridade TipoPrioridade {get;set;}

        /// <summary>
        /// Status do incidente, usando o enum `StatusIncidente`
        /// </summary>
        public StatusIncidente Status {get;set;}

        /// <summary>
        /// Técnico designado para tratar o incidente, inicialmente vazio
        /// </summary>
        private string _tecnicoAtribuido;
        public string TecnicoAtribuido 
        {
            get { return this._tecnicoAtribuido; }
            set { this._tecnicoAtribuido = value; }
        }

        /// <summary>
        /// Propriedade de resolução
        /// </summary>
        private string _resolucao;
        public string Resolucao 
        { 
            get { return this._resolucao; }
            set { this._resolucao = value; }
        }

        /// <summary>
        /// Avaliação do incidente , é opcional (valor nulo permitido).
        /// </summary>
        public int? Avaliacao {get;set;}

        /// <summary>
        /// Construtor da classe Incidente
        /// </summary>
        /// <param name="criador">Define o criador do incidente com o valor fornecido</param>
        /// <param name="descricao">Define a descrição com o valor fornecido</param>
        /// <param name="prioridade"> Define a prioridade com o valor fornecido</param>
        public Incidente(string criador, string descricao, Prioridade prioridade)
        {
            this.Id = proximoId++; // Atribui um ID único ao incidente e incrementa o valor de `proximoId` para o próximo incidente
            this.Criador = criador; 
            this.Descricao = descricao; 
            this.DataCriacao = DateTime.Now; // Define a data de criação como a data e hora atuais
            this.TipoPrioridade = prioridade; // Define a prioridade com o valor fornecido
            Status = StatusIncidente.NãoTratado; // Define o status inicial como "NãoTratado" por padrão
            this.TecnicoAtribuido = ""; // Inicializa o campo `TecnicoAtribuido` vazio
            this.Resolucao = "";
            this.Avaliacao = null;
        }

        /// <summary>
        /// Método para representar o objeto Incidente como string
        /// </summary>
        /// <returns>String formatada com todos os dados do incidente</returns>
        public override string ToString()
        {
            return $"ID: {Id}, Criador: {Criador}, Data: {DataCriacao}, Prioridade: {TipoPrioridade}, Status: {Status}\nDescrição: {Descricao}, Técnico Atribuído: {TecnicoAtribuido}, Avaliação {Avaliacao}";
        }

        /// <summary>
        /// Método para salvar o incidente usando a classe GestorIncidentes
        /// </summary>
        public void Salvar()
        {
            GestorIncidentes.SalvarIncidente(this);
        }
    }
}
