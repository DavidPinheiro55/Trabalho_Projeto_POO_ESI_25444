using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Projeto_POO_ESI_25444.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trabalho_Projeto_POO_ESI_25444
{
    
    public partial class FormCriarIncidente : Form
    {
        //private List<Incidente> listaIncidentes;
        private string nomeUtilizador;
        public FormCriarIncidente(string nomeUtilizador)
        {
            InitializeComponent();

            lblWelcome.Text = $"Bem-vindo, {nomeUtilizador}!"; // Defina o texto da Label
            this.nomeUtilizador = nomeUtilizador ;

            txtname.Text = nomeUtilizador;

            txtDateCriacao.Text = DateTime.Now.ToString();



            // Preencher o ComboBox de prioridade
            cmbPrioridade.Items.Add(Prioridade.Baixa);
            cmbPrioridade.Items.Add(Prioridade.Media);
            cmbPrioridade.Items.Add(Prioridade.Alta);
            cmbPrioridade.SelectedIndex = 0; // Definir um valor padrão

            //listaIncidentes = new List<Incidente>();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void FormCriarIncidente_Load(object sender, EventArgs e)
        {
           // lblWelcome.Text = $"Bem-vindo, {nomeUtilizador}!"; // Defina o texto da Label
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDateCriacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarIncidente_Click(object sender, EventArgs e)
        {
            string criador = txtname.Text;
            string descricao = txtDescricao.Text.Trim();
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, insira a descrição do problema.");
                return;
            }

            // Obter a prioridade selecionada
            Prioridade prioridadeSelecionada = (Prioridade)cmbPrioridade.SelectedItem;

            // Criar o incidente com o ID único
            Incidente novoIncidente = new Incidente(criador, descricao, prioridadeSelecionada);

            // Adiciona o incidente através do GestorIncidentes
            GestorIncidentes.AdicionarIncidente(novoIncidente);

            // Atualizar a lista de incidentes na interface
            //AtualizarListaIncidentes();
            //CarregarIncidentes(nomeUtilizador);


            // Limpar campos após criação do incidente
            txtDescricao.Clear();
            cmbPrioridade.SelectedIndex = 0;

            MessageBox.Show("Incidente criado com sucesso!");
        }

        private void btnCancelarIncidente_Click(object sender, EventArgs e)
        {
            FormUtilizador formUtilizador = new FormUtilizador(nomeUtilizador);
            formUtilizador.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormUtilizador formUtilizador = new FormUtilizador(nomeUtilizador);
            formUtilizador.Show();
            this.Close();
        }

        private void visualizarIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisualizarIncidente formVisualizarIncidente = new FormVisualizarIncidente(nomeUtilizador);
            formVisualizarIncidente.Show();
            this.Close();
        }

        private void arquivoIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArquivo formArquivo = new FormArquivo(nomeUtilizador);
            formArquivo.Show();
            this.Close();
        }
    }
}
