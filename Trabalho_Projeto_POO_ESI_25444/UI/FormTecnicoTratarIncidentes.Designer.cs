namespace Trabalho_Projeto_POO_ESI_25444
{
    partial class FormTecnicoTratarIncidentes
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
            this.inserirIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeUtilizador = new System.Windows.Forms.TextBox();
            this.lblDateCriacao = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprioridade = new System.Windows.Forms.TextBox();
            this.lbldescricaoproblema = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresolucao = new System.Windows.Forms.TextBox();
            this.btntratado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.checklistIncidentes = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidenteToolStripMenuItem,
            this.hOMEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incidenteToolStripMenuItem
            // 
            this.incidenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirIncidenteToolStripMenuItem,
            this.tratarIncidenteToolStripMenuItem});
            this.incidenteToolStripMenuItem.Name = "incidenteToolStripMenuItem";
            this.incidenteToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.incidenteToolStripMenuItem.Text = "Incidentes";
            // 
            // inserirIncidenteToolStripMenuItem
            // 
            this.inserirIncidenteToolStripMenuItem.Name = "inserirIncidenteToolStripMenuItem";
            this.inserirIncidenteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.inserirIncidenteToolStripMenuItem.Text = "Inserir Incidentes";
            this.inserirIncidenteToolStripMenuItem.Click += new System.EventHandler(this.inserirIncidenteToolStripMenuItem_Click);
            // 
            // tratarIncidenteToolStripMenuItem
            // 
            this.tratarIncidenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tratarIncidenteToolStripMenuItem.Name = "tratarIncidenteToolStripMenuItem";
            this.tratarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.tratarIncidenteToolStripMenuItem.Text = "Tratar Incidentes";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Projeto_POO_ESI_25444.Properties.Resources.power_off;
            this.pictureBox1.Location = new System.Drawing.Point(562, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(41, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Detalhes Incidente";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(10, 80);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 17);
            this.lblid.TabIndex = 23;
            this.lblid.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome Utilizador:";
            // 
            // txtNomeUtilizador
            // 
            this.txtNomeUtilizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNomeUtilizador.Location = new System.Drawing.Point(114, 121);
            this.txtNomeUtilizador.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeUtilizador.Name = "txtNomeUtilizador";
            this.txtNomeUtilizador.ReadOnly = true;
            this.txtNomeUtilizador.Size = new System.Drawing.Size(100, 20);
            this.txtNomeUtilizador.TabIndex = 25;
            // 
            // lblDateCriacao
            // 
            this.lblDateCriacao.AutoSize = true;
            this.lblDateCriacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCriacao.Location = new System.Drawing.Point(120, 78);
            this.lblDateCriacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCriacao.Name = "lblDateCriacao";
            this.lblDateCriacao.Size = new System.Drawing.Size(98, 17);
            this.lblDateCriacao.TabIndex = 26;
            this.lblDateCriacao.Text = "Data Criação: ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(213, 78);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Prioridade:";
            // 
            // txtprioridade
            // 
            this.txtprioridade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtprioridade.Location = new System.Drawing.Point(304, 123);
            this.txtprioridade.Margin = new System.Windows.Forms.Padding(2);
            this.txtprioridade.Name = "txtprioridade";
            this.txtprioridade.ReadOnly = true;
            this.txtprioridade.Size = new System.Drawing.Size(84, 20);
            this.txtprioridade.TabIndex = 29;
            // 
            // lbldescricaoproblema
            // 
            this.lbldescricaoproblema.AutoSize = true;
            this.lbldescricaoproblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricaoproblema.Location = new System.Drawing.Point(9, 158);
            this.lbldescricaoproblema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldescricaoproblema.Name = "lbldescricaoproblema";
            this.lbldescricaoproblema.Size = new System.Drawing.Size(139, 17);
            this.lbldescricaoproblema.TabIndex = 30;
            this.lbldescricaoproblema.Text = "Descrição Problema:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Location = new System.Drawing.Point(41, 189);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(312, 46);
            this.textBox3.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Resolução do Problema:";
            // 
            // txtresolucao
            // 
            this.txtresolucao.BackColor = System.Drawing.Color.White;
            this.txtresolucao.Location = new System.Drawing.Point(41, 281);
            this.txtresolucao.Margin = new System.Windows.Forms.Padding(2);
            this.txtresolucao.Multiline = true;
            this.txtresolucao.Name = "txtresolucao";
            this.txtresolucao.Size = new System.Drawing.Size(312, 46);
            this.txtresolucao.TabIndex = 33;
            // 
            // btntratado
            // 
            this.btntratado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btntratado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntratado.Location = new System.Drawing.Point(453, 251);
            this.btntratado.Margin = new System.Windows.Forms.Padding(2);
            this.btntratado.Name = "btntratado";
            this.btntratado.Size = new System.Drawing.Size(89, 25);
            this.btntratado.TabIndex = 35;
            this.btntratado.Text = "Tratado";
            this.btntratado.UseVisualStyleBackColor = false;
            this.btntratado.Click += new System.EventHandler(this.btntratado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(453, 301);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 25);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // checklistIncidentes
            // 
            this.checklistIncidentes.FormattingEnabled = true;
            this.checklistIncidentes.Location = new System.Drawing.Point(391, 57);
            this.checklistIncidentes.Margin = new System.Windows.Forms.Padding(2);
            this.checklistIncidentes.Name = "checklistIncidentes";
            this.checklistIncidentes.Size = new System.Drawing.Size(210, 139);
            this.checklistIncidentes.TabIndex = 37;
            this.checklistIncidentes.SelectedIndexChanged += new System.EventHandler(this.checklistIncidentes_SelectedIndexChanged);
            // 
            // FormTecnicoTratarIncidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 392);
            this.Controls.Add(this.checklistIncidentes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btntratado);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTecnicoTratarIncidentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTecnicoTratarIncidentes";
            this.Load += new System.EventHandler(this.FormTecnicoTratarIncidentes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirIncidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratarIncidenteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeUtilizador;
        private System.Windows.Forms.Label lblDateCriacao;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprioridade;
        private System.Windows.Forms.Label lbldescricaoproblema;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtresolucao;
        private System.Windows.Forms.Button btntratado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckedListBox checklistIncidentes;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
    }
}