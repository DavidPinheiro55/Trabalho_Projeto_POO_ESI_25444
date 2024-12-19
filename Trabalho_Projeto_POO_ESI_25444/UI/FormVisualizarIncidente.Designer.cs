namespace Trabalho_Projeto_POO_ESI_25444
{
    partial class FormVisualizarIncidente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvIncidentes = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentes)).BeginInit();
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
            this.incidenteToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.incidenteToolStripMenuItem.Text = "Incidentes";
            // 
            // criarIncidenteToolStripMenuItem
            // 
            this.criarIncidenteToolStripMenuItem.Name = "criarIncidenteToolStripMenuItem";
            this.criarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarIncidenteToolStripMenuItem.Text = "Criar Incidentes";
            this.criarIncidenteToolStripMenuItem.Click += new System.EventHandler(this.criarIncidenteToolStripMenuItem_Click);
            // 
            // visualizarIncidenteToolStripMenuItem
            // 
            this.visualizarIncidenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualizarIncidenteToolStripMenuItem.Name = "visualizarIncidenteToolStripMenuItem";
            this.visualizarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarIncidenteToolStripMenuItem.Text = "Visualizar Incidentes";
            // 
            // arquivoIncidenteToolStripMenuItem
            // 
            this.arquivoIncidenteToolStripMenuItem.Name = "arquivoIncidenteToolStripMenuItem";
            this.arquivoIncidenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arquivoIncidenteToolStripMenuItem.Text = "Arquivo ";
            this.arquivoIncidenteToolStripMenuItem.Click += new System.EventHandler(this.arquivoIncidenteToolStripMenuItem_Click);
            // 
            // dgvIncidentes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncidentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIncidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncidentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIncidentes.Location = new System.Drawing.Point(42, 56);
            this.dgvIncidentes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvIncidentes.Name = "dgvIncidentes";
            this.dgvIncidentes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncidentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIncidentes.RowHeadersWidth = 51;
            this.dgvIncidentes.RowTemplate.Height = 24;
            this.dgvIncidentes.Size = new System.Drawing.Size(508, 280);
            this.dgvIncidentes.TabIndex = 1;
            this.dgvIncidentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncidentes_CellContentClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(309, 2);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(57, 20);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trabalho_Projeto_POO_ESI_25444.Properties.Resources.casa;
            this.pictureBox1.Location = new System.Drawing.Point(555, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormVisualizarIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.dgvIncidentes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVisualizarIncidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVisualizarIncidente";
            this.Load += new System.EventHandler(this.FormVisualizarIncidente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvIncidentes;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}