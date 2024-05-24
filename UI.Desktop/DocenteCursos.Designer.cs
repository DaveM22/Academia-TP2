namespace UI.Desktop
{
    partial class DocenteCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteCursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            tscDocenteCursos = new System.Windows.Forms.ToolStripContainer();
            tlpDocenteCursos = new System.Windows.Forms.TableLayoutPanel();
            dgvDocenteCursos = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsNuevo = new System.Windows.Forms.ToolStripButton();
            Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comisión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LegajoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ApellidoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            tscDocenteCursos.ContentPanel.SuspendLayout();
            tscDocenteCursos.TopToolStripPanel.SuspendLayout();
            tscDocenteCursos.SuspendLayout();
            tlpDocenteCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocenteCursos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tscDocenteCursos
            // 
            // 
            // tscDocenteCursos.ContentPanel
            // 
            tscDocenteCursos.ContentPanel.Controls.Add(tlpDocenteCursos);
            tscDocenteCursos.ContentPanel.Size = new System.Drawing.Size(800, 425);
            tscDocenteCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            tscDocenteCursos.Location = new System.Drawing.Point(0, 0);
            tscDocenteCursos.Name = "tscDocenteCursos";
            tscDocenteCursos.Size = new System.Drawing.Size(800, 450);
            tscDocenteCursos.TabIndex = 0;
            tscDocenteCursos.Text = "toolStripContainer1";
            // 
            // tscDocenteCursos.TopToolStripPanel
            // 
            tscDocenteCursos.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlpDocenteCursos
            // 
            tlpDocenteCursos.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpDocenteCursos.ColumnCount = 2;
            tlpDocenteCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpDocenteCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpDocenteCursos.Controls.Add(dgvDocenteCursos, 0, 0);
            tlpDocenteCursos.Controls.Add(button1, 0, 1);
            tlpDocenteCursos.Controls.Add(btnSalir, 1, 1);
            tlpDocenteCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpDocenteCursos.Location = new System.Drawing.Point(0, 0);
            tlpDocenteCursos.Name = "tlpDocenteCursos";
            tlpDocenteCursos.RowCount = 2;
            tlpDocenteCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpDocenteCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDocenteCursos.Size = new System.Drawing.Size(800, 425);
            tlpDocenteCursos.TabIndex = 0;
            // 
            // dgvDocenteCursos
            // 
            dgvDocenteCursos.AllowUserToAddRows = false;
            dgvDocenteCursos.AllowUserToDeleteRows = false;
            dgvDocenteCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocenteCursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvDocenteCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocenteCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Comision, Column3, LegajoDocente, ApellidoDocente, NombreDocente, dataGridViewTextBoxColumn1, Borrar });
            tlpDocenteCursos.SetColumnSpan(dgvDocenteCursos, 2);
            dgvDocenteCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocenteCursos.Location = new System.Drawing.Point(3, 3);
            dgvDocenteCursos.MultiSelect = false;
            dgvDocenteCursos.Name = "dgvDocenteCursos";
            dgvDocenteCursos.ReadOnly = true;
            dgvDocenteCursos.RowHeadersWidth = 62;
            dgvDocenteCursos.RowTemplate.Height = 25;
            dgvDocenteCursos.Size = new System.Drawing.Size(794, 380);
            dgvDocenteCursos.TabIndex = 0;
            dgvDocenteCursos.CellContentClick += dgvDocenteCursos_CellContentClick;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            button1.Location = new System.Drawing.Point(596, 389);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(82, 33);
            button1.TabIndex = 1;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSalir.BackColor = System.Drawing.Color.Firebrick;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSalir.Location = new System.Drawing.Point(684, 389);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(113, 33);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Volver al inicio";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevo });
            toolStrip1.Location = new System.Drawing.Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(117, 25);
            toolStrip1.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevo.Image = (System.Drawing.Image)resources.GetObject("tsNuevo.Image");
            tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new System.Drawing.Size(105, 22);
            tsNuevo.Text = "Nueva asignación";
            tsNuevo.Click += tsNuevo_Click;
            // 
            // Curso
            // 
            Curso.DataPropertyName = "CursoNombre";
            Curso.HeaderText = "Comision";
            Curso.MinimumWidth = 8;
            Curso.Name = "Curso";
            Curso.Width = 250;
            // 
            // Docente
            // 
            Docente.DataPropertyName = "DocenteNombre";
            Docente.HeaderText = "Materia";
            Docente.MinimumWidth = 8;
            Docente.Name = "Docente";
            Docente.Width = 251;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "DocenteCargoDescripcion";
            Cargo.HeaderText = "Legajo docente";
            Cargo.MinimumWidth = 8;
            Cargo.Name = "Cargo";
            Cargo.Width = 250;
            // 
            // Comisión
            // 
            Comisión.DataPropertyName = "ComisionDescripcion";
            Comisión.HeaderText = "Comision";
            Comisión.MinimumWidth = 8;
            Comisión.Name = "Comisión";
            Comisión.ReadOnly = true;
            Comisión.Width = 376;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "MateriaDescripcion";
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 8;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            Materia.Width = 375;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "ComisionDescripcion";
            Comision.HeaderText = "Comisión";
            Comision.MinimumWidth = 8;
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MateriaDescripcion";
            Column3.HeaderText = "Materia";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // LegajoDocente
            // 
            LegajoDocente.DataPropertyName = "DocenteLegajo";
            LegajoDocente.HeaderText = "Legajo Docente";
            LegajoDocente.MinimumWidth = 8;
            LegajoDocente.Name = "LegajoDocente";
            LegajoDocente.ReadOnly = true;
            // 
            // ApellidoDocente
            // 
            ApellidoDocente.DataPropertyName = "DocenteApellido";
            ApellidoDocente.HeaderText = "Apellido Docente";
            ApellidoDocente.MinimumWidth = 8;
            ApellidoDocente.Name = "ApellidoDocente";
            ApellidoDocente.ReadOnly = true;
            // 
            // NombreDocente
            // 
            NombreDocente.DataPropertyName = "DocenteNombre";
            NombreDocente.HeaderText = "Nombre Docente";
            NombreDocente.MinimumWidth = 8;
            NombreDocente.Name = "NombreDocente";
            NombreDocente.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "DocenteCargo";
            dataGridViewTextBoxColumn1.HeaderText = "Cargo del docente";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Borrar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Eliminar";
            Borrar.DefaultCellStyle = dataGridViewCellStyle1;
            Borrar.HeaderText = "";
            Borrar.MinimumWidth = 8;
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DocenteCursos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tscDocenteCursos);
            Name = "DocenteCursos";
            Text = "DocenteCursos";
            Load += DocenteCursos_Load;
            tscDocenteCursos.ContentPanel.ResumeLayout(false);
            tscDocenteCursos.TopToolStripPanel.ResumeLayout(false);
            tscDocenteCursos.TopToolStripPanel.PerformLayout();
            tscDocenteCursos.ResumeLayout(false);
            tscDocenteCursos.PerformLayout();
            tlpDocenteCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocenteCursos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscDocenteCursos;
        private System.Windows.Forms.TableLayoutPanel tlpDocenteCursos;
        private System.Windows.Forms.DataGridView dgvDocenteCursos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comisión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}