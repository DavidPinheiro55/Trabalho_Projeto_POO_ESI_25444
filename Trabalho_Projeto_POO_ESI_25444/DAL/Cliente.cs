using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Projeto_POO_ESI_25444
{

    /// <summary>
    /// Declaração da classe Cliente, que herda da classe base Utilizador
    /// </summary>
    public class Cliente : Utilizador
    {
        /// <summary>
        /// Construtor da classe Cliente, que chama o construtor da classe base Utilizador
        /// </summary>
        /// <param name="username">Parâmetro Nome do Utilizador </param>
        /// <param name="password">Parâmetro Password do Utilizador</param>
        public Cliente(string username, string password) : base(username, password) { }

        /// <summary>
        /// Método que sobrescreve o método abstrato ObterTipo() da classe base Utilizador
        /// </summary>
        /// <returns>Tipo específico deste utilizador: "Cliente"</returns>
        public override string ObterTipo()
        {
            return "Cliente";
        }
    }
}
