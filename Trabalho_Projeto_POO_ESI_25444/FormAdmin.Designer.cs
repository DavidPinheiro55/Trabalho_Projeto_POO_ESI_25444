namespace Trabalho_Projeto_POO_ESI_25444
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incidentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionaUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUtilzadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adiciobarTecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentesToolStripMenuItem,
            this.utilizadoresToolStripMenuItem,
            this.tecnicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incidentesToolStripMenuItem
            // 
            this.incidentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarIncidenteToolStripMenuItem,
            this.visuaToolStripMenuItem});
            this.incidentesToolStripMenuItem.Name = "incidentesToolStripMenuItem";
            this.incidentesToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.incidentesToolStripMenuItem.Text = "Incidentes";
            // 
            // criarIncidenteToolStripMenuItem
            // 
            this.criarIncidenteToolStripMenuItem.Name = "criarIncidenteToolStripMenuItem";
            this.criarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.criarIncidenteToolStripMenuItem.Text = "Criar Incidente";
            // 
            // visuaToolStripMenuItem
            // 
            this.visuaToolStripMenuItem.Name = "visuaToolStripMenuItem";
            this.visuaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.visuaToolStripMenuItem.Text = "Visualizar Incidentes";
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionaUtilizadorToolStripMenuItem,
            this.removerUtilizadorToolStripMenuItem,
            this.listarUtilzadoresToolStripMenuItem});
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.utilizadoresToolStripMenuItem.Text = "Utilizadores";
            // 
            // adicionaUtilizadorToolStripMenuItem
            // 
            this.adicionaUtilizadorToolStripMenuItem.Name = "adicionaUtilizadorToolStripMenuItem";
            this.adicionaUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.adicionaUtilizadorToolStripMenuItem.Text = "Adicionar Utilizador";
            // 
            // removerUtilizadorToolStripMenuItem
            // 
            this.removerUtilizadorToolStripMenuItem.Name = "removerUtilizadorToolStripMenuItem";
            this.removerUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.removerUtilizadorToolStripMenuItem.Text = "Remover Utilizador";
            // 
            // listarUtilzadoresToolStripMenuItem
            // 
            this.listarUtilzadoresToolStripMenuItem.Name = "listarUtilzadoresToolStripMenuItem";
            this.listarUtilzadoresToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.listarUtilzadoresToolStripMenuItem.Text = "Listar Utilzadores";
            // 
            // tecnicosToolStripMenuItem
            // 
            this.tecnicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adiciobarTecnicosToolStripMenuItem});
            this.tecnicosToolStripMenuItem.Name = "tecnicosToolStripMenuItem";
            this.tecnicosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.tecnicosToolStripMenuItem.Text = "Tecnicos";
            // 
            // adiciobarTecnicosToolStripMenuItem
            // 
            this.adiciobarTecnicosToolStripMenuItem.Name = "adiciobarTecnicosToolStripMenuItem";
            this.adiciobarTecnicosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.adiciobarTecnicosToolStripMenuItem.Text = "Adicionar Tecnicos";
            this.adiciobarTecnicosToolStripMenuItem.Click += new System.EventHandler(this.adiciobarTecnicosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Projeto_POO_ESI_25444.Properties.Resources.power_off;
            this.pictureBox1.Location = new System.Drawing.Point(750, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incidentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarIncidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionaUtilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerUtilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUtilzadoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem visuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adiciobarTecnicosToolStripMenuItem;
    }
}