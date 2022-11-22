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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidades));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsEspecialidades = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.tsEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlpEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(1144, 463);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(1144, 497);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "Especialidades";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.tsEspecialidades);
            this.tscEspecialidades.TopToolStripPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // tlpEspecialidades
            // 
            this.tlpEspecialidades.ColumnCount = 2;
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEspecialidades.Controls.Add(this.dgvEspecialidades, 0, 0);
            this.tlpEspecialidades.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpEspecialidades.Controls.Add(this.btnSalir, 1, 1);
            this.tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlpEspecialidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpEspecialidades.Name = "tlpEspecialidades";
            this.tlpEspecialidades.RowCount = 2;
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEspecialidades.Size = new System.Drawing.Size(1144, 463);
            this.tlpEspecialidades.TabIndex = 1;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Editar,
            this.Eliminar});
            this.tlpEspecialidades.SetColumnSpan(this.dgvEspecialidades, 2);
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(4, 5);
            this.dgvEspecialidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersWidth = 62;
            this.dgvEspecialidades.RowTemplate.Height = 25;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(1136, 395);
            this.dgvEspecialidades.TabIndex = 0;
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
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Descripcion";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 200;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 200;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizar.Location = new System.Drawing.Point(918, 410);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 48);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalir.Location = new System.Drawing.Point(1033, 410);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 48);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // tsEspecialidades
            // 
            this.tsEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tsEspecialidades.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialidades.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsEspecialidades.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsEspecialidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo});
            this.tsEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tsEspecialidades.Name = "tsEspecialidades";
            this.tsEspecialidades.Size = new System.Drawing.Size(172, 34);
            this.tsEspecialidades.TabIndex = 0;
            // 
            // tsNuevo
            // 
            this.tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(168, 29);
            this.tsNuevo.Text = "Nueva especialidad";
            this.tsNuevo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1144, 497);
            this.ControlBox = false;
            this.Controls.Add(this.tscEspecialidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Especialidades_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.tsEspecialidades.ResumeLayout(false);
            this.tsEspecialidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.ToolStrip tsEspecialidades;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}