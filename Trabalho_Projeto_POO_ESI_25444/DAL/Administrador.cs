using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabalho_Projeto_POO_ESI_25444
{

    // Declaração da classe Administrador, que herda da classe base Utilizador
    public class Administrador : Utilizador
    {
        /// <summary>
        /// Construtor da classe Administrador, que chama o construtor da classe base Utilizador
        /// </summary>
        /// <param name="username">Parâmetro Nome do Utilizador </param>
        /// <param name="password">Parâmetro Password do Utilizador</param>
        public Administrador(string username, string password) : base(username, password) { }

        /// <summary>
        /// Método que sobrescreve o método ObterTipo() da classe base Utilizador
        /// </summary>
        /// <returns>Tipo específico deste utilizador: "Administrador"</returns>
        public override string ObterTipo()
        {
            return "Administrador";
        }

    }
}
