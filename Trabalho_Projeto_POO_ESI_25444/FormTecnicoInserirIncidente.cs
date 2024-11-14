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
    public partial class FormTecnicoInserirIncidente : Form
    {
        private string nomeUtilizador;
        public FormTecnicoInserirIncidente(string nomeUtilizador)
        {
            InitializeComponent();
            this.nomeUtilizador = nomeUtilizador;
            // Preencher o ComboBox de prioridade
            cmbPrioridade.Items.Add(Prioridade.Baixa);
            cmbPrioridade.Items.Add(Prioridade.Media);
            cmbPrioridade.Items.Add(Prioridade.Alta);
            cmbPrioridade.SelectedIndex = 0; // Definir um valor padrão

            txtDateCriacao.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtname_TextChanged(object sender, EventArgs e){}

        private void btnGuardarIncidente_Click(object sender, EventArgs e)
        {
            string user = txtname.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            // Verifica se a descrição está preenchida
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Por favor, insira a descrição do problema.");
                return;
            }

            // Obter a prioridade selecionada no combo box
            Prioridade prioridadeSelecionada;
            if (cmbPrioridade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma prioridade.");
                return;
            }
            prioridadeSelecionada = (Prioridade)cmbPrioridade.SelectedItem;

            // Cria o incidente com o nome do técnico atribuído e status inicial "NãoTratado"
            Incidente novoIncidente = new Incidente(user, descricao, prioridadeSelecionada)
            {
                Status = StatusIncidente.NãoTratado,
                TecnicoAtribuido = nomeUtilizador // Técnico que criou o incidente é o técnico atribuído
            };

            // Salva o incidente no arquivo usando o método do GestorIncidentes
            GestorIncidentes.AdicionarIncidente(novoIncidente);

            // Limpar campos após criação do incidente
            txtDescricao.Clear();
            cmbPrioridade.SelectedIndex = 0;

            MessageBox.Show("Incidente criado e salvo com sucesso!");
        }

        private void btnCancelarIncidente_Click(object sender, EventArgs e)
        {
           FormTecnico formTecnico = new FormTecnico(nomeUtilizador);
            formTecnico.Show();
            this.Close();
        }

        private void FormTecnicoInserirIncidente_Load(object sender, EventArgs e){}
    }
}
