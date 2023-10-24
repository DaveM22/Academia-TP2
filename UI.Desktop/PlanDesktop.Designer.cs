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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanDesktop));
            tlpPlanes = new System.Windows.Forms.TableLayoutPanel();
            lblTitulo = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new UserControls.TextBoxConValidacion();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            txtEspecialidad = new UserControls.TextBoxConValidacion();
            btnSeleccionarEspecialidad = new System.Windows.Forms.Button();
            lblEspecialidad = new System.Windows.Forms.Label();
            IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            tlpPlanes.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPlanes
            // 
            tlpPlanes.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpPlanes.ColumnCount = 5;
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPlanes.Controls.Add(lblTitulo, 1, 0);
            tlpPlanes.Controls.Add(lblDescripcion, 1, 1);
            tlpPlanes.Controls.Add(txtDescripcion, 2, 1);
            tlpPlanes.Controls.Add(btnGuardar, 2, 4);
            tlpPlanes.Controls.Add(btnCancelar, 3, 4);
            tlpPlanes.Controls.Add(txtEspecialidad, 2, 3);
            tlpPlanes.Controls.Add(btnSeleccionarEspecialidad, 3, 3);
            tlpPlanes.Controls.Add(lblEspecialidad, 1, 3);
            tlpPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPlanes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tlpPlanes.Location = new System.Drawing.Point(0, 0);
            tlpPlanes.Name = "tlpPlanes";
            tlpPlanes.RowCount = 5;
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            tlpPlanes.Size = new System.Drawing.Size(771, 184);
            tlpPlanes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tlpPlanes.SetColumnSpan(lblTitulo, 3);
            lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(61, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(649, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crear plan";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(61, 31);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(72, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescripcion.Location = new System.Drawing.Point(152, 29);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(1);
            txtDescripcion.Name = "txtDescripcion";
            tlpPlanes.SetRowSpan(txtDescripcion, 2);
            txtDescripcion.Size = new System.Drawing.Size(371, 52);
            txtDescripcion.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnGuardar.Location = new System.Drawing.Point(446, 135);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(527, 135);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(76, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            txtEspecialidad.Location = new System.Drawing.Point(152, 83);
            txtEspecialidad.Margin = new System.Windows.Forms.Padding(1);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new System.Drawing.Size(371, 48);
            txtEspecialidad.TabIndex = 11;
            // 
            // btnSeleccionarEspecialidad
            // 
            btnSeleccionarEspecialidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tlpPlanes.SetColumnSpan(btnSeleccionarEspecialidad, 2);
            btnSeleccionarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionarEspecialidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSeleccionarEspecialidad.Location = new System.Drawing.Point(527, 85);
            btnSeleccionarEspecialidad.Name = "btnSeleccionarEspecialidad";
            btnSeleccionarEspecialidad.Size = new System.Drawing.Size(183, 25);
            btnSeleccionarEspecialidad.TabIndex = 9;
            btnSeleccionarEspecialidad.Text = "Seleccionar especialidad";
            btnSeleccionarEspecialidad.UseVisualStyleBackColor = false;
            btnSeleccionarEspecialidad.Click += btnSeleccionarEspecialidad_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new System.Drawing.Point(61, 82);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(75, 15);
            lblEspecialidad.TabIndex = 2;
            lblEspecialidad.Text = "Especialidad:";
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
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // PlanDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(771, 184);
            Controls.Add(tlpPlanes);
            ForeColor = System.Drawing.SystemColors.ActiveCaption;
            Name = "PlanDesktop";
            Text = "PlanDesktop";
            Load += PlanDesktop_Load;
            tlpPlanes.ResumeLayout(false);
            tlpPlanes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPlanes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEspecialidad;
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
        private UserControls.TextBoxConValidacion txtDescripcion;
        private UserControls.TextBoxConValidacion txtEspecialidad;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}