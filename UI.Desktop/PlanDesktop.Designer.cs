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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            tlpPlanes = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            lblEspecialidad = new System.Windows.Forms.Label();
            gbMaterias = new System.Windows.Forms.GroupBox();
            dgvMaterias = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HorasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            txtDescripcion = new System.Windows.Forms.TextBox();
            txtEspecialidad = new System.Windows.Forms.TextBox();
            btnCancelar = new System.Windows.Forms.Button();
            btnAgregarMateria = new System.Windows.Forms.Button();
            btnSeleccionarEspecialidad = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tlpPlanes.SuspendLayout();
            gbMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // tlpPlanes
            // 
            tlpPlanes.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpPlanes.ColumnCount = 7;
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPlanes.Controls.Add(label1, 1, 0);
            tlpPlanes.Controls.Add(lblDescripcion, 1, 1);
            tlpPlanes.Controls.Add(lblEspecialidad, 1, 2);
            tlpPlanes.Controls.Add(gbMaterias, 1, 4);
            tlpPlanes.Controls.Add(txtDescripcion, 2, 1);
            tlpPlanes.Controls.Add(txtEspecialidad, 2, 2);
            tlpPlanes.Controls.Add(btnCancelar, 5, 5);
            tlpPlanes.Controls.Add(btnAgregarMateria, 4, 3);
            tlpPlanes.Controls.Add(btnSeleccionarEspecialidad, 4, 2);
            tlpPlanes.Controls.Add(btnGuardar, 4, 5);
            tlpPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPlanes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tlpPlanes.Location = new System.Drawing.Point(0, 0);
            tlpPlanes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tlpPlanes.Name = "tlpPlanes";
            tlpPlanes.RowCount = 7;
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.70533F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.665622F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.62905F));
            tlpPlanes.Size = new System.Drawing.Size(1143, 750);
            tlpPlanes.TabIndex = 0;
            tlpPlanes.Paint += tlpPlanes_Paint_1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            tlpPlanes.SetColumnSpan(label1, 5);
            label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(492, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 34);
            label1.TabIndex = 0;
            label1.Text = "Crear plan";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(142, 67);
            lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(108, 25);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new System.Drawing.Point(142, 118);
            lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(113, 25);
            lblEspecialidad.TabIndex = 2;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // gbMaterias
            // 
            gbMaterias.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpPlanes.SetColumnSpan(gbMaterias, 5);
            gbMaterias.Controls.Add(dgvMaterias);
            gbMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            gbMaterias.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbMaterias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            gbMaterias.Location = new System.Drawing.Point(142, 214);
            gbMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gbMaterias.Name = "gbMaterias";
            gbMaterias.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gbMaterias.Size = new System.Drawing.Size(858, 399);
            gbMaterias.TabIndex = 3;
            gbMaterias.TabStop = false;
            gbMaterias.Text = "Materias";
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaterias.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, HsSemanales, HorasTotales, Editar, Eliminar });
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvMaterias.DefaultCellStyle = dataGridViewCellStyle7;
            dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMaterias.Location = new System.Drawing.Point(4, 43);
            dgvMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersWidth = 62;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.Size = new System.Drawing.Size(850, 351);
            dgvMaterias.TabIndex = 0;
            dgvMaterias.CellClick += dgvMaterias_CellClick;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            dataGridViewTextBoxColumn6.HeaderText = "IdMateria";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Descripcion";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // HsSemanales
            // 
            HsSemanales.DataPropertyName = "HSSemanales";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            HsSemanales.DefaultCellStyle = dataGridViewCellStyle3;
            HsSemanales.HeaderText = "Horas semanales";
            HsSemanales.MinimumWidth = 8;
            HsSemanales.Name = "HsSemanales";
            HsSemanales.ReadOnly = true;
            // 
            // HorasTotales
            // 
            HorasTotales.DataPropertyName = "HSTotales";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            HorasTotales.DefaultCellStyle = dataGridViewCellStyle4;
            HorasTotales.HeaderText = "Horas totales";
            HorasTotales.MinimumWidth = 8;
            HorasTotales.Name = "HorasTotales";
            HorasTotales.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            Editar.DefaultCellStyle = dataGridViewCellStyle5;
            Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Salmon;
            Eliminar.DefaultCellStyle = dataGridViewCellStyle6;
            Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(269, 60);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(348, 31);
            txtDescripcion.TabIndex = 5;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtEspecialidad.Location = new System.Drawing.Point(269, 115);
            txtEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new System.Drawing.Size(348, 31);
            txtEspecialidad.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(891, 623);
            btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(109, 42);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tlpPlanes.SetColumnSpan(btnAgregarMateria, 2);
            btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregarMateria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAgregarMateria.Location = new System.Drawing.Point(672, 162);
            btnAgregarMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new System.Drawing.Size(237, 42);
            btnAgregarMateria.TabIndex = 4;
            btnAgregarMateria.Text = "Agregar materia";
            btnAgregarMateria.UseVisualStyleBackColor = false;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // btnSeleccionarEspecialidad
            // 
            btnSeleccionarEspecialidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tlpPlanes.SetColumnSpan(btnSeleccionarEspecialidad, 3);
            btnSeleccionarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionarEspecialidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSeleccionarEspecialidad.Location = new System.Drawing.Point(672, 110);
            btnSeleccionarEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSeleccionarEspecialidad.Name = "btnSeleccionarEspecialidad";
            btnSeleccionarEspecialidad.Size = new System.Drawing.Size(237, 42);
            btnSeleccionarEspecialidad.TabIndex = 9;
            btnSeleccionarEspecialidad.Text = "Seleccionar especialidad";
            btnSeleccionarEspecialidad.UseVisualStyleBackColor = false;
            btnSeleccionarEspecialidad.Click += btnSeleccionarEspecialidad_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnGuardar.Location = new System.Drawing.Point(776, 623);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(107, 42);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // IdMateria
            // 
            IdMateria.HeaderText = "IdMateria";
            IdMateria.MinimumWidth = 8;
            IdMateria.Name = "IdMateria";
            IdMateria.ReadOnly = true;
            IdMateria.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "IdMateria";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "IdMateria";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Visible = false;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "IdMateria";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // PlanDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(tlpPlanes);
            ForeColor = System.Drawing.SystemColors.ActiveCaption;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "PlanDesktop";
            Text = "PlanDesktop";
            Load += PlanDesktop_Load;
            tlpPlanes.ResumeLayout(false);
            tlpPlanes.PerformLayout();
            gbMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPlanes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.GroupBox gbMaterias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnSeleccionarEspecialidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTotales;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}