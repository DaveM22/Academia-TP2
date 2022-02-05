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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidades));
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabEspecialidades = new System.Windows.Forms.TabControl();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabFormulario = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsEspecialidades = new System.Windows.Forms.ToolStrip();
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlEspecialidades.SuspendLayout();
            this.tabEspecialidades.SuspendLayout();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.tsEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlEspecialidades);
            this.tscEspecialidades.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(797, 525);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(797, 550);
            this.tscEspecialidades.TabIndex = 0;
            this.tscEspecialidades.Text = "Especialidades";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.tsEspecialidades);
            this.tscEspecialidades.TopToolStripPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // tlEspecialidades
            // 
            this.tlEspecialidades.ColumnCount = 2;
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlEspecialidades.Controls.Add(this.btnSalir, 1, 2);
            this.tlEspecialidades.Controls.Add(this.tabEspecialidades, 0, 0);
            this.tlEspecialidades.Controls.Add(this.btnActualizar, 0, 2);
            this.tlEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            this.tlEspecialidades.Name = "tlEspecialidades";
            this.tlEspecialidades.RowCount = 3;
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlEspecialidades.Size = new System.Drawing.Size(797, 525);
            this.tlEspecialidades.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(717, 497);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 26);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabEspecialidades
            // 
            this.tlEspecialidades.SetColumnSpan(this.tabEspecialidades, 2);
            this.tabEspecialidades.Controls.Add(this.tabLista);
            this.tabEspecialidades.Controls.Add(this.tabFormulario);
            this.tabEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.tabEspecialidades.Name = "tabEspecialidades";
            this.tlEspecialidades.SetRowSpan(this.tabEspecialidades, 2);
            this.tabEspecialidades.SelectedIndex = 0;
            this.tabEspecialidades.Size = new System.Drawing.Size(791, 489);
            this.tabEspecialidades.TabIndex = 3;
            this.tabEspecialidades.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabEspecialidades_Selecting);
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.dgvEspecialidades);
            this.tabLista.Location = new System.Drawing.Point(4, 24);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabLista.Size = new System.Drawing.Size(783, 461);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Especialidades";
            this.tabLista.UseVisualStyleBackColor = true;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Editar,
            this.Borrar});
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersWidth = 62;
            this.dgvEspecialidades.RowTemplate.Height = 33;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(777, 455);
            this.dgvEspecialidades.TabIndex = 0;
            this.dgvEspecialidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialidades_CellClick);
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Descripcion.HeaderText = "Especialidad";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Editar";
            this.Editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 8;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.Width = 150;
            // 
            // Borrar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Borrar";
            this.Borrar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Borrar.HeaderText = "";
            this.Borrar.MinimumWidth = 8;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Borrar.Text = "Borrar";
            this.Borrar.Width = 150;
            // 
            // tabFormulario
            // 
            this.tabFormulario.Location = new System.Drawing.Point(4, 24);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormulario.Size = new System.Drawing.Size(783, 461);
            this.tabFormulario.TabIndex = 1;
            this.tabFormulario.Text = "Formulario";
            this.tabFormulario.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(635, 497);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 26);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.tsEspecialidades.Size = new System.Drawing.Size(116, 25);
            this.tsEspecialidades.TabIndex = 0;
            // 
            // tsNuevo
            // 
            this.tsNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsNuevo.Image")));
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(113, 22);
            this.tsNuevo.Text = "Nueva especialidad";
            this.tsNuevo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 550);
            this.Controls.Add(this.tscEspecialidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Especialidades_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlEspecialidades.ResumeLayout(false);
            this.tabEspecialidades.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.tsEspecialidades.ResumeLayout(false);
            this.tsEspecialidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.TableLayoutPanel tlEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.ToolStrip tsEspecialidades;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabEspecialidades;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.TabPage tabFormulario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Borrar;
    }
}