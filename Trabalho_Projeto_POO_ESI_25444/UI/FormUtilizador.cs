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
   
    public partial class FormUtilizador : Form
    {
        private List<Incidente> listaIncidentes;
        private string nomeUtilizador;
        public FormUtilizador(string nomeUtilizador)
        {
            InitializeComponent();
            this.nomeUtilizador = nomeUtilizador;

            // Preencher o ComboBox de prioridade
            cmbPrioridade.Items.Add(Prioridade.Baixa);
            cmbPrioridade.Items.Add(Prioridade.Media);
            cmbPrioridade.Items.Add(Prioridade.Alta);
            cmbPrioridade.SelectedIndex = 0; // Definir um valor padrão
            listaIncidentes = new List<Incidente>();
            lblWelcome.Text = $"Bem-vindo, {nomeUtilizador}!"; // Defina o texto da Label
        
    }

        private void FormUtilizador_Load(object sender, EventArgs e)
        {
            CarregarIncidentes(nomeUtilizador);

            // Chama o método para carregar os incidentes na ComboBox
            CarregarIncidentesNaComboBox();

            
        }

        private void CarregarIncidentes(string username)
        {
            GestorIncidentes.AtualizarListaIncidentes(lstIncidentes, username);
        }
        private void btnCriarIncidente_Click(object sender, EventArgs e)
        {
            string criador = nomeUtilizador;
            string descricao = txtDescricao.Text.Trim();
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, insira a descrição do problema.");
                return;
            }

            // Obter a prioridade selecionada
            Prioridade prioridadeSelecionada = (Prioridade)cmbPrioridade.SelectedItem;

            // Criar o incidente com o ID único
            Incidente novoIncidente = new Incidente(nomeUtilizador, descricao, prioridadeSelecionada);

            // Adiciona o incidente através do GestorIncidentes
            GestorIncidentes.AdicionarIncidente(novoIncidente);

            // Atualizar a lista de incidentes na interface
            //AtualizarListaIncidentes();
            CarregarIncidentes(nomeUtilizador);
            

            // Limpar campos após criação do incidente
            txtDescricao.Clear();
            cmbPrioridade.SelectedIndex = 0;

            MessageBox.Show("Incidente criado com sucesso!");
        }


        private void lstIncidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado na ListBox
            if (lstIncidentes.SelectedItem != null)
            {
                // Obtém o incidente selecionado (aqui você assume que é uma string, ou então usa o objeto)
                string incidenteStr = lstIncidentes.SelectedItem.ToString();

                // Aqui, você pode pegar o incidente com base na descrição ou ID
                Incidente incidente = GestorIncidentes.ObterIncidentePorDescricao(incidenteStr);

                // Verifica se o incidente foi encontrado
                if (incidente != null)
                {
                    // Exibe uma MessageBox com os detalhes do incidente
                    string mensagem = $"ID: {incidente.Id}\n" +
                                      $"Criador: {incidente.Criador}\n" +
                                      $"Descrição: {incidente.Descricao}\n" +
                                      $"Data: {incidente.DataCriacao}\n" +
                                      $"Prioridade: {incidente.TipoPrioridade}";

                    MessageBox.Show(mensagem, "Detalhes do Incidente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lstIncidentes_MouseDoubleClick(object sender, MouseEventArgs e){}

        private void lstIncidentes_DoubleClick(object sender, EventArgs e){}

        private void lstIncidentes_Click(object sender, EventArgs e){}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbIncidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncidentes.SelectedItem != null)
            {
                // Pega o índice do item selecionado
                int selectedIndex = cmbIncidentes.SelectedIndex;

                // Carregar os incidentes com base no nome do utilizador
                List<Incidente> incidentes = GestorIncidentes.CarregarIncidentesPorCriador(nomeUtilizador);
                Incidente incidenteSelecionado = incidentes[selectedIndex];

                // Exibir os detalhes do incidente em uma MessageBox
                string mensagem = $"ID: {incidenteSelecionado.Id}\n" +
                                  $"Criador: {incidenteSelecionado.Criador}\n" +
                                  $"Descrição: {incidenteSelecionado.Descricao}\n" +
                                  $"Data: {incidenteSelecionado.DataCriacao}\n" +
                                  $"Prioridade: {incidenteSelecionado.TipoPrioridade}";

                MessageBox.Show(mensagem, "Detalhes do Incidente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Supondo que listaIncidentes já contém a lista de incidentes
        private void CarregarIncidentesNaComboBox()
        {
            cmbIncidentes.Items.Clear();  // Limpar antes de adicionar

            // Adicionar todos os incidentes na ComboBox
            foreach (var incidente in listaIncidentes)
            {
                cmbIncidentes.Items.Add(incidente.Descricao);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            // Verifica se algum incidente foi selecionado na ComboBox
            if (cmbIncidentes.SelectedItem != null)
            {
                // Obtém a descrição do incidente selecionado
                string descricaoSelecionada = cmbIncidentes.SelectedItem.ToString();

                // Aqui, você pode buscar o incidente na lista usando a descrição
                Incidente incidenteSelecionado = listaIncidentes.FirstOrDefault(i => i.Descricao == descricaoSelecionada);

                // Se o incidente for encontrado, exibe os detalhes
                if (incidenteSelecionado != null)
                {
                    // Exibe os detalhes do incidente em uma MessageBox
                    string mensagem = $"ID: {incidenteSelecionado.Id}\n" +
                                      $"Criador: {incidenteSelecionado.Criador}\n" +
                                      $"Descrição: {incidenteSelecionado.Descricao}\n" +
                                      $"Data: {incidenteSelecionado.DataCriacao}\n" +
                                      $"Prioridade: {incidenteSelecionado.TipoPrioridade}";

                    MessageBox.Show(mensagem, "Detalhes do Incidente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incidente não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um incidente.");
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e){}

        private void criarIncidentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCriarIncidente formCriarIncidente = new FormCriarIncidente(nomeUtilizador);
            formCriarIncidente.Show();
            this.Close();
        }

        private void cmbPrioridade_SelectedIndexChanged(object sender, EventArgs e){}

        private void txtDescricao_TextChanged(object sender, EventArgs e){}

        private void visualizarInidentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisualizarIncidente formVisualizarIncidente = new FormVisualizarIncidente(nomeUtilizador);
            formVisualizarIncidente.Show();
            this.Close();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArquivo formArquivo = new FormArquivo(nomeUtilizador);
            formArquivo.Show();
            this.Close();
        }
    }
}
