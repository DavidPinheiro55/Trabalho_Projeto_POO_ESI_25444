using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Projeto_POO_ESI_25444
{
    // Classe Técnico, que herda da classe Utilizador
    public class Tecnico : Utilizador
    {
        // Construtor da classe Técnico, que chama o construtor da classe base (Utilizador)
        public Tecnico(string username, string password) : base(username, password) { }

        // Implementação do método abstrato ObterTipo, específico para o técnico
        public override string ObterTipo()
        {
            return "Técnico"; // Retorna o tipo de utilizador "Técnico"
        }

        // Método para resolver problemas, recebe a descrição do problema como parâmetro
        public void ResolverProblema(string descricaoProblema)
        {
            // Implementação fictícia que simula a resolução de um problema
            Console.WriteLine($"O técnico {Username} está a resolver o problema: {descricaoProblema}");
        }
    }
}
