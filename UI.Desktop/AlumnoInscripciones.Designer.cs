namespace UI.Desktop
{
    partial class AlumnoInscripciones
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
            tscInscripciones = new System.Windows.Forms.ToolStripContainer();
            tlpInscripciones = new System.Windows.Forms.TableLayoutPanel();
            lblLegajo = new System.Windows.Forms.Label();
            nudLegajo = new System.Windows.Forms.NumericUpDown();
            btnBuscar = new System.Windows.Forms.Button();
            dgvAlumnos = new System.Windows.Forms.DataGridView();
            btnActualizar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            tscInscripciones.ContentPanel.SuspendLayout();
            tscInscripciones.TopToolStripPanel.SuspendLayout();
            tscInscripciones.SuspendLayout();
            tlpInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLegajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tscInscripciones
            // 
            // 
            // tscInscripciones.ContentPanel
            // 
            tscInscripciones.ContentPanel.Controls.Add(tlpInscripciones);
            tscInscripciones.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tscInscripciones.ContentPanel.Size = new System.Drawing.Size(1143, 747);
            tscInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            tscInscripciones.Location = new System.Drawing.Point(0, 0);
            tscInscripciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tscInscripciones.Name = "tscInscripciones";
            tscInscripciones.Size = new System.Drawing.Size(1143, 777);
            tscInscripciones.TabIndex = 0;
            tscInscripciones.Text = "toolStripContainer1";
            // 
            // tscInscripciones.TopToolStripPanel
            // 
            tscInscripciones.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlpInscripciones
            // 
            tlpInscripciones.ColumnCount = 5;
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpInscripciones.Controls.Add(lblLegajo, 0, 0);
            tlpInscripciones.Controls.Add(nudLegajo, 1, 0);
            tlpInscripciones.Controls.Add(btnBuscar, 2, 0);
            tlpInscripciones.Controls.Add(dgvAlumnos, 0, 1);
            tlpInscripciones.Controls.Add(btnActualizar, 3, 2);
            tlpInscripciones.Controls.Add(btnCancelar, 4, 2);
            tlpInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpInscripciones.Location = new System.Drawing.Point(0, 0);
            tlpInscripciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tlpInscripciones.Name = "tlpInscripciones";
            tlpInscripciones.RowCount = 3;
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpInscripciones.Size = new System.Drawing.Size(1143, 747);
            tlpInscripciones.TabIndex = 0;
            // 
            // lblLegajo
            // 
            lblLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new System.Drawing.Point(4, 21);
            lblLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new System.Drawing.Size(64, 25);
            lblLegajo.TabIndex = 0;
            lblLegajo.Text = "Legajo";
            // 
            // nudLegajo
            // 
            nudLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nudLegajo.Location = new System.Drawing.Point(76, 18);
            nudLegajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudLegajo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudLegajo.Name = "nudLegajo";
            nudLegajo.Size = new System.Drawing.Size(279, 31);
            nudLegajo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(363, 5);
            btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(197, 57);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar por legajo";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpInscripciones.SetColumnSpan(dgvAlumnos, 5);
            dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAlumnos.Location = new System.Drawing.Point(4, 72);
            dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new System.Drawing.Size(1135, 603);
            dgvAlumnos.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(808, 685);
            btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(160, 55);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(976, 685);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(163, 57);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new System.Drawing.Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(169, 30);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(151, 25);
            toolStripLabel1.Text = "Nueva inscripción";
            // 
            // AlumnoInscripciones
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 777);
            Controls.Add(tscInscripciones);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "AlumnoInscripciones";
            Text = "AlumnoInscripciones";
            Load += AlumnoInscripciones_Load;
            tscInscripciones.ContentPanel.ResumeLayout(false);
            tscInscripciones.TopToolStripPanel.ResumeLayout(false);
            tscInscripciones.TopToolStripPanel.PerformLayout();
            tscInscripciones.ResumeLayout(false);
            tscInscripciones.PerformLayout();
            tlpInscripciones.ResumeLayout(false);
            tlpInscripciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLegajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscInscripciones;
        private System.Windows.Forms.TableLayoutPanel tlpInscripciones;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.NumericUpDown nudLegajo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}