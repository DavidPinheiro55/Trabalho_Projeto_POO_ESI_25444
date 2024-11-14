using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Projeto_POO_ESI_25444
{
    // Declaração da classe Cliente, que herda da classe base Utilizador
    public class Cliente : Utilizador
    {
        // Construtor da classe Cliente, que chama o construtor da classe base Utilizador
        // Recebe como parâmetros o nome de utilizador e a palavra-passe
        public Cliente(string username, string password) : base(username, password) { }

        // Método que sobrescreve o método abstrato ObterTipo() da classe base Utilizador
        // Retorna o tipo específico deste utilizador: "Cliente"
        public override string ObterTipo()
        {
            return "Cliente";
        }
    }
}
