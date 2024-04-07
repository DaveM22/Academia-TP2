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
            btnSeleccionarEspecialidad = new System.Windows.Forms.Button();
            lblEspecialidad = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            txtDescripcion = new UserControls.TextBoxConValidacion();
            txtEspecialidad = new UserControls.TextBoxConValidacion();
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
            tlpPlanes.BackColor = System.Drawing.Color.Transparent;
            tlpPlanes.ColumnCount = 5;
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 405F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpPlanes.Controls.Add(lblTitulo, 1, 0);
            tlpPlanes.Controls.Add(lblDescripcion, 1, 1);
            tlpPlanes.Controls.Add(btnSeleccionarEspecialidad, 3, 2);
            tlpPlanes.Controls.Add(lblEspecialidad, 1, 2);
            tlpPlanes.Controls.Add(btnCancelar, 3, 3);
            tlpPlanes.Controls.Add(btnGuardar, 2, 3);
            tlpPlanes.Controls.Add(txtDescripcion, 2, 1);
            tlpPlanes.Controls.Add(txtEspecialidad, 2, 2);
            tlpPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPlanes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tlpPlanes.Location = new System.Drawing.Point(0, 0);
            tlpPlanes.Name = "tlpPlanes";
            tlpPlanes.RowCount = 3;
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpPlanes.Size = new System.Drawing.Size(771, 310);
            tlpPlanes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tlpPlanes.SetColumnSpan(lblTitulo, 3);
            lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTitulo.Location = new System.Drawing.Point(86, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(599, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crear plan";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            lblDescripcion.Location = new System.Drawing.Point(86, 106);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(87, 36);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSeleccionarEspecialidad
            // 
            btnSeleccionarEspecialidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tlpPlanes.SetColumnSpan(btnSeleccionarEspecialidad, 2);
            btnSeleccionarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionarEspecialidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSeleccionarEspecialidad.Location = new System.Drawing.Point(584, 153);
            btnSeleccionarEspecialidad.Name = "btnSeleccionarEspecialidad";
            btnSeleccionarEspecialidad.Size = new System.Drawing.Size(183, 27);
            btnSeleccionarEspecialidad.TabIndex = 9;
            btnSeleccionarEspecialidad.Text = "Seleccionar especialidad";
            btnSeleccionarEspecialidad.UseVisualStyleBackColor = false;
            btnSeleccionarEspecialidad.Click += btnSeleccionarEspecialidad_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblEspecialidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblEspecialidad.Location = new System.Drawing.Point(86, 155);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(87, 38);
            lblEspecialidad.TabIndex = 2;
            lblEspecialidad.Text = "Especialidad:";
            lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(584, 201);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(76, 29);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 255, 128);
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnGuardar.Location = new System.Drawing.Point(503, 201);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescripcion.Location = new System.Drawing.Point(177, 99);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(1);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(403, 50);
            txtDescripcion.TabIndex = 10;
            txtDescripcion.Load += txtDescripcion_Load;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.BackColor = System.Drawing.Color.Transparent;
            txtEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            txtEspecialidad.Location = new System.Drawing.Point(177, 151);
            txtEspecialidad.Margin = new System.Windows.Forms.Padding(1);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new System.Drawing.Size(403, 46);
            txtEspecialidad.TabIndex = 11;
            txtEspecialidad.Load += txtEspecialidad_Load;
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
            ClientSize = new System.Drawing.Size(771, 310);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnCancelar;
        private UserControls.TextBoxConValidacion txtEspecialidad;
        private UserControls.TextBoxConValidacion txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
    }
}