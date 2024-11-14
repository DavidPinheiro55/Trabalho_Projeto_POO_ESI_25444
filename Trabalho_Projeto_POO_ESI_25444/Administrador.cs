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
        // Construtor da classe Administrador, que chama o construtor da classe base Utilizador
        public Administrador(string username, string password) : base(username, password) { }

        // Método que sobrescreve o método ObterTipo() da classe base Utilizador
        // Retorna o tipo específico deste utilizador: "Administrador"
        public override string ObterTipo()
        {
            return "Administrador";
        }

        // Método específico da classe Administrador para gerir utilizadores
        public void GerirUtilizadores()
        {
            Console.WriteLine("Administrador a gerir utilizadores.");
        }
    }
}
