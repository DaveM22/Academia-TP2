namespace UI.Desktop
{
    partial class Personas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personas));
            tscPersonas = new System.Windows.Forms.ToolStripContainer();
            tlpPersonas = new System.Windows.Forms.TableLayoutPanel();
            dgvPersonas = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            btnActualizar = new System.Windows.Forms.Button();
            btnCerrar = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsNuevo = new System.Windows.Forms.ToolStripLabel();
            tscPersonas.ContentPanel.SuspendLayout();
            tscPersonas.TopToolStripPanel.SuspendLayout();
            tscPersonas.SuspendLayout();
            tlpPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tscPersonas
            // 
            // 
            // tscPersonas.ContentPanel
            // 
            tscPersonas.ContentPanel.Controls.Add(tlpPersonas);
            tscPersonas.ContentPanel.Size = new System.Drawing.Size(1158, 428);
            tscPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            tscPersonas.Location = new System.Drawing.Point(0, 0);
            tscPersonas.Name = "tscPersonas";
            tscPersonas.Size = new System.Drawing.Size(1158, 458);
            tscPersonas.TabIndex = 0;
            tscPersonas.Text = "toolStripContainer1";
            // 
            // tscPersonas.TopToolStripPanel
            // 
            tscPersonas.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlpPersonas
            // 
            tlpPersonas.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpPersonas.ColumnCount = 2;
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpPersonas.Controls.Add(dgvPersonas, 0, 0);
            tlpPersonas.Controls.Add(btnActualizar, 0, 1);
            tlpPersonas.Controls.Add(btnCerrar, 1, 1);
            tlpPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPersonas.Location = new System.Drawing.Point(0, 0);
            tlpPersonas.Name = "tlpPersonas";
            tlpPersonas.RowCount = 2;
            tlpPersonas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPersonas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpPersonas.Size = new System.Drawing.Size(1158, 428);
            tlpPersonas.TabIndex = 0;
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Apellido, Nombre, Direccion, Telefono, Email, FechaNacimiento, Plan, Editar, Eliminar });
            tlpPersonas.SetColumnSpan(dgvPersonas, 2);
            dgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPersonas.Location = new System.Drawing.Point(3, 3);
            dgvPersonas.MultiSelect = false;
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPersonas.RowTemplate.Height = 33;
            dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.Size = new System.Drawing.Size(1152, 375);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellClick += dgvPersonas_CellClick;
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
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Direccion
            // 
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 150;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.MinimumWidth = 8;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            FechaNacimiento.Width = 150;
            // 
            // Plan
            // 
            Plan.DataPropertyName = "PlanDescripcion";
            Plan.HeaderText = "Plan";
            Plan.MinimumWidth = 8;
            Plan.Name = "Plan";
            Plan.ReadOnly = true;
            Plan.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 150;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(925, 384);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(112, 41);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.Firebrick;
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCerrar.Location = new System.Drawing.Point(1043, 384);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(112, 41);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevo });
            toolStrip1.Location = new System.Drawing.Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(147, 30);
            toolStrip1.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevo.Image = (System.Drawing.Image)resources.GetObject("tsNuevo.Image");
            tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new System.Drawing.Size(129, 25);
            tsNuevo.Text = "Nuevo alumno";
            tsNuevo.Click += tsNuevo_Click;
            // 
            // Personas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1158, 458);
            Controls.Add(tscPersonas);
            Name = "Personas";
            Text = "Personas";
            Load += Personas_Load;
            tscPersonas.ContentPanel.ResumeLayout(false);
            tscPersonas.TopToolStripPanel.ResumeLayout(false);
            tscPersonas.TopToolStripPanel.PerformLayout();
            tscPersonas.ResumeLayout(false);
            tscPersonas.PerformLayout();
            tlpPersonas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscPersonas;
        private System.Windows.Forms.TableLayoutPanel tlpPersonas;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.ToolStripLabel tsNuevo;
    }
}