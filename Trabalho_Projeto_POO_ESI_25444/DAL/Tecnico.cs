using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Projeto_POO_ESI_25444
{
    /// <summary>
    /// Classe Técnico, que herda da classe Utilizador
    /// </summary>
    public class Tecnico : Utilizador
    {
        /// <summary>
        /// Construtor da classe Técnico, que chama o construtor da classe base (Utilizador)
        /// </summary>
        /// <param name="username">O nome de utilizador do técnico.</param>
        /// <param name="password">A Password do técnico.</param>
        public Tecnico(string username, string password) : base(username, password) { }

        /// <summary>
        /// Implementação do método abstrato ObterTipo, específico para o técnico
        /// </summary>
        /// <returns>Tipo de utilizador "Técnico"</returns>
        public override string ObterTipo()
        {
            return "Técnico"; 
        }
    }
}
