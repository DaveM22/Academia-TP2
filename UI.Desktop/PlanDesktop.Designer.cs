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
            this.tlPlan = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.tcPlan = new System.Windows.Forms.TabControl();
            this.Materias = new System.Windows.Forms.TabPage();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlPlan.SuspendLayout();
            this.tcPlan.SuspendLayout();
            this.Materias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tlPlan
            // 
            this.tlPlan.ColumnCount = 2;
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.26754F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.73245F));
            this.tlPlan.Controls.Add(this.lblDescripcion, 0, 0);
            this.tlPlan.Controls.Add(this.txtDescripcion, 1, 0);
            this.tlPlan.Controls.Add(this.lblEspecialidad, 0, 1);
            this.tlPlan.Controls.Add(this.lblMaterias, 0, 2);
            this.tlPlan.Controls.Add(this.cmbEspecialidad, 1, 1);
            this.tlPlan.Controls.Add(this.tcPlan, 1, 2);
            this.tlPlan.Controls.Add(this.btnAceptar, 0, 3);
            this.tlPlan.Controls.Add(this.btnCancelar, 1, 3);
            this.tlPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlan.Location = new System.Drawing.Point(0, 0);
            this.tlPlan.Name = "tlPlan";
            this.tlPlan.RowCount = 4;
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.37313F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.62687F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlPlan.Size = new System.Drawing.Size(912, 556);
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
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(447, 31);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(3, 82);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(109, 25);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(3, 187);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(79, 25);
            this.lblMaterias.TabIndex = 3;
            this.lblMaterias.Text = "Materias";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DisplayMember = "Descripcion";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(123, 85);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(447, 33);
            this.cmbEspecialidad.TabIndex = 4;
            this.cmbEspecialidad.ValueMember = "Id";
            // 
            // tcPlan
            // 
            this.tcPlan.Controls.Add(this.Materias);
            this.tcPlan.Controls.Add(this.Agregar);
            this.tcPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPlan.Location = new System.Drawing.Point(123, 190);
            this.tcPlan.Name = "tcPlan";
            this.tcPlan.SelectedIndex = 0;
            this.tcPlan.Size = new System.Drawing.Size(786, 304);
            this.tcPlan.TabIndex = 5;
            // 
            // Materias
            // 
            this.Materias.Controls.Add(this.dgvMaterias);
            this.Materias.Location = new System.Drawing.Point(4, 34);
            this.Materias.Name = "Materias";
            this.Materias.Padding = new System.Windows.Forms.Padding(3);
            this.Materias.Size = new System.Drawing.Size(778, 266);
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
            this.HsTotales});
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 62;
            this.dgvMaterias.RowTemplate.Height = 33;
            this.dgvMaterias.Size = new System.Drawing.Size(772, 260);
            this.dgvMaterias.TabIndex = 0;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(4, 34);
            this.Agregar.Name = "Agregar";
            this.Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.Agregar.Size = new System.Drawing.Size(778, 266);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar Materia";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 500);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 500);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
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
            this.Materia.Frozen = true;
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 8;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            this.Materia.Width = 150;
            // 
            // HsSemanales
            // 
            this.HsSemanales.DataPropertyName = "HSSemanales";
            this.HsSemanales.Frozen = true;
            this.HsSemanales.HeaderText = "Hs Semanales";
            this.HsSemanales.MinimumWidth = 8;
            this.HsSemanales.Name = "HsSemanales";
            this.HsSemanales.ReadOnly = true;
            this.HsSemanales.Width = 150;
            // 
            // HsTotales
            // 
            this.HsTotales.DataPropertyName = "HSTotales";
            this.HsTotales.Frozen = true;
            this.HsTotales.HeaderText = "Hs Totales";
            this.HsTotales.MinimumWidth = 8;
            this.HsTotales.Name = "HsTotales";
            this.HsTotales.ReadOnly = true;
            this.HsTotales.Width = 150;
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 556);
            this.Controls.Add(this.tlPlan);
            this.Name = "PlanDesktop";
            this.Text = "PlanDesktop";
            this.Load += new System.EventHandler(this.PlanDesktop_Load);
            this.tlPlan.ResumeLayout(false);
            this.tlPlan.PerformLayout();
            this.tcPlan.ResumeLayout(false);
            this.Materias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPlan;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TabControl tcPlan;
        private System.Windows.Forms.TabPage Materias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TabPage Agregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsTotales;
    }
}