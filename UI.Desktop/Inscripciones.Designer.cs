namespace UI.Desktop
{
    partial class Inscripciones
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
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cursos = new System.Windows.Forms.DataGridViewButtonColumn();
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
            tscInscripciones.ContentPanel.Size = new System.Drawing.Size(800, 441);
            tscInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            tscInscripciones.Location = new System.Drawing.Point(0, 0);
            tscInscripciones.Name = "tscInscripciones";
            tscInscripciones.Size = new System.Drawing.Size(800, 466);
            tscInscripciones.TabIndex = 0;
            tscInscripciones.Text = "toolStripContainer1";
            // 
            // tscInscripciones.TopToolStripPanel
            // 
            tscInscripciones.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlpInscripciones
            // 
            tlpInscripciones.BackColor = System.Drawing.Color.CornflowerBlue;
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
            tlpInscripciones.Name = "tlpInscripciones";
            tlpInscripciones.RowCount = 3;
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpInscripciones.Size = new System.Drawing.Size(800, 441);
            tlpInscripciones.TabIndex = 0;
            // 
            // lblLegajo
            // 
            lblLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new System.Drawing.Point(3, 12);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new System.Drawing.Size(42, 15);
            lblLegajo.TabIndex = 0;
            lblLegajo.Text = "Legajo";
            // 
            // nudLegajo
            // 
            nudLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            nudLegajo.Location = new System.Drawing.Point(51, 8);
            nudLegajo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudLegajo.Name = "nudLegajo";
            nudLegajo.Size = new System.Drawing.Size(195, 23);
            nudLegajo.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(252, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(138, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar por legajo";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Legajo, Apellido, Nombre, Cursos });
            tlpInscripciones.SetColumnSpan(dgvAlumnos, 5);
            dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAlumnos.Location = new System.Drawing.Point(3, 43);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new System.Drawing.Size(794, 355);
            dgvAlumnos.TabIndex = 3;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            // 
            // Id
            // 
            Id.FillWeight = 5F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Legajo
            // 
            Legajo.DataPropertyName = "Legajo";
            Legajo.FillWeight = 30F;
            Legajo.HeaderText = "Legajo";
            Legajo.MinimumWidth = 8;
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.FillWeight = 30F;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 30F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cursos
            // 
            Cursos.FillWeight = 10F;
            Cursos.HeaderText = "";
            Cursos.MinimumWidth = 8;
            Cursos.Name = "Cursos";
            Cursos.ReadOnly = true;
            Cursos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Cursos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Cursos.Text = "Inscripciones";
            Cursos.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(565, 404);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(112, 33);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(683, 404);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(114, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Volver al inicio";
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
            toolStrip1.Size = new System.Drawing.Size(114, 25);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            toolStripLabel1.Text = "Nueva inscripción";
            // 
            // Inscripciones
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 466);
            Controls.Add(tscInscripciones);
            Name = "Inscripciones";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Cursos;
    }
}