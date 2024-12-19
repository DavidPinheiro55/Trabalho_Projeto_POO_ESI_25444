using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabalho_Projeto_POO_ESI_25444
{
    // Classe parcial FormLogin, que herda da classe Form, para implementar o formulário de login
    public partial class FormLogin : Form
    {
        
        // Criação de uma instância do gestor de utilizadores para gerir autenticação e registo
        private GestorUtilizadores gestorUtilizadores = new GestorUtilizadores();
        
        
        // Construtor do FormLogin, responsável por inicializar os componentes do formulário
        public FormLogin()
        {
            InitializeComponent();

            // Verificar se o administrador está presente no arquivo
            gestorUtilizadores.VerificarAdministrador();
        }

        // Evento que é executado ao carregar o formulário
        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Este método está vazio, mas pode ser usado para configurar o formulário ao abrir
        }

        // Evento disparado ao clicar no botão "Login"
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Extrai o nome de utilizador e palavra-passe, removendo espaços em branco
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Tenta autenticar o utilizador usando o gestor de utilizadores
            Utilizador utilizador = gestorUtilizadores.AutenticarUtilizador(username, password);

            // Verifica se a autenticação foi bem-sucedida
            if (utilizador != null)
            {
                // Caso o login seja bem-sucedido, verifica o tipo de utilizador para abrir o formulário correspondente

                if (utilizador.ObterTipo() == "Administrador")
                {
                    // Abre o formulário de administração
                    //FormUtilizador formUtilizador = new FormUtilizador(utilizador.Username);
                    //formUtilizador.Show();
                    FormAdmin formadmin = new FormAdmin();
                    formadmin.Show();
                    
                }
                else if (utilizador.ObterTipo() == "Técnico")
                {
                    // Abre o formulário de técnico (comentado aqui, mas deve ser implementado para técnicos)
                    //FormTecnico formTecnico = new FormTecnico();
                    //formTecnico.Show();
                    FormTecnico formTecnico = new FormTecnico(utilizador.Username);
                    formTecnico.Show();
                                        
                   
                }
                else if (utilizador.ObterTipo() == "Cliente")
                {
                    // Abre o formulário de utilizador para clientes
                    FormUtilizador formUtilizador = new FormUtilizador(utilizador.Username);
                    formUtilizador.Show();
                }

                // Oculta o formulário de login
                this.Hide();
            }
            else
            {
                // Caso as credenciais estejam erradas, exibe mensagem de erro e limpa os campos
                MessageBox.Show("Nome de utilizador ou palavra-passe inválida.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        // Evento disparado ao clicar no botão "Registar"
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            // Extrai o nome de utilizador e palavra-passe, removendo espaços em branco
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Verifica se os campos de nome de utilizador e palavra-passe estão preenchidos
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return; // Termina a execução do método caso algum campo esteja vazio
            }

            // Cria um novo utilizador com o tipo "Cliente" por defeito
            Utilizador novoUtilizador = new Cliente(username, password);

            // Tenta registar o novo utilizador no sistema
            if (gestorUtilizadores.RegistarUtilizador(novoUtilizador))
            {
                // Informa que o registo foi bem-sucedido e limpa os campos
                MessageBox.Show("Utilizador registado com sucesso!");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                // Caso o nome de utilizador já exista, exibe mensagem de erro e limpa os campos
                MessageBox.Show("Nome de utilizador já existe. Escolha outro nome de utilizador.");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }
    }
}
