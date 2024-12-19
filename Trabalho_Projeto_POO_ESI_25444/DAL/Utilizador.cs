using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trabalho_Projeto_POO_ESI_25444
{
    /// <summary>
    /// Classe abstrata Utilizador, representando um utilizador genérico no sistema
    /// </summary>
    public abstract class Utilizador
    {
        /// <summary>
        /// Propriedades que armazenam o nome do utilizador e a password do utilizador
        /// </summary>
        private string _username;  
        public string Username
        {
            get { return _username; } 
            set { _username = value; } 
        }
        private string _password;  
        public string Password
        {
            get { return _password; } 
            set { _password = value; } 
        }

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="username">Inicializa a propriedade Username com o valor passado</param>
        /// <param name="password">Inicializa a propriedade Password com o valor passado</param>
        protected Utilizador(string username, string password)
        {
            Username = username;  
            Password = password; 
        }

        /// <summary>
        /// Método abstrato que deve ser implementado pelas classes derivadas para retornar o tipo de utilizador
        /// </summary>
        public abstract string ObterTipo();

        /// <summary>
        /// Método para verificar se as credenciais fornecidas coincidem com as do utilizador
        /// </summary>
        public bool VerificarCredenciais(string username, string password)
        {
            // Compara o nome do Utilizador e a password do utilizador com os fornecidos
            return Username == username && Password == password;
        }
    }
}
