namespace UI.Desktop
{
    partial class Especialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidades));
            tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            dgvEspecialidades = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            btnActualizar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            tsEspecialidades = new System.Windows.Forms.ToolStrip();
            tsNuevo = new System.Windows.Forms.ToolStripButton();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            lblTitulo = new System.Windows.Forms.Label();
            tscEspecialidades.ContentPanel.SuspendLayout();
            tscEspecialidades.TopToolStripPanel.SuspendLayout();
            tscEspecialidades.SuspendLayout();
            tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            tsEspecialidades.SuspendLayout();
            SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            tscEspecialidades.ContentPanel.Controls.Add(tlpEspecialidades);
            tscEspecialidades.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(801, 343);
            tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            tscEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            tscEspecialidades.Name = "tscEspecialidades";
            tscEspecialidades.Size = new System.Drawing.Size(801, 368);
            tscEspecialidades.TabIndex = 0;
            tscEspecialidades.Text = "Especialidades";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            tscEspecialidades.TopToolStripPanel.Controls.Add(tsEspecialidades);
            tscEspecialidades.TopToolStripPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // tlpEspecialidades
            // 
            tlpEspecialidades.ColumnCount = 2;
            tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpEspecialidades.Controls.Add(btnActualizar, 0, 2);
            tlpEspecialidades.Controls.Add(btnSalir, 1, 2);
            tlpEspecialidades.Controls.Add(dgvEspecialidades, 0, 1);
            tlpEspecialidades.Controls.Add(lblTitulo, 0, 0);
            tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            tlpEspecialidades.Name = "tlpEspecialidades";
            tlpEspecialidades.RowCount = 3;
            tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpEspecialidades.Size = new System.Drawing.Size(801, 343);
            tlpEspecialidades.TabIndex = 1;
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Nombre, Editar, Eliminar });
            tlpEspecialidades.SetColumnSpan(dgvEspecialidades, 2);
            dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEspecialidades.Location = new System.Drawing.Point(3, 35);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersWidth = 62;
            dgvEspecialidades.RowTemplate.Height = 33;
            dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new System.Drawing.Size(795, 270);
            dgvEspecialidades.TabIndex = 0;
            dgvEspecialidades.CellClick += dgvEspecialidades_CellClick_1;
            dgvEspecialidades.Paint += dgvEspecialidades_Paint;
            // 
            // Id
            // 
            Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            Id.DataPropertyName = "Id";
            Id.FillWeight = 10F;
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Id.Visible = false;
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Descripcion";
            Nombre.FillWeight = 70F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 3;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Editar.FillWeight = 10F;
            Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Editar.HeaderText = "";
            Editar.MinimumWidth = 100;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Eliminar.FillWeight = 10F;
            Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 100;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(596, 311);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(75, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.Firebrick;
            btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSalir.Location = new System.Drawing.Point(677, 311);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(121, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Volver al inicio";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // tsEspecialidades
            // 
            tsEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tsEspecialidades.Dock = System.Windows.Forms.DockStyle.None;
            tsEspecialidades.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tsEspecialidades.ImageScalingSize = new System.Drawing.Size(24, 24);
            tsEspecialidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsNuevo });
            tsEspecialidades.Location = new System.Drawing.Point(0, 0);
            tsEspecialidades.Name = "tsEspecialidades";
            tsEspecialidades.Size = new System.Drawing.Size(116, 25);
            tsEspecialidades.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsNuevo.Image = (System.Drawing.Image)resources.GetObject("tsNuevo.Image");
            tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new System.Drawing.Size(113, 22);
            tsNuevo.Text = "Nueva especialidad";
            tsNuevo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            tsNuevo.Click += tsNuevo_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tlpEspecialidades.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(3, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(795, 27);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Especialidades";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Especialidades
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.CornflowerBlue;
            ClientSize = new System.Drawing.Size(801, 368);
            Controls.Add(tscEspecialidades);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Especialidades";
            Text = "Especialidades";
            Load += Especialidades_Load;
            tscEspecialidades.ContentPanel.ResumeLayout(false);
            tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            tscEspecialidades.TopToolStripPanel.PerformLayout();
            tscEspecialidades.ResumeLayout(false);
            tscEspecialidades.PerformLayout();
            tlpEspecialidades.ResumeLayout(false);
            tlpEspecialidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            tsEspecialidades.ResumeLayout(false);
            tsEspecialidades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsEspecialidades;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTitulo;
    }
}