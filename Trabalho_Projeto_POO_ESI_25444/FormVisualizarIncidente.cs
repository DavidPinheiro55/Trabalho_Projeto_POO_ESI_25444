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
    public partial class FormVisualizarIncidente : Form
    {
       // private List<Incidente> listaIncidentes;
        private string nomeUtilizador;
        public FormVisualizarIncidente(string nomeUtilizador)
        {
            InitializeComponent();

            lblWelcome.Text = $"Bem-vindo, {nomeUtilizador}!"; // Defina o texto da Label
            this.nomeUtilizador = nomeUtilizador ;
            
        }

        private void FormVisualizarIncidente_Load(object sender, EventArgs e)
        {
            // Configurar o DataGridView(caso não tenha feito no Designer)
            ConfigurarDataGridView();

            // Carregar os incidentes na tabela
            CarregarIncidentesNaTabela(nomeUtilizador);
        }

        private void ConfigurarDataGridView()
        {
            // Limpar as colunas existentes, caso existam
            dgvIncidentes.Columns.Clear();

            // Adicionar as colunas necessárias
            dgvIncidentes.Columns.Add("ID", "ID");
            dgvIncidentes.Columns.Add("Nome", "Nome");
            dgvIncidentes.Columns.Add("Descricao", "Descrição");
            dgvIncidentes.Columns.Add("Prioridade", "Tipo de Prioridade");
            dgvIncidentes.Columns.Add("Técnico Responsavel", "Técnico Responsavel");

            // Você pode adicionar mais colunas futuramente, como Status e Técnico Responsável

            // Definir a largura das colunas
            dgvIncidentes.Columns["ID"].Width = 50;
            dgvIncidentes.Columns["Nome"].Width = 50;
            dgvIncidentes.Columns["Descricao"].Width = 210;
            dgvIncidentes.Columns["Prioridade"].Width = 55;
            dgvIncidentes.Columns["Técnico Responsavel"].Width = 80;
        }

        private void CarregarIncidentesNaTabela(string nomeUtilizador)
        {
            // Carrega todos os incidentes do arquivo usando o método original
            List<Incidente> todosIncidentes = GestorIncidentes.CarregarIncidentesDoArquivo(nomeUtilizador);

            // Filtra os incidentes não tratados pelo Utilizador
            var incidentesNaoTratados = todosIncidentes.Where(i => i.Criador == nomeUtilizador && i.Status == StatusIncidente.NãoTratado).ToList();

           
           
                // Limpa as linhas atuais no DataGridView
                dgvIncidentes.Rows.Clear();

                // Adiciona cada incidente não tratado ao DataGridView
                foreach (var incidente in incidentesNaoTratados)
                {
                    dgvIncidentes.Rows.Add(
                        incidente.Id,                    
                        incidente.Criador,
                        incidente.Descricao,
                        incidente.TipoPrioridade.ToString(),
                        incidente.Status.ToString(),
                        incidente.TecnicoAtribuido
                    );
                }
            
        }

        private void criarIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormCriarIncidente formCriarIncidente = new FormCriarIncidente(nomeUtilizador);
            formCriarIncidente.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormUtilizador formUtilizador = new FormUtilizador(nomeUtilizador);
            formUtilizador.Show();
            this.Close();
        }

        private void dgvIncidentes_CellContentClick(object sender, DataGridViewCellEventArgs e){}
    }
}
