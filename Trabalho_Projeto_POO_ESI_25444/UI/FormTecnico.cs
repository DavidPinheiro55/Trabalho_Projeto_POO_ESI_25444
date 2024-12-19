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
    public partial class FormTecnico : Form
    {
        private string nomeUtilizador;
        public FormTecnico(string nomeUtilizador)
        {
            InitializeComponent();

            int porAtribuirCount = GestorIncidentes.ContarIncidentesPorAtribuir();
            //MessageBox.Show($"Existem {porAtribuirCount} incidentes Por Atribuir.", "Incidentes Por Atribuir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            linkLabel2.Text = porAtribuirCount.ToString();

            int ntratados = GestorIncidentes.ContarIncidentesNaoTratados(nomeUtilizador);
            linkLabel1.Text = ntratados.ToString();
            this.nomeUtilizador = nomeUtilizador;
            //lblwelcome.Text = nomeUtilizador.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){}

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){}

        private void FormTecnico_Load(object sender, EventArgs e)
        {
            CarregarIncidentesNaoAtribuidos();
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

        private void checklistincidente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cria uma lista para armazenar os itens selecionados
            List<int> incidentesSelecionados = new List<int>();

            // Armazena os IDs dos incidentes selecionados
            foreach (var item in checklistincidente.SelectedItems)
            {
                string selectedItem = item.ToString();
                // Extraímos o ID do incidente da string formatada (ex: "ID: 1 - Descrição do incidente")
                int idIncidente = int.Parse(selectedItem.Split('-')[0].Replace("ID: ", "").Trim());
                incidentesSelecionados.Add(idIncidente);
            }

            // Agora, fora da iteração, modifique os incidentes selecionados
            foreach (int id in incidentesSelecionados)
            {
                string tecnicoResponsavel = nomeUtilizador; // Aqui você pode pegar dinamicamente o técnico responsável

                // Atualiza o incidente e atribui o técnico
                GestorIncidentes.ResgatarIncidente(id, tecnicoResponsavel);
            }

            // Após modificar os incidentes, recarrega a lista de incidentes não atribuídos
            CarregarIncidentesNaoAtribuidos(); // Atualiza a visualização dos incidentes
            checklistincidente.Refresh();
            GestorIncidentes.ContarIncidentesNaoTratados(nomeUtilizador);
            GestorIncidentes.ContarIncidentesPorAtribuir();
        }

        // Carrega a lista de incidentes não atribuídos no CheckedListBox
        private void CarregarIncidentesNaoAtribuidos()
        {
            // Limpa a lista antes de carregar os novos incidentes
            checklistincidente.Items.Clear();

            // Obter a lista de incidentes não atribuídos
            List<Incidente> incidentesNaoAtribuidos = GestorIncidentes.ObterIncidentesNaoAtribuidos();
            // Adiciona cada incidente não atribuído na CheckListBox
            foreach (var incidente in incidentesNaoAtribuidos)
            {
                checklistincidente.Items.Add($"ID: {incidente.Id} - {incidente.Criador} - {incidente.Descricao} - {incidente.TipoPrioridade} ");
            }

            // Se não houver incidentes não atribuídos, exibe uma mensagem
            if (incidentesNaoAtribuidos.Count == 0)
            {
                checklistincidente.Items.Add("Não há incidentes não atribuídos.");
            }
        }

        private void btnresgatar_Click(object sender, EventArgs e){}

        private void tratarIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTecnicoTratarIncidentes formTecnicoTratarIncidentes = new FormTecnicoTratarIncidentes(nomeUtilizador);
            formTecnicoTratarIncidentes.Show();
            this.Close();

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTecnico formTecnico = new FormTecnico(nomeUtilizador);
            formTecnico.Show();
            this.Close();
        }
    }
}
