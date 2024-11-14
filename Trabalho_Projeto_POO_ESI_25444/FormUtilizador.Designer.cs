namespace Trabalho_Projeto_POO_ESI_25444
{
    partial class FormUtilizador
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.btnCriarIncidente = new System.Windows.Forms.Button();
            this.lstIncidentes = new System.Windows.Forms.ListBox();
            this.lblIncidentesCria = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbIncidentes = new System.Windows.Forms.ComboBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incidentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarIncidentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarInidentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(53, 44);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Criação Incidentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição : ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(111, 126);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(163, 110);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(39, 87);
            this.lblPrioridade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(63, 13);
            this.lblPrioridade.TabIndex = 3;
            this.lblPrioridade.Text = "Prioridade : ";
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Location = new System.Drawing.Point(111, 87);
            this.cmbPrioridade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(92, 21);
            this.cmbPrioridade.TabIndex = 4;
            this.cmbPrioridade.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridade_SelectedIndexChanged);
            // 
            // btnCriarIncidente
            // 
            this.btnCriarIncidente.Location = new System.Drawing.Point(56, 278);
            this.btnCriarIncidente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriarIncidente.Name = "btnCriarIncidente";
            this.btnCriarIncidente.Size = new System.Drawing.Size(106, 19);
            this.btnCriarIncidente.TabIndex = 5;
            this.btnCriarIncidente.Text = "Criar Incidente";
            this.btnCriarIncidente.UseVisualStyleBackColor = true;
            this.btnCriarIncidente.Click += new System.EventHandler(this.btnCriarIncidente_Click);
            // 
            // lstIncidentes
            // 
            this.lstIncidentes.FormattingEnabled = true;
            this.lstIncidentes.Location = new System.Drawing.Point(355, 65);
            this.lstIncidentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstIncidentes.Name = "lstIncidentes";
            this.lstIncidentes.Size = new System.Drawing.Size(225, 186);
            this.lstIncidentes.TabIndex = 6;
            this.lstIncidentes.Click += new System.EventHandler(this.lstIncidentes_Click);
            this.lstIncidentes.SelectedIndexChanged += new System.EventHandler(this.lstIncidentes_SelectedIndexChanged);
            this.lstIncidentes.DoubleClick += new System.EventHandler(this.lstIncidentes_DoubleClick);
            this.lstIncidentes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstIncidentes_MouseDoubleClick);
            // 
            // lblIncidentesCria
            // 
            this.lblIncidentesCria.AutoSize = true;
            this.lblIncidentesCria.Location = new System.Drawing.Point(355, 47);
            this.lblIncidentesCria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentesCria.Name = "lblIncidentesCria";
            this.lblIncidentesCria.Size = new System.Drawing.Size(94, 13);
            this.lblIncidentesCria.TabIndex = 7;
            this.lblIncidentesCria.Text = "Incidentes Criados";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(227, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(57, 20);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "label2";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // cmbIncidentes
            // 
            this.cmbIncidentes.FormattingEnabled = true;
            this.cmbIncidentes.Location = new System.Drawing.Point(352, 278);
            this.cmbIncidentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIncidentes.Name = "cmbIncidentes";
            this.cmbIncidentes.Size = new System.Drawing.Size(92, 21);
            this.cmbIncidentes.TabIndex = 10;
            this.cmbIncidentes.SelectedIndexChanged += new System.EventHandler(this.cmbIncidentes_SelectedIndexChanged);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(352, 318);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(56, 19);
            this.btnVisualizar.TabIndex = 11;
            this.btnVisualizar.Text = "Visualziar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incidentesToolStripMenuItem
            // 
            this.incidentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarIncidentesToolStripMenuItem,
            this.visualizarInidentesToolStripMenuItem,
            this.arquivoToolStripMenuItem});
            this.incidentesToolStripMenuItem.Name = "incidentesToolStripMenuItem";
            this.incidentesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.incidentesToolStripMenuItem.Text = "Incidentes";
            // 
            // criarIncidentesToolStripMenuItem
            // 
            this.criarIncidentesToolStripMenuItem.Name = "criarIncidentesToolStripMenuItem";
            this.criarIncidentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarIncidentesToolStripMenuItem.Text = "Criar Incidentes";
            this.criarIncidentesToolStripMenuItem.Click += new System.EventHandler(this.criarIncidentesToolStripMenuItem_Click);
            // 
            // visualizarInidentesToolStripMenuItem
            // 
            this.visualizarInidentesToolStripMenuItem.Name = "visualizarInidentesToolStripMenuItem";
            this.visualizarInidentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarInidentesToolStripMenuItem.Text = "Visualizar Inidentes";
            this.visualizarInidentesToolStripMenuItem.Click += new System.EventHandler(this.visualizarInidentesToolStripMenuItem_Click);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Projeto_POO_ESI_25444.Properties.Resources.power_off;
            this.pictureBox1.Location = new System.Drawing.Point(562, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.cmbIncidentes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblIncidentesCria);
            this.Controls.Add(this.lstIncidentes);
            this.Controls.Add(this.btnCriarIncidente);
            this.Controls.Add(this.cmbPrioridade);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUtilizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUtilizador";
            this.Load += new System.EventHandler(this.FormUtilizador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Button btnCriarIncidente;
        private System.Windows.Forms.ListBox lstIncidentes;
        private System.Windows.Forms.Label lblIncidentesCria;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbIncidentes;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incidentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarIncidentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarInidentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
    }
}