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
    public partial class FormArquivo : Form
    {
        private List<Incidente> listaIncidentes;
        private string nomeUtilizador;
        public FormArquivo(string nomeUtilizador)
        {
            InitializeComponent();
            this.nomeUtilizador = nomeUtilizador;
            label7.Text = nomeUtilizador;

        }
        private void FormArquivo_Load(object sender, EventArgs e)
        {
            CarregarIncidentes(nomeUtilizador);
        }

        private void CarregarIncidentes(string username)
        {
            GestorIncidentes.AtualizarListaIncidentes(checklistIncidentes, username);
        }
        private void checklistIncidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se um item foi selecionado
            if (checklistIncidentes.SelectedItem != null)
            {
                string descricaoIncidente = checklistIncidentes.SelectedItem.ToString();

                // Você pode procurar o incidente original a partir da string mostrada na checklist
                // A string na checklist contém o ID e a Descrição, então você pode buscar o incidente correspondente
                int idIncidente = int.Parse(descricaoIncidente.Split('-')[0].Replace("ID:", "").Trim());

                // Encontrar o incidente com base no ID
                Incidente incidenteSelecionado = listaIncidentes.FirstOrDefault(i => i.Id == idIncidente);

                if (incidenteSelecionado != null)
                {
                    // Preenche os campos de texto com os detalhes do incidente
                    textBox1.Text = incidenteSelecionado.Id.ToString();
                    textBox2.Text = incidenteSelecionado.DataCriacao.ToString("dd/MM/yyyy HH:mm:ss");
                    txtNomeUtilizador.Text = incidenteSelecionado.Criador;
                    txttecnico.Text = incidenteSelecionado.TecnicoAtribuido;
                    txtStatus.Text = incidenteSelecionado.Status.ToString();
                    textBox3.Text = incidenteSelecionado.Descricao;
                    txtresolucao.Text = incidenteSelecionado.Resolucao;
                    txtprioridade.Text = incidenteSelecionado.TipoPrioridade.ToString();
                }
                checklistIncidentes.Refresh();
            }
        }

      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            FormArquivo formArquivo = new FormArquivo(nomeUtilizador);
            formArquivo.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormUtilizador formUser = new FormUtilizador(nomeUtilizador);
            formUser.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void criarIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCriarIncidente formCriarIncidente = new FormCriarIncidente(nomeUtilizador);
            formCriarIncidente.Show();
            this.Close();
        }

        private void visualizarIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisualizarIncidente formVisualizarIncidente = new FormVisualizarIncidente(nomeUtilizador);
            formVisualizarIncidente.Show();
            this.Close();
        }

        private void checklistIncidentes_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
