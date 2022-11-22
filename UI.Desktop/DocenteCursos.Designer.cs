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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteCursos));
            this.tscDocenteCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlpDocenteCursos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocenteCursos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comisión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscDocenteCursos.ContentPanel.SuspendLayout();
            this.tscDocenteCursos.TopToolStripPanel.SuspendLayout();
            this.tscDocenteCursos.SuspendLayout();
            this.tlpDocenteCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCursos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscDocenteCursos
            // 
            // 
            // tscDocenteCursos.ContentPanel
            // 
            this.tscDocenteCursos.ContentPanel.Controls.Add(this.tlpDocenteCursos);
            this.tscDocenteCursos.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tscDocenteCursos.ContentPanel.Size = new System.Drawing.Size(1143, 717);
            this.tscDocenteCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscDocenteCursos.Location = new System.Drawing.Point(0, 0);
            this.tscDocenteCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tscDocenteCursos.Name = "tscDocenteCursos";
            this.tscDocenteCursos.Size = new System.Drawing.Size(1143, 750);
            this.tscDocenteCursos.TabIndex = 0;
            this.tscDocenteCursos.Text = "toolStripContainer1";
            // 
            // tscDocenteCursos.TopToolStripPanel
            // 
            this.tscDocenteCursos.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tlpDocenteCursos
            // 
            this.tlpDocenteCursos.ColumnCount = 2;
            this.tlpDocenteCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDocenteCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDocenteCursos.Controls.Add(this.dgvDocenteCursos, 0, 0);
            this.tlpDocenteCursos.Controls.Add(this.button1, 0, 1);
            this.tlpDocenteCursos.Controls.Add(this.button2, 1, 1);
            this.tlpDocenteCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocenteCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpDocenteCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpDocenteCursos.Name = "tlpDocenteCursos";
            this.tlpDocenteCursos.RowCount = 2;
            this.tlpDocenteCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDocenteCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDocenteCursos.Size = new System.Drawing.Size(1143, 717);
            this.tlpDocenteCursos.TabIndex = 0;
            // 
            // dgvDocenteCursos
            // 
            this.dgvDocenteCursos.AllowUserToAddRows = false;
            this.dgvDocenteCursos.AllowUserToDeleteRows = false;
            this.dgvDocenteCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocenteCursos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDocenteCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocenteCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Comision,
            this.Column3,
            this.LegajoDocente,
            this.ApellidoDocente,
            this.NombreDocente,
            this.dataGridViewTextBoxColumn1,
            this.Editar,
            this.Borrar});
            this.tlpDocenteCursos.SetColumnSpan(this.dgvDocenteCursos, 2);
            this.dgvDocenteCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocenteCursos.Location = new System.Drawing.Point(4, 5);
            this.dgvDocenteCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDocenteCursos.MultiSelect = false;
            this.dgvDocenteCursos.Name = "dgvDocenteCursos";
            this.dgvDocenteCursos.ReadOnly = true;
            this.dgvDocenteCursos.RowHeadersWidth = 62;
            this.dgvDocenteCursos.RowTemplate.Height = 25;
            this.dgvDocenteCursos.Size = new System.Drawing.Size(1135, 642);
            this.dgvDocenteCursos.TabIndex = 0;
            this.dgvDocenteCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocenteCursos_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "ComisionDescripcion";
            this.Comision.HeaderText = "Comisión";
            this.Comision.MinimumWidth = 8;
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MateriaDescripcion";
            this.Column3.HeaderText = "Materia";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // LegajoDocente
            // 
            this.LegajoDocente.DataPropertyName = "DocenteLegajo";
            this.LegajoDocente.HeaderText = "Legajo Docente";
            this.LegajoDocente.MinimumWidth = 8;
            this.LegajoDocente.Name = "LegajoDocente";
            this.LegajoDocente.ReadOnly = true;
            // 
            // ApellidoDocente
            // 
            this.ApellidoDocente.DataPropertyName = "DocenteApellido";
            this.ApellidoDocente.HeaderText = "Apellido Docente";
            this.ApellidoDocente.MinimumWidth = 8;
            this.ApellidoDocente.Name = "ApellidoDocente";
            this.ApellidoDocente.ReadOnly = true;
            // 
            // NombreDocente
            // 
            this.NombreDocente.DataPropertyName = "DocenteNombre";
            this.NombreDocente.HeaderText = "Nombre Docente";
            this.NombreDocente.MinimumWidth = 8;
            this.NombreDocente.Name = "NombreDocente";
            this.NombreDocente.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DocenteCargo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cargo del docente";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Editar";
            this.Editar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Borrar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Eliminar";
            this.Borrar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Borrar.HeaderText = "";
            this.Borrar.MinimumWidth = 8;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(894, 657);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1019, 657);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(52, 33);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsNuevo
            // 
            this.tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(34, 28);
            this.tsNuevo.Text = "toolStripButton1";
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // Curso
            // 
            this.Curso.DataPropertyName = "CursoNombre";
            this.Curso.HeaderText = "Comision";
            this.Curso.MinimumWidth = 8;
            this.Curso.Name = "Curso";
            this.Curso.Width = 250;
            // 
            // Docente
            // 
            this.Docente.DataPropertyName = "DocenteNombre";
            this.Docente.HeaderText = "Materia";
            this.Docente.MinimumWidth = 8;
            this.Docente.Name = "Docente";
            this.Docente.Width = 251;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "DocenteCargoDescripcion";
            this.Cargo.HeaderText = "Legajo docente";
            this.Cargo.MinimumWidth = 8;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 250;
            // 
            // Comisión
            // 
            this.Comisión.DataPropertyName = "ComisionDescripcion";
            this.Comisión.HeaderText = "Comision";
            this.Comisión.MinimumWidth = 8;
            this.Comisión.Name = "Comisión";
            this.Comisión.ReadOnly = true;
            this.Comisión.Width = 376;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "MateriaDescripcion";
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 8;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 375;
            // 
            // DocenteCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.tscDocenteCursos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DocenteCursos";
            this.Text = "DocenteCursos";
            this.Load += new System.EventHandler(this.DocenteCursos_Load);
            this.tscDocenteCursos.ContentPanel.ResumeLayout(false);
            this.tscDocenteCursos.TopToolStripPanel.ResumeLayout(false);
            this.tscDocenteCursos.TopToolStripPanel.PerformLayout();
            this.tscDocenteCursos.ResumeLayout(false);
            this.tscDocenteCursos.PerformLayout();
            this.tlpDocenteCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCursos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscDocenteCursos;
        private System.Windows.Forms.TableLayoutPanel tlpDocenteCursos;
        private System.Windows.Forms.DataGridView dgvDocenteCursos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}