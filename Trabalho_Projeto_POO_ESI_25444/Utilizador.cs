using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Projeto_POO_ESI_25444
{
    // Classe abstrata Utilizador, representando um utilizador genérico no sistema
    public abstract class Utilizador
    {
        // Propriedades que armazenam o nome do utilizador e a senha do utilizador
        public string Username { get; private set; }  // O nome do utilizador
        public string Password { get; private set; }  // A senha do utilizador

        // Construtor que inicializa o nome de usuário e a senha
        protected Utilizador(string username, string password)
        {
            Username = username;  // Inicializa a propriedade Username com o valor passado
            Password = password;  // Inicializa a propriedade Password com o valor passado
        }

        // Método abstrato que deve ser implementado pelas classes derivadas para retornar o tipo de utilizador
        public abstract string ObterTipo();

        // Método para verificar se as credenciais fornecidas coincidem com as do utilizador
        public bool VerificarCredenciais(string username, string password)
        {
            // Compara o nome do Utilizador e a senha do utilizador com os fornecidos
            return Username == username && Password == password;
        }
    }
}
