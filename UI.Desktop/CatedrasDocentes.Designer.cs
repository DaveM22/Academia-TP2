namespace UI.Desktop
{
    partial class CatedrasDocentes
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
            tscCatedrasDocentes = new System.Windows.Forms.ToolStripContainer();
            tlpCursosDocentes = new System.Windows.Forms.TableLayoutPanel();
            lblEspecialidades = new System.Windows.Forms.Label();
            cbEspecialidades = new System.Windows.Forms.ComboBox();
            lblPlanes = new System.Windows.Forms.Label();
            cbPlanes = new System.Windows.Forms.ComboBox();
            lblComision = new System.Windows.Forms.Label();
            cbComisiones = new System.Windows.Forms.ComboBox();
            dgvCursosDocentes = new System.Windows.Forms.DataGridView();
            btnVolver = new System.Windows.Forms.Button();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Profesores = new System.Windows.Forms.DataGridViewButtonColumn();
            tscCatedrasDocentes.ContentPanel.SuspendLayout();
            tscCatedrasDocentes.SuspendLayout();
            tlpCursosDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursosDocentes).BeginInit();
            SuspendLayout();
            // 
            // tscCatedrasDocentes
            // 
            // 
            // tscCatedrasDocentes.ContentPanel
            // 
            tscCatedrasDocentes.ContentPanel.Controls.Add(tlpCursosDocentes);
            tscCatedrasDocentes.ContentPanel.Size = new System.Drawing.Size(1281, 425);
            tscCatedrasDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            tscCatedrasDocentes.Location = new System.Drawing.Point(0, 0);
            tscCatedrasDocentes.Name = "tscCatedrasDocentes";
            tscCatedrasDocentes.Size = new System.Drawing.Size(1281, 450);
            tscCatedrasDocentes.TabIndex = 0;
            tscCatedrasDocentes.Text = "toolStripContainer1";
            // 
            // tlpCursosDocentes
            // 
            tlpCursosDocentes.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpCursosDocentes.ColumnCount = 8;
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCursosDocentes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpCursosDocentes.Controls.Add(lblEspecialidades, 0, 0);
            tlpCursosDocentes.Controls.Add(cbEspecialidades, 1, 0);
            tlpCursosDocentes.Controls.Add(lblPlanes, 2, 0);
            tlpCursosDocentes.Controls.Add(cbPlanes, 3, 0);
            tlpCursosDocentes.Controls.Add(lblComision, 4, 0);
            tlpCursosDocentes.Controls.Add(cbComisiones, 5, 0);
            tlpCursosDocentes.Controls.Add(dgvCursosDocentes, 0, 1);
            tlpCursosDocentes.Controls.Add(btnVolver, 7, 2);
            tlpCursosDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpCursosDocentes.Location = new System.Drawing.Point(0, 0);
            tlpCursosDocentes.Name = "tlpCursosDocentes";
            tlpCursosDocentes.RowCount = 3;
            tlpCursosDocentes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            tlpCursosDocentes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCursosDocentes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpCursosDocentes.Size = new System.Drawing.Size(1281, 425);
            tlpCursosDocentes.TabIndex = 0;
            // 
            // lblEspecialidades
            // 
            lblEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEspecialidades.AutoSize = true;
            lblEspecialidades.Location = new System.Drawing.Point(3, 11);
            lblEspecialidades.Name = "lblEspecialidades";
            lblEspecialidades.Size = new System.Drawing.Size(89, 15);
            lblEspecialidades.TabIndex = 0;
            lblEspecialidades.Text = "Especialidades";
            // 
            // cbEspecialidades
            // 
            cbEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbEspecialidades.FormattingEnabled = true;
            cbEspecialidades.Location = new System.Drawing.Point(98, 7);
            cbEspecialidades.Name = "cbEspecialidades";
            cbEspecialidades.Size = new System.Drawing.Size(270, 23);
            cbEspecialidades.TabIndex = 1;
            cbEspecialidades.Text = "Seleccione una especialidad";
            cbEspecialidades.SelectionChangeCommitted += cbEspecialidades_SelectionChangeCommitted;
            cbEspecialidades.SelectedValueChanged += cbEspecialidades_SelectedValueChanged;
            // 
            // lblPlanes
            // 
            lblPlanes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPlanes.AutoSize = true;
            lblPlanes.Location = new System.Drawing.Point(374, 11);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new System.Drawing.Size(66, 15);
            lblPlanes.TabIndex = 2;
            lblPlanes.Text = "Planes";
            // 
            // cbPlanes
            // 
            cbPlanes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbPlanes.FormattingEnabled = true;
            cbPlanes.Location = new System.Drawing.Point(446, 7);
            cbPlanes.Name = "cbPlanes";
            cbPlanes.Size = new System.Drawing.Size(251, 23);
            cbPlanes.TabIndex = 3;
            cbPlanes.Text = "Seleccione un plan";
            cbPlanes.SelectionChangeCommitted += cbPlanes_SelectionChangeCommitted;
            // 
            // lblComision
            // 
            lblComision.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(703, 11);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(75, 15);
            lblComision.TabIndex = 4;
            lblComision.Text = "Comisiones";
            // 
            // cbComisiones
            // 
            cbComisiones.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbComisiones.FormattingEnabled = true;
            cbComisiones.Location = new System.Drawing.Point(784, 7);
            cbComisiones.Name = "cbComisiones";
            cbComisiones.Size = new System.Drawing.Size(271, 23);
            cbComisiones.TabIndex = 5;
            cbComisiones.Text = "Seleccione comisión";
            cbComisiones.SelectionChangeCommitted += cbComisiones_SelectionChangeCommitted;
            // 
            // dgvCursosDocentes
            // 
            dgvCursosDocentes.AllowUserToAddRows = false;
            dgvCursosDocentes.AllowUserToDeleteRows = false;
            dgvCursosDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursosDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursosDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, AnioCalendario, Materia, Profesores });
            tlpCursosDocentes.SetColumnSpan(dgvCursosDocentes, 8);
            dgvCursosDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCursosDocentes.Location = new System.Drawing.Point(3, 40);
            dgvCursosDocentes.Name = "dgvCursosDocentes";
            dgvCursosDocentes.ReadOnly = true;
            dgvCursosDocentes.RowTemplate.Height = 25;
            dgvCursosDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCursosDocentes.Size = new System.Drawing.Size(1275, 339);
            dgvCursosDocentes.TabIndex = 8;
            dgvCursosDocentes.CellClick += dgvCursosDocentes_CellClick;
            dgvCursosDocentes.Paint += dgvCursosDocentes_Paint;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.Firebrick;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnVolver.Location = new System.Drawing.Point(1169, 385);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(109, 37);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver al inicio";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 5F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // AnioCalendario
            // 
            AnioCalendario.DataPropertyName = "AnioCalendario";
            AnioCalendario.FillWeight = 10F;
            AnioCalendario.HeaderText = "Año calendario";
            AnioCalendario.Name = "AnioCalendario";
            AnioCalendario.ReadOnly = true;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "Materia.Descripcion";
            Materia.FillWeight = 80F;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Profesores
            // 
            Profesores.FillWeight = 8F;
            Profesores.HeaderText = "";
            Profesores.Name = "Profesores";
            Profesores.ReadOnly = true;
            Profesores.Text = "Profesores";
            Profesores.UseColumnTextForButtonValue = true;
            // 
            // CatedrasDocentes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1281, 450);
            Controls.Add(tscCatedrasDocentes);
            Name = "CatedrasDocentes";
            Text = "CatedrasDocentes";
            tscCatedrasDocentes.ContentPanel.ResumeLayout(false);
            tscCatedrasDocentes.ResumeLayout(false);
            tscCatedrasDocentes.PerformLayout();
            tlpCursosDocentes.ResumeLayout(false);
            tlpCursosDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursosDocentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscCatedrasDocentes;
        private System.Windows.Forms.TableLayoutPanel tlpCursosDocentes;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.ComboBox cbPlanes;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.ComboBox cbComisiones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvCursosDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewButtonColumn Profesores;
    }
}