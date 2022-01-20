namespace UI.Desktop
{
    partial class PlanDesktop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlPlan = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.tcPlan = new System.Windows.Forms.TabControl();
            this.Materias = new System.Windows.Forms.TabPage();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Formulario = new System.Windows.Forms.TabPage();
            this.tlpMateria = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcionMateria = new System.Windows.Forms.Label();
            this.nudHsSemanales = new System.Windows.Forms.NumericUpDown();
            this.nudHsTotales = new System.Windows.Forms.NumericUpDown();
            this.lblSemanales = new System.Windows.Forms.Label();
            this.lblHsTotales = new System.Windows.Forms.Label();
            this.btnGuardarMateria = new System.Windows.Forms.Button();
            this.btnCancelarMateria = new System.Windows.Forms.Button();
            this.txtMateriaDescripcion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.tlPlan.SuspendLayout();
            this.tcPlan.SuspendLayout();
            this.Materias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.Formulario.SuspendLayout();
            this.tlpMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsSemanales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // tlPlan
            // 
            this.tlPlan.ColumnCount = 4;
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.70226F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.10738F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.99903F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.19132F));
            this.tlPlan.Controls.Add(this.lblDescripcion, 0, 0);
            this.tlPlan.Controls.Add(this.lblEspecialidad, 0, 1);
            this.tlPlan.Controls.Add(this.lblMaterias, 0, 2);
            this.tlPlan.Controls.Add(this.tcPlan, 2, 2);
            this.tlPlan.Controls.Add(this.txtDescripcion, 1, 0);
            this.tlPlan.Controls.Add(this.cmbEspecialidad, 1, 1);
            this.tlPlan.Controls.Add(this.btnAceptar, 3, 4);
            this.tlPlan.Controls.Add(this.btnCancelar, 2, 4);
            this.tlPlan.Controls.Add(this.btnAgregarMateria, 2, 2);
            this.tlPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlan.Location = new System.Drawing.Point(0, 0);
            this.tlPlan.Name = "tlPlan";
            this.tlPlan.RowCount = 5;
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.Size = new System.Drawing.Size(1303, 671);
            this.tlPlan.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 25);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(3, 37);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(109, 25);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(3, 76);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(79, 25);
            this.lblMaterias.TabIndex = 3;
            this.lblMaterias.Text = "Materias";
            // 
            // tcPlan
            // 
            this.tlPlan.SetColumnSpan(this.tcPlan, 4);
            this.tcPlan.Controls.Add(this.Materias);
            this.tcPlan.Controls.Add(this.Formulario);
            this.tcPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlan.Location = new System.Drawing.Point(3, 119);
            this.tcPlan.Name = "tcPlan";
            this.tcPlan.SelectedIndex = 0;
            this.tcPlan.Size = new System.Drawing.Size(1297, 509);
            this.tcPlan.TabIndex = 5;
            // 
            // Materias
            // 
            this.Materias.Controls.Add(this.dgvMaterias);
            this.Materias.Location = new System.Drawing.Point(4, 34);
            this.Materias.Name = "Materias";
            this.Materias.Padding = new System.Windows.Forms.Padding(3);
            this.Materias.Size = new System.Drawing.Size(1289, 471);
            this.Materias.TabIndex = 0;
            this.Materias.Text = "Materias";
            this.Materias.UseVisualStyleBackColor = true;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Materia,
            this.HsSemanales,
            this.HsTotales,
            this.Accion});
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMaterias.RowTemplate.Height = 33;
            this.dgvMaterias.Size = new System.Drawing.Size(1283, 465);
            this.dgvMaterias.TabIndex = 0;
            this.dgvMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Descripcion";
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 8;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 107;
            // 
            // HsSemanales
            // 
            this.HsSemanales.DataPropertyName = "HSSemanales";
            this.HsSemanales.HeaderText = "Hs Semanales";
            this.HsSemanales.MinimumWidth = 8;
            this.HsSemanales.Name = "HsSemanales";
            this.HsSemanales.ReadOnly = true;
            this.HsSemanales.Width = 158;
            // 
            // HsTotales
            // 
            this.HsTotales.DataPropertyName = "HSTotales";
            this.HsTotales.HeaderText = "Hs Totales";
            this.HsTotales.MinimumWidth = 8;
            this.HsTotales.Name = "HsTotales";
            this.HsTotales.ReadOnly = true;
            this.HsTotales.Width = 128;
            // 
            // Accion
            // 
            dataGridViewCellStyle2.NullValue = "Editar";
            this.Accion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Accion.HeaderText = "";
            this.Accion.MinimumWidth = 8;
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Accion.Width = 8;
            // 
            // Formulario
            // 
            this.Formulario.Controls.Add(this.tlpMateria);
            this.Formulario.Location = new System.Drawing.Point(4, 34);
            this.Formulario.Name = "Formulario";
            this.Formulario.Padding = new System.Windows.Forms.Padding(3);
            this.Formulario.Size = new System.Drawing.Size(1289, 471);
            this.Formulario.TabIndex = 1;
            this.Formulario.Text = "Formulario materias";
            this.Formulario.UseVisualStyleBackColor = true;
            // 
            // tlpMateria
            // 
            this.tlpMateria.ColumnCount = 4;
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 454F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 557F));
            this.tlpMateria.Controls.Add(this.lblDescripcionMateria, 0, 1);
            this.tlpMateria.Controls.Add(this.nudHsSemanales, 1, 2);
            this.tlpMateria.Controls.Add(this.nudHsTotales, 1, 3);
            this.tlpMateria.Controls.Add(this.lblSemanales, 0, 2);
            this.tlpMateria.Controls.Add(this.lblHsTotales, 0, 3);
            this.tlpMateria.Controls.Add(this.btnGuardarMateria, 1, 4);
            this.tlpMateria.Controls.Add(this.btnCancelarMateria, 2, 4);
            this.tlpMateria.Controls.Add(this.txtMateriaDescripcion, 1, 1);
            this.tlpMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMateria.Location = new System.Drawing.Point(3, 3);
            this.tlpMateria.Name = "tlpMateria";
            this.tlpMateria.RowCount = 8;
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.6129F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.3871F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpMateria.Size = new System.Drawing.Size(1283, 465);
            this.tlpMateria.TabIndex = 0;
            // 
            // lblDescripcionMateria
            // 
            this.lblDescripcionMateria.AutoSize = true;
            this.lblDescripcionMateria.Location = new System.Drawing.Point(3, 7);
            this.lblDescripcionMateria.Name = "lblDescripcionMateria";
            this.lblDescripcionMateria.Size = new System.Drawing.Size(104, 25);
            this.lblDescripcionMateria.TabIndex = 0;
            this.lblDescripcionMateria.Text = "Descripción";
            // 
            // nudHsSemanales
            // 
            this.nudHsSemanales.Location = new System.Drawing.Point(139, 75);
            this.nudHsSemanales.Name = "nudHsSemanales";
            this.nudHsSemanales.Size = new System.Drawing.Size(129, 31);
            this.nudHsSemanales.TabIndex = 1;
            // 
            // nudHsTotales
            // 
            this.nudHsTotales.Location = new System.Drawing.Point(139, 142);
            this.nudHsTotales.Name = "nudHsTotales";
            this.nudHsTotales.Size = new System.Drawing.Size(129, 31);
            this.nudHsTotales.TabIndex = 2;
            // 
            // lblSemanales
            // 
            this.lblSemanales.AutoSize = true;
            this.lblSemanales.Location = new System.Drawing.Point(3, 72);
            this.lblSemanales.Name = "lblSemanales";
            this.lblSemanales.Size = new System.Drawing.Size(122, 25);
            this.lblSemanales.TabIndex = 3;
            this.lblSemanales.Text = "Hs Semanales";
            // 
            // lblHsTotales
            // 
            this.lblHsTotales.AutoSize = true;
            this.lblHsTotales.Location = new System.Drawing.Point(3, 139);
            this.lblHsTotales.Name = "lblHsTotales";
            this.lblHsTotales.Size = new System.Drawing.Size(92, 25);
            this.lblHsTotales.TabIndex = 4;
            this.lblHsTotales.Text = "Hs Totales";
            // 
            // btnGuardarMateria
            // 
            this.btnGuardarMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarMateria.Location = new System.Drawing.Point(475, 212);
            this.btnGuardarMateria.Name = "btnGuardarMateria";
            this.btnGuardarMateria.Size = new System.Drawing.Size(112, 34);
            this.btnGuardarMateria.TabIndex = 5;
            this.btnGuardarMateria.Text = "Guardar materia";
            this.btnGuardarMateria.UseVisualStyleBackColor = true;
            this.btnGuardarMateria.Click += new System.EventHandler(this.btnGuardarMateria_Click);
            // 
            // btnCancelarMateria
            // 
            this.btnCancelarMateria.Location = new System.Drawing.Point(593, 212);
            this.btnCancelarMateria.Name = "btnCancelarMateria";
            this.btnCancelarMateria.Size = new System.Drawing.Size(112, 34);
            this.btnCancelarMateria.TabIndex = 6;
            this.btnCancelarMateria.Text = "Cancelar";
            this.btnCancelarMateria.UseVisualStyleBackColor = true;
            // 
            // txtMateriaDescripcion
            // 
            this.txtMateriaDescripcion.Location = new System.Drawing.Point(139, 10);
            this.txtMateriaDescripcion.Name = "txtMateriaDescripcion";
            this.txtMateriaDescripcion.Size = new System.Drawing.Size(443, 31);
            this.txtMateriaDescripcion.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.tlPlan.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Location = new System.Drawing.Point(155, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(447, 31);
            this.txtDescripcion.TabIndex = 1;
            // 
            // cmbEspecialidad
            // 
            this.tlPlan.SetColumnSpan(this.cmbEspecialidad, 2);
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(155, 40);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(447, 33);
            this.cmbEspecialidad.TabIndex = 4;
            this.cmbEspecialidad.ValueMember = "Id";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1172, 634);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1054, 634);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(651, 79);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(515, 34);
            this.btnAgregarMateria.TabIndex = 8;
            this.btnAgregarMateria.Text = "Agregar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 671);
            this.Controls.Add(this.tlPlan);
            this.Name = "PlanDesktop";
            this.Text = "PlanDesktop";
            this.Load += new System.EventHandler(this.PlanDesktop_Load);
            this.tlPlan.ResumeLayout(false);
            this.tlPlan.PerformLayout();
            this.tcPlan.ResumeLayout(false);
            this.Materias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.Formulario.ResumeLayout(false);
            this.tlpMateria.ResumeLayout(false);
            this.tlpMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsSemanales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsTotales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPlan;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tcPlan;
        private System.Windows.Forms.TabPage Materias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TabPage Formulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsTotales;
        private System.Windows.Forms.DataGridViewLinkColumn Accion;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.TableLayoutPanel tlpMateria;
        private System.Windows.Forms.Label lblDescripcionMateria;
        private System.Windows.Forms.NumericUpDown nudHsSemanales;
        private System.Windows.Forms.NumericUpDown nudHsTotales;
        private System.Windows.Forms.Label lblSemanales;
        private System.Windows.Forms.Label lblHsTotales;
        private System.Windows.Forms.Button btnGuardarMateria;
        private System.Windows.Forms.Button btnCancelarMateria;
        private System.Windows.Forms.TextBox txtMateriaDescripcion;
    }
}