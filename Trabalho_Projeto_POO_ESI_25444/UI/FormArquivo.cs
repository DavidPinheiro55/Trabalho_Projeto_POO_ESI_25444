using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Projeto_POO_ESI_25444.Enum;

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

        }
        private void FormArquivo_Load(object sender, EventArgs e)
        {
            CarregarIncidentes(nomeUtilizador);
            numericUpDownAvaliacao.Visible = false;
            btnGuardar.Visible = false;
            label8.Visible = false;
        }

        private void CarregarIncidentes(string username)
        {
            listaIncidentes = GestorIncidentes.CarregarIncidentesDoArquivo(username);

            if (listaIncidentes == null || listaIncidentes.Count == 0)
            {
                MessageBox.Show("Nenhum incidente foi carregado.");
                return;
            }

            GestorIncidentes.AtualizarListaIncidentes(checklistIncidentes, username);

        }
        private void checklistIncidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checklistIncidentes.SelectedItem != null)
            {
                // Mostra os elementos para avaliação
                numericUpDownAvaliacao.Visible = true;
                btnGuardar.Visible = true;
                label8.Visible = true;

                // Configura o valor máximo e mínimo
                numericUpDownAvaliacao.Minimum = 1;
                numericUpDownAvaliacao.Maximum = 10;

                // Recupera o ID do incidente selecionado
                //int idIncidenteSelecionado = int.Parse(checklistIncidentes.SelectedItem.ToString().Split('-')[0].Replace("ID:", "").Trim());
                int idIncidenteSelecionado = int.Parse(checklistIncidentes.SelectedItem.ToString().Split('-')[0].Replace("ID:", "").Trim());

                var incidenteSelecionado = listaIncidentes.FirstOrDefault(i => i.Id == idIncidenteSelecionado);

                if (incidenteSelecionado == null)
                {
                    MessageBox.Show($"Incidente com ID {idIncidenteSelecionado} não encontrado.");
                    return;
                }

                if (incidenteSelecionado != null)
                {
                    // Atualiza os campos do formulário com os dados do incidente
                    textBox1.Text = incidenteSelecionado.Id.ToString();
                    textBox2.Text = incidenteSelecionado.DataCriacao.ToString("dd/MM/yyyy HH:mm:ss");
                    txtNomeUtilizador.Text = incidenteSelecionado.Criador;
                    txttecnico.Text = incidenteSelecionado.TecnicoAtribuido ?? ""; // Caso seja nulo, preencha com string vazia
                    txtStatus.Text = incidenteSelecionado.Status.ToString();
                    textBox3.Text = incidenteSelecionado.Descricao;
                    txtresolucao.Text = incidenteSelecionado.Resolucao ?? ""; // Caso seja nulo, preencha com string vazia
                    txtprioridade.Text = incidenteSelecionado.TipoPrioridade.ToString();

                    // Ajusta a avaliação
                    numericUpDownAvaliacao.Value = incidenteSelecionado.Avaliacao.HasValue ? incidenteSelecionado.Avaliacao.Value : 1;
                }
            }
            else
            {
                // Caso nenhum incidente seja selecionado, esconda os campos
                numericUpDownAvaliacao.Visible = false;
                btnGuardar.Visible = false;
                label8.Visible = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checklistIncidentes.SelectedItem != null)
            {
                try
                {
                    int idIncidenteSelecionado = int.Parse(checklistIncidentes.SelectedItem.ToString().Split('-')[0].Replace("ID:", "").Trim());
                    var incidenteSelecionado = listaIncidentes.FirstOrDefault(i => i.Id == idIncidenteSelecionado);

                    if (incidenteSelecionado != null)
                    {
                        incidenteSelecionado.Avaliacao = (int)numericUpDownAvaliacao.Value;

                        // Persistir dados no TXT
                        GestorIncidentes.AtualizarIncidente(incidenteSelecionado, txtresolucao.Text);

                        MessageBox.Show($"Avaliação de {numericUpDownAvaliacao.Value} salva com sucesso para o incidente ID {incidenteSelecionado.Id}!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar avaliação: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Nenhum incidente selecionado.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
