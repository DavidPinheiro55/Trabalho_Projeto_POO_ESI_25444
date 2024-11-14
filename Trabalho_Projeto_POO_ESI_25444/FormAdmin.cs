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
 
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void adiciobarTecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminAddTecnico formAdminAddTecnico = new FormAdminAddTecnico();
            formAdminAddTecnico.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
