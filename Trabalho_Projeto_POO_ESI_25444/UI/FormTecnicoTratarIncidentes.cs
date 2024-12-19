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

namespace Trabalho_Projeto_POO_ESI_25444
{
    public partial class FormTecnicoTratarIncidentes : Form
    {
        private string nomeUtilizador;
        public FormTecnicoTratarIncidentes(string nomeUtilizador)
        {
            InitializeComponent();
            this.nomeUtilizador = nomeUtilizador;
            //lblwelcome.Text = nomeUtilizador;
        }

        private void FormTecnicoTratarIncidentes_Load(object sender, EventArgs e)
        {
            GestorIncidentes.CarregarIncidentesNaoAtribuidos(checklistIncidentes);
            // Carregar os incidentes não tratados atribuídos ao técnico logado
            List<Incidente> incidentesNaoTratados = GestorIncidentes.ObterIncidentesNaoTratadosPorTecnico(nomeUtilizador);

            // Limpa o ListBox antes de adicionar os novos itens
            checklistIncidentes.Items.Clear();

            // Adiciona os incidentes ao ListBox
            foreach (var incidente in incidentesNaoTratados)
            {
                checklistIncidentes.Items.Add($"ID: {incidente.Id} - {incidente.Descricao}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}

       
        private void checklistIncidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checklistIncidentes.SelectedItem != null)
            {
                string itemSelecionado = checklistIncidentes.SelectedItem.ToString();
                int idIncidente = int.Parse(itemSelecionado.Split('-')[0].Replace("ID: ", "").Trim());

                // Obtém os detalhes do incidente selecionado
                Incidente incidenteSelecionado = GestorIncidentes.ObterIncidentePorId(idIncidente);

                // Preenche os campos de texto com os detalhes do incidente
                textBox1.Text = incidenteSelecionado.Id.ToString();
                textBox3.Text = incidenteSelecionado.Descricao;
                txtNomeUtilizador.Text = incidenteSelecionado.Criador;
                textBox2.Text = incidenteSelecionado.DataCriacao.ToString();
                txtprioridade.Text = incidenteSelecionado.TipoPrioridade.ToString();
                //txtStatus.Text = incidenteSelecionado.Status.ToString();
            }
        }

        private void btntratado_Click(object sender, EventArgs e)
        {
            if (checklistIncidentes.SelectedItem != null)
            {
                string itemSelecionado = checklistIncidentes.SelectedItem.ToString();
                int idIncidente = int.Parse(itemSelecionado.Split('-')[0].Replace("ID: ", "").Trim());

                // Obtém o incidente selecionado
                Incidente incidenteSelecionado = GestorIncidentes.ObterIncidentePorId(idIncidente);

                // Atualiza o status e as informações de resolução
                string informacoesResolucao = txtresolucao.Text;
                incidenteSelecionado.Status = StatusIncidente.Tratado; // Definindo o status como tratado

                // Atualiza o incidente com as informações de resolução
                GestorIncidentes.AtualizarIncidente(incidenteSelecionado, informacoesResolucao);

                MessageBox.Show("Incidente tratado com sucesso!");
                FormTecnicoTratarIncidentes formTecnicoTratarIncidente = new FormTecnicoTratarIncidentes(nomeUtilizador);
                formTecnicoTratarIncidente.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um incidente.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inserirIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTecnicoInserirIncidente formTecnicoInserirIncidente = new FormTecnicoInserirIncidente(nomeUtilizador);
            formTecnicoInserirIncidente.Show();
            this.Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTecnico formTecnico = new FormTecnico(nomeUtilizador);
            formTecnico.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormTecnicoTratarIncidentes formTecnicoTratarIncidente = new FormTecnicoTratarIncidentes(nomeUtilizador);
            formTecnicoTratarIncidente.Show();
            this.Close();
        }
    }
}
