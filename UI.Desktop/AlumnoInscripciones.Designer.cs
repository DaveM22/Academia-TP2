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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoInscripciones));
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            tlpInscripciones = new System.Windows.Forms.TableLayoutPanel();
            btnActualizar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            dgvAlumnoInscripciones = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            lblAlumno = new System.Windows.Forms.Label();
            lblInscripcion = new System.Windows.Forms.Label();
            lblPlanDescripcion = new System.Windows.Forms.Label();
            lblPlan = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsNuevaAsignacion = new System.Windows.Forms.ToolStripButton();
            tsCargaMasiva = new System.Windows.Forms.ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tlpInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnoInscripciones).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tlpInscripciones);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(797, 431);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(797, 456);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlpInscripciones
            // 
            tlpInscripciones.ColumnCount = 3;
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpInscripciones.Controls.Add(btnActualizar, 1, 3);
            tlpInscripciones.Controls.Add(btnCancelar, 2, 3);
            tlpInscripciones.Controls.Add(dgvAlumnoInscripciones, 0, 2);
            tlpInscripciones.Controls.Add(lblAlumno, 1, 0);
            tlpInscripciones.Controls.Add(lblInscripcion, 0, 0);
            tlpInscripciones.Controls.Add(lblPlanDescripcion, 0, 1);
            tlpInscripciones.Controls.Add(lblPlan, 1, 1);
            tlpInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpInscripciones.Location = new System.Drawing.Point(0, 0);
            tlpInscripciones.Name = "tlpInscripciones";
            tlpInscripciones.RowCount = 4;
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpInscripciones.Size = new System.Drawing.Size(797, 431);
            tlpInscripciones.TabIndex = 0;
            tlpInscripciones.Paint += tlpInscripciones_Paint;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(552, 396);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(99, 32);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(657, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(137, 32);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Volver a alumnos";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvAlumnoInscripciones
            // 
            dgvAlumnoInscripciones.AllowUserToAddRows = false;
            dgvAlumnoInscripciones.AllowUserToDeleteRows = false;
            dgvAlumnoInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnoInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnoInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Materia, Comision, Condicion, Nota, Editar, Borrar });
            tlpInscripciones.SetColumnSpan(dgvAlumnoInscripciones, 3);
            dgvAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAlumnoInscripciones.Location = new System.Drawing.Point(3, 76);
            dgvAlumnoInscripciones.MultiSelect = false;
            dgvAlumnoInscripciones.Name = "dgvAlumnoInscripciones";
            dgvAlumnoInscripciones.ReadOnly = true;
            dgvAlumnoInscripciones.RowTemplate.Height = 25;
            dgvAlumnoInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnoInscripciones.Size = new System.Drawing.Size(791, 314);
            dgvAlumnoInscripciones.TabIndex = 0;
            dgvAlumnoInscripciones.CellContentClick += dgvAlumnoInscripciones_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 10F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "Curso.Materia.Descripcion";
            Materia.FillWeight = 30F;
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 8;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "Curso.Comision.Descripcion";
            Comision.FillWeight = 30F;
            Comision.HeaderText = "Comisión";
            Comision.MinimumWidth = 8;
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.DataPropertyName = "Condicion";
            Condicion.FillWeight = 30F;
            Condicion.HeaderText = "Condición";
            Condicion.MinimumWidth = 8;
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.DataPropertyName = "Nota";
            Nota.FillWeight = 20F;
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 8;
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.FillWeight = 10F;
            Editar.HeaderText = "";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Borrar
            // 
            Borrar.FillWeight = 10F;
            Borrar.HeaderText = "";
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            Borrar.Text = "Borrar";
            Borrar.UseColumnTextForButtonValue = true;
            // 
            // lblAlumno
            // 
            lblAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new System.Drawing.Point(153, 13);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new System.Drawing.Size(498, 15);
            lblAlumno.TabIndex = 4;
            lblAlumno.Text = "text";
            // 
            // lblInscripcion
            // 
            lblInscripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblInscripcion.AutoSize = true;
            lblInscripcion.Location = new System.Drawing.Point(3, 13);
            lblInscripcion.Name = "lblInscripcion";
            lblInscripcion.Size = new System.Drawing.Size(142, 15);
            lblInscripcion.TabIndex = 3;
            lblInscripcion.Text = "Inscripciones del alumno: ";
            // 
            // lblPlanDescripcion
            // 
            lblPlanDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPlanDescripcion.AutoSize = true;
            lblPlanDescripcion.Location = new System.Drawing.Point(3, 49);
            lblPlanDescripcion.Name = "lblPlanDescripcion";
            lblPlanDescripcion.Size = new System.Drawing.Size(144, 15);
            lblPlanDescripcion.TabIndex = 5;
            lblPlanDescripcion.Text = "Plan:";
            // 
            // lblPlan
            // 
            lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(153, 49);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(498, 15);
            lblPlan.TabIndex = 6;
            lblPlan.Text = "plantext";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevaAsignacion, tsCargaMasiva });
            toolStrip1.Location = new System.Drawing.Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(313, 25);
            toolStrip1.TabIndex = 0;
            // 
            // tsNuevaAsignacion
            // 
            tsNuevaAsignacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevaAsignacion.Image = (System.Drawing.Image)resources.GetObject("tsNuevaAsignacion.Image");
            tsNuevaAsignacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevaAsignacion.Name = "tsNuevaAsignacion";
            tsNuevaAsignacion.Size = new System.Drawing.Size(147, 22);
            tsNuevaAsignacion.Text = "Asignar nueva inscripción";
            tsNuevaAsignacion.Click += tsNuevaAsignacion_Click;
            // 
            // tsCargaMasiva
            // 
            tsCargaMasiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsCargaMasiva.Image = (System.Drawing.Image)resources.GetObject("tsCargaMasiva.Image");
            tsCargaMasiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsCargaMasiva.Name = "tsCargaMasiva";
            tsCargaMasiva.Size = new System.Drawing.Size(123, 22);
            tsCargaMasiva.Text = "Asignar inscripciones";
            tsCargaMasiva.Click += tsCargaMasiva_Click;
            // 
            // AlumnoInscripciones
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(797, 456);
            Controls.Add(toolStripContainer1);
            Name = "AlumnoInscripciones";
            Text = "AlumnoInscripciones";
            Load += AlumnoInscripciones_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tlpInscripciones.ResumeLayout(false);
            tlpInscripciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnoInscripciones).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlpInscripciones;
        private System.Windows.Forms.DataGridView dgvAlumnoInscripciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNuevaAsignacion;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblPlanDescripcion;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ToolStripButton tsCargaMasiva;
    }
}