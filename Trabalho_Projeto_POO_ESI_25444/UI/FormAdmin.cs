using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Projeto_POO_ESI_25444
{
    public partial class FormAdmin : Form
    {
        private GestorUtilizadores gestorUtilizadores = new GestorUtilizadores();
        private List<Utilizador> listaUtilizadores = new List<Utilizador>(); // Lista local para armazenar os utilizadores
        private string senhaGerada; // Variável para armazenar a senha gerada para o novo técnico
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void adiciobarTecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
        private string GerarSenhaBasica()
        {
            // Conjunto de caracteres que podem ser usados na senha (letras maiúsculas e números)
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();  // Gerador de números aleatórios
            char[] senhaArray = new char[5];  // Array de 5 caracteres para a senha

            // Gera cada caractere da senha de forma aleatória
            for (int i = 0; i < senhaArray.Length; i++)
            {
                senhaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            // Retorna a senha gerada como uma string
            return new string(senhaArray);
        }

        private void btnInserirTecnico_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();  // Pega o nome de usuário do campo de texto e remove espaços extras

            // Verifica se o nome de usuário foi preenchido
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Se o campo estiver vazio, exibe uma mensagem de erro e retorna sem fazer mais nada
            }

            // Verifica se a senha foi gerada
            if (string.IsNullOrWhiteSpace(senhaGerada))
            {
                MessageBox.Show("Por favor, gere a senha antes de inserir o técnico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Se a senha não foi gerada, exibe um erro e retorna
            }

            //######################  CRIAR NOVO TÉCNICO ##################################  
            Tecnico novoTecnico = new Tecnico(username, senhaGerada);
            // Adiciona o novo técnico à lista local de utilizadores
            listaUtilizadores.Add(novoTecnico);
            //#############################################################################


            // Registra o novo técnico no arquivo "utilizadores.txt" usando o GestorUtilizadores
            bool registrado = gestorUtilizadores.RegistarUtilizador(novoTecnico);

            // Verifica se o técnico foi registrado com sucesso
            if (registrado)
            {
                MessageBox.Show("Técnico inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos de entrada para uma nova inserção
                txtUsername.Clear();
                txtpassword.Clear();
                senhaGerada = null;  // Reseta a senha gerada para evitar duplicações
            }
            else
            {
                MessageBox.Show("Nome de utilizador já existe. Escolha outro nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Gera uma senha básica de 5 caracteres
            senhaGerada = GerarSenhaBasica();

            // Exibe a senha gerada em uma caixa de mensagem
            MessageBox.Show($"A senha gerada para o técnico é: {senhaGerada}", "Senha Gerada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Preenche o campo de senha com a senha gerada
            txtpassword.Text = senhaGerada;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
