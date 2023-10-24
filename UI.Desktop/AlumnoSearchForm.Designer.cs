namespace UI.Desktop
{
    partial class AlumnoSearchForm
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
            tlpAlumnos = new System.Windows.Forms.TableLayoutPanel();
            lblLegajo = new System.Windows.Forms.Label();
            btnBuscar = new System.Windows.Forms.Button();
            dgvAlumnos = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnSeleccionar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            tlpAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tlpAlumnos
            // 
            tlpAlumnos.ColumnCount = 4;
            tlpAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            tlpAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            tlpAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.73494F));
            tlpAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.26506F));
            tlpAlumnos.Controls.Add(lblLegajo, 0, 0);
            tlpAlumnos.Controls.Add(btnBuscar, 2, 0);
            tlpAlumnos.Controls.Add(dgvAlumnos, 0, 1);
            tlpAlumnos.Controls.Add(btnSeleccionar, 2, 2);
            tlpAlumnos.Controls.Add(btnCancelar, 3, 2);
            tlpAlumnos.Controls.Add(numericUpDown1, 1, 0);
            tlpAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpAlumnos.Location = new System.Drawing.Point(0, 0);
            tlpAlumnos.Name = "tlpAlumnos";
            tlpAlumnos.RowCount = 3;
            tlpAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpAlumnos.Size = new System.Drawing.Size(1034, 567);
            tlpAlumnos.TabIndex = 0;
            // 
            // lblLegajo
            // 
            lblLegajo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new System.Drawing.Point(3, 11);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new System.Drawing.Size(68, 25);
            lblLegajo.TabIndex = 0;
            lblLegajo.Text = "Legajo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(326, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(199, 42);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar por legajo";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Legajo, Apellido, Nombre, Direccion, Telefono });
            tlpAlumnos.SetColumnSpan(dgvAlumnos, 4);
            dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAlumnos.Location = new System.Drawing.Point(3, 51);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.RowTemplate.Height = 33;
            dgvAlumnos.Size = new System.Drawing.Size(1028, 462);
            dgvAlumnos.TabIndex = 3;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 150;
            // 
            // Legajo
            // 
            Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Legajo.DataPropertyName = "Legajo";
            Legajo.FillWeight = 10F;
            Legajo.HeaderText = "Legajo";
            Legajo.MinimumWidth = 8;
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Apellido.DataPropertyName = "Apellido";
            Apellido.FillWeight = 20F;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 20F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Direccion.DataPropertyName = "Direccion";
            Direccion.FillWeight = 20F;
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            Telefono.DataPropertyName = "Telefono";
            Telefono.FillWeight = 20F;
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 115;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSeleccionar.BackColor = System.Drawing.Color.Green;
            btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSeleccionar.Location = new System.Drawing.Point(804, 519);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(111, 45);
            btnSeleccionar.TabIndex = 4;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(921, 519);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(110, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numericUpDown1.Location = new System.Drawing.Point(86, 8);
            numericUpDown1.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(234, 31);
            numericUpDown1.TabIndex = 6;
            // 
            // AlumnoSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1034, 567);
            Controls.Add(tlpAlumnos);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AlumnoSearchForm";
            Text = "Seleccionar alumno";
            Load += AlumnoSearchForm_Load;
            tlpAlumnos.ResumeLayout(false);
            tlpAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAlumnos;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}