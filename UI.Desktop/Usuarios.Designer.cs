namespace UI.Desktop
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            tlUsuarios = new System.Windows.Forms.TableLayoutPanel();
            dgvUsuarios = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            btnActualizar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            tsUsuarios = new System.Windows.Forms.ToolStrip();
            tsNuevoUsuario = new System.Windows.Forms.ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tlUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tsUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tlUsuarios);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 461);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(800, 495);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "tscUsuarios";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            toolStripContainer1.TopToolStripPanel.Controls.Add(tsUsuarios);
            // 
            // tlUsuarios
            // 
            tlUsuarios.BackColor = System.Drawing.Color.CornflowerBlue;
            tlUsuarios.ColumnCount = 2;
            tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlUsuarios.Controls.Add(dgvUsuarios, 0, 0);
            tlUsuarios.Controls.Add(btnActualizar, 0, 1);
            tlUsuarios.Controls.Add(btnCancelar, 1, 1);
            tlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            tlUsuarios.Location = new System.Drawing.Point(0, 0);
            tlUsuarios.Name = "tlUsuarios";
            tlUsuarios.RowCount = 2;
            tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlUsuarios.Size = new System.Drawing.Size(800, 461);
            tlUsuarios.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, NombreUsuario, Email, Apellido, Nombre, Editar, Eliminar });
            tlUsuarios.SetColumnSpan(dgvUsuarios, 2);
            dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.RowTemplate.Height = 33;
            dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new System.Drawing.Size(794, 401);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Id.Visible = false;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "Usuario";
            NombreUsuario.MinimumWidth = 8;
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(569, 410);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(111, 48);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(686, 410);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(111, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // tsUsuarios
            // 
            tsUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            tsUsuarios.ImageScalingSize = new System.Drawing.Size(24, 24);
            tsUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevoUsuario });
            tsUsuarios.Location = new System.Drawing.Point(4, 0);
            tsUsuarios.Name = "tsUsuarios";
            tsUsuarios.Size = new System.Drawing.Size(149, 34);
            tsUsuarios.TabIndex = 0;
            // 
            // tsNuevoUsuario
            // 
            tsNuevoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevoUsuario.Image = (System.Drawing.Image)resources.GetObject("tsNuevoUsuario.Image");
            tsNuevoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevoUsuario.Name = "tsNuevoUsuario";
            tsNuevoUsuario.Size = new System.Drawing.Size(131, 29);
            tsNuevoUsuario.Text = "Nuevo usuario";
            tsNuevoUsuario.Click += tsNuevoUsuario_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 495);
            ControlBox = false;
            Controls.Add(toolStripContainer1);
            Name = "Usuarios";
            Text = "Usuarios";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tlUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tsUsuarios.ResumeLayout(false);
            tsUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip tsUsuarios;
        private System.Windows.Forms.ToolStripButton tsNuevoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}