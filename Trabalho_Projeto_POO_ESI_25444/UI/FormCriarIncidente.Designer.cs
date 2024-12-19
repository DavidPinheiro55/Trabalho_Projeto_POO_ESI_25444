namespace Trabalho_Projeto_POO_ESI_25444
{
    partial class FormCriarIncidente
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
            this.incidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtDateCriacao = new System.Windows.Forms.TextBox();
            this.lblDetalheInci = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnGuardarIncidente = new System.Windows.Forms.Button();
            this.btnCancelarIncidente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incidenteToolStripMenuItem
            // 
            this.incidenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarIncidenteToolStripMenuItem,
            this.visualizarIncidenteToolStripMenuItem,
            this.arquivoIncidenteToolStripMenuItem});
            this.incidenteToolStripMenuItem.Name = "incidenteToolStripMenuItem";
            this.incidenteToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.incidenteToolStripMenuItem.Text = "Incidente";
            // 
            // criarIncidenteToolStripMenuItem
            // 
            this.criarIncidenteToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.criarIncidenteToolStripMenuItem.Name = "criarIncidenteToolStripMenuItem";
            this.criarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.criarIncidenteToolStripMenuItem.Text = "Criar Incidente";
            // 
            // visualizarIncidenteToolStripMenuItem
            // 
            this.visualizarIncidenteToolStripMenuItem.Name = "visualizarIncidenteToolStripMenuItem";
            this.visualizarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.visualizarIncidenteToolStripMenuItem.Text = "Visualizar Incidente";
            this.visualizarIncidenteToolStripMenuItem.Click += new System.EventHandler(this.visualizarIncidenteToolStripMenuItem_Click);
            // 
            // arquivoIncidenteToolStripMenuItem
            // 
            this.arquivoIncidenteToolStripMenuItem.Name = "arquivoIncidenteToolStripMenuItem";
            this.arquivoIncidenteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arquivoIncidenteToolStripMenuItem.Text = "Arquivo Incidente";
            this.arquivoIncidenteToolStripMenuItem.Click += new System.EventHandler(this.arquivoIncidenteToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(340, 0);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(15, 24);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = ".";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novo Incidente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalhes do Utilizador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(72, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data de Criação";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(82, 118);
            this.txtname.Margin = new System.Windows.Forms.Padding(2);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(136, 23);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtDateCriacao
            // 
            this.txtDateCriacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDateCriacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDateCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCriacao.Location = new System.Drawing.Point(356, 115);
            this.txtDateCriacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateCriacao.Name = "txtDateCriacao";
            this.txtDateCriacao.ReadOnly = true;
            this.txtDateCriacao.Size = new System.Drawing.Size(136, 23);
            this.txtDateCriacao.TabIndex = 10;
            this.txtDateCriacao.TextChanged += new System.EventHandler(this.txtDateCriacao_TextChanged);
            // 
            // lblDetalheInci
            // 
            this.lblDetalheInci.AutoSize = true;
            this.lblDetalheInci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalheInci.Location = new System.Drawing.Point(30, 159);
            this.lblDetalheInci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalheInci.Name = "lblDetalheInci";
            this.lblDetalheInci.Size = new System.Drawing.Size(149, 18);
            this.lblDetalheInci.TabIndex = 11;
            this.lblDetalheInci.Text = "Detalhes do Incidente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prioridade";
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Location = new System.Drawing.Point(110, 195);
            this.cmbPrioridade.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(92, 21);
            this.cmbPrioridade.TabIndex = 13;
            this.cmbPrioridade.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridade_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição do Problema";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(378, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(247, 220);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(345, 110);
            this.txtDescricao.TabIndex = 16;
            // 
            // btnGuardarIncidente
            // 
            this.btnGuardarIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardarIncidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarIncidente.Location = new System.Drawing.Point(514, 335);
            this.btnGuardarIncidente.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarIncidente.Name = "btnGuardarIncidente";
            this.btnGuardarIncidente.Size = new System.Drawing.Size(70, 28);
            this.btnGuardarIncidente.TabIndex = 18;
            this.btnGuardarIncidente.Text = "Inserir";
            this.btnGuardarIncidente.UseVisualStyleBackColor = false;
            this.btnGuardarIncidente.Click += new System.EventHandler(this.btnGuardarIncidente_Click);
            // 
            // btnCancelarIncidente
            // 
            this.btnCancelarIncidente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelarIncidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIncidente.Location = new System.Drawing.Point(425, 335);
            this.btnCancelarIncidente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarIncidente.Name = "btnCancelarIncidente";
            this.btnCancelarIncidente.Size = new System.Drawing.Size(67, 28);
            this.btnCancelarIncidente.TabIndex = 19;
            this.btnCancelarIncidente.Text = "Cancelar";
            this.btnCancelarIncidente.UseVisualStyleBackColor = false;
            this.btnCancelarIncidente.Click += new System.EventHandler(this.btnCancelarIncidente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Projeto_POO_ESI_25444.Properties.Resources.casa;
            this.pictureBox1.Location = new System.Drawing.Point(555, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormCriarIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelarIncidente);
            this.Controls.Add(this.btnGuardarIncidente);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbPrioridade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDetalheInci);
            this.Controls.Add(this.txtDateCriacao);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCriarIncidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCriarIncidente";
            this.Load += new System.EventHandler(this.FormCriarIncidente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarIncidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarIncidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoIncidenteToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtDateCriacao;
        private System.Windows.Forms.Label lblDetalheInci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnGuardarIncidente;
        private System.Windows.Forms.Button btnCancelarIncidente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}