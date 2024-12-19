namespace Trabalho_Projeto_POO_ESI_25444
{
    partial class FormArquivo
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
            this.checklistIncidentes = new System.Windows.Forms.CheckedListBox();
            this.txtresolucao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbldescricaoproblema = new System.Windows.Forms.Label();
            this.txtprioridade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDateCriacao = new System.Windows.Forms.Label();
            this.txtNomeUtilizador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttecnico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownAvaliacao = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvaliacao)).BeginInit();
            this.SuspendLayout();
            // 
            // checklistIncidentes
            // 
            this.checklistIncidentes.FormattingEnabled = true;
            this.checklistIncidentes.Location = new System.Drawing.Point(584, 42);
            this.checklistIncidentes.Margin = new System.Windows.Forms.Padding(2);
            this.checklistIncidentes.Name = "checklistIncidentes";
            this.checklistIncidentes.Size = new System.Drawing.Size(205, 349);
            this.checklistIncidentes.TabIndex = 53;
            this.checklistIncidentes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checklistIncidentes_MouseClick);
            this.checklistIncidentes.SelectedIndexChanged += new System.EventHandler(this.checklistIncidentes_SelectedIndexChanged);
            // 
            // txtresolucao
            // 
            this.txtresolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtresolucao.Location = new System.Drawing.Point(45, 329);
            this.txtresolucao.Margin = new System.Windows.Forms.Padding(2);
            this.txtresolucao.Multiline = true;
            this.txtresolucao.Name = "txtresolucao";
            this.txtresolucao.ReadOnly = true;
            this.txtresolucao.Size = new System.Drawing.Size(312, 46);
            this.txtresolucao.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Resolução do Problema:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(45, 238);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(312, 46);
            this.textBox3.TabIndex = 50;
            // 
            // lbldescricaoproblema
            // 
            this.lbldescricaoproblema.AutoSize = true;
            this.lbldescricaoproblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricaoproblema.Location = new System.Drawing.Point(13, 207);
            this.lbldescricaoproblema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldescricaoproblema.Name = "lbldescricaoproblema";
            this.lbldescricaoproblema.Size = new System.Drawing.Size(139, 17);
            this.lbldescricaoproblema.TabIndex = 49;
            this.lbldescricaoproblema.Text = "Descrição Problema:";
            // 
            // txtprioridade
            // 
            this.txtprioridade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtprioridade.Location = new System.Drawing.Point(447, 134);
            this.txtprioridade.Margin = new System.Windows.Forms.Padding(2);
            this.txtprioridade.Name = "txtprioridade";
            this.txtprioridade.ReadOnly = true;
            this.txtprioridade.Size = new System.Drawing.Size(84, 20);
            this.txtprioridade.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Prioridade:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(400, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 46;
            // 
            // lblDateCriacao
            // 
            this.lblDateCriacao.AutoSize = true;
            this.lblDateCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCriacao.Location = new System.Drawing.Point(268, 92);
            this.lblDateCriacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCriacao.Name = "lblDateCriacao";
            this.lblDateCriacao.Size = new System.Drawing.Size(98, 17);
            this.lblDateCriacao.TabIndex = 45;
            this.lblDateCriacao.Text = "Data Criação: ";
            // 
            // txtNomeUtilizador
            // 
            this.txtNomeUtilizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNomeUtilizador.Location = new System.Drawing.Point(129, 134);
            this.txtNomeUtilizador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeUtilizador.Name = "txtNomeUtilizador";
            this.txtNomeUtilizador.ReadOnly = true;
            this.txtNomeUtilizador.Size = new System.Drawing.Size(100, 20);
            this.txtNomeUtilizador.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome Utilizador:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(14, 91);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 17);
            this.lblid.TabIndex = 42;
            this.lblid.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Detalhes Incidente";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(45, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 40;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 54;
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
            this.criarIncidenteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.criarIncidenteToolStripMenuItem.Name = "criarIncidenteToolStripMenuItem";
            this.criarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.criarIncidenteToolStripMenuItem.Text = "Criar Incidente";
            this.criarIncidenteToolStripMenuItem.Click += new System.EventHandler(this.criarIncidenteToolStripMenuItem_Click);
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
            this.arquivoIncidenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.arquivoIncidenteToolStripMenuItem.Name = "arquivoIncidenteToolStripMenuItem";
            this.arquivoIncidenteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arquivoIncidenteToolStripMenuItem.Text = "Arquivo Incidente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Trabalho_Projeto_POO_ESI_25444.Properties.Resources.casa;
            this.pictureBox2.Location = new System.Drawing.Point(755, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Técnico :";
            // 
            // txttecnico
            // 
            this.txttecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttecnico.Location = new System.Drawing.Point(89, 170);
            this.txttecnico.Margin = new System.Windows.Forms.Padding(2);
            this.txttecnico.Name = "txttecnico";
            this.txttecnico.ReadOnly = true;
            this.txttecnico.Size = new System.Drawing.Size(100, 20);
            this.txttecnico.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Status:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStatus.Location = new System.Drawing.Point(404, 182);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(84, 20);
            this.txtStatus.TabIndex = 59;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(400, 405);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(104, 23);
            this.btnAtualizar.TabIndex = 60;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Avaliação:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // numericUpDownAvaliacao
            // 
            this.numericUpDownAvaliacao.Location = new System.Drawing.Point(472, 311);
            this.numericUpDownAvaliacao.Name = "numericUpDownAvaliacao";
            this.numericUpDownAvaliacao.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownAvaliacao.TabIndex = 65;
            this.numericUpDownAvaliacao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(400, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 23);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numericUpDownAvaliacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttecnico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.checklistIncidentes);
            this.Controls.Add(this.txtresolucao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbldescricaoproblema);
            this.Controls.Add(this.txtprioridade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDateCriacao);
            this.Controls.Add(this.txtNomeUtilizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArquivo";
            this.Load += new System.EventHandler(this.FormArquivo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvaliacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checklistIncidentes;
        private System.Windows.Forms.TextBox txtresolucao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbldescricaoproblema;
        private System.Windows.Forms.TextBox txtprioridade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDateCriacao;
        private System.Windows.Forms.TextBox txtNomeUtilizador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarIncidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarIncidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoIncidenteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttecnico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownAvaliacao;
        private System.Windows.Forms.Button btnGuardar;
    }
}