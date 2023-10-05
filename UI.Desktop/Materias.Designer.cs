namespace UI.Desktop
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            tscMaterias = new System.Windows.Forms.ToolStripContainer();
            tlpMaterias = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            dgvMaterias = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            lblTituloMaterias = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tslCrearMateria = new System.Windows.Forms.ToolStripButton();
            tscMaterias.ContentPanel.SuspendLayout();
            tscMaterias.TopToolStripPanel.SuspendLayout();
            tscMaterias.SuspendLayout();
            tlpMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tscMaterias
            // 
            // 
            // tscMaterias.ContentPanel
            // 
            tscMaterias.ContentPanel.Controls.Add(tlpMaterias);
            tscMaterias.ContentPanel.Size = new System.Drawing.Size(1098, 416);
            tscMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            tscMaterias.Location = new System.Drawing.Point(0, 0);
            tscMaterias.Name = "tscMaterias";
            tscMaterias.Size = new System.Drawing.Size(1098, 450);
            tscMaterias.TabIndex = 0;
            tscMaterias.Text = "toolStripContainer1";
            // 
            // tscMaterias.TopToolStripPanel
            // 
            tscMaterias.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlpMaterias
            // 
            tlpMaterias.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpMaterias.ColumnCount = 2;
            tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpMaterias.Controls.Add(button1, 0, 2);
            tlpMaterias.Controls.Add(button2, 1, 2);
            tlpMaterias.Controls.Add(dgvMaterias, 0, 1);
            tlpMaterias.Controls.Add(lblTituloMaterias, 0, 0);
            tlpMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMaterias.Location = new System.Drawing.Point(0, 0);
            tlpMaterias.Name = "tlpMaterias";
            tlpMaterias.RowCount = 3;
            tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpMaterias.Size = new System.Drawing.Size(1098, 416);
            tlpMaterias.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            button1.Location = new System.Drawing.Point(872, 368);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 45);
            button1.TabIndex = 1;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Firebrick;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            button2.Location = new System.Drawing.Point(990, 368);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(105, 45);
            button2.TabIndex = 2;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Descripcion, HsSemanales, HsTotales, Editar, Eliminar });
            tlpMaterias.SetColumnSpan(dgvMaterias, 2);
            dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMaterias.Location = new System.Drawing.Point(3, 40);
            dgvMaterias.MultiSelect = false;
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersWidth = 62;
            dgvMaterias.RowTemplate.Height = 33;
            dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.Size = new System.Drawing.Size(1092, 322);
            dgvMaterias.TabIndex = 0;
            dgvMaterias.CellClick += dgvMaterias_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 150;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.FillWeight = 60F;
            Descripcion.HeaderText = "Materia";
            Descripcion.MinimumWidth = 8;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // HsSemanales
            // 
            HsSemanales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            HsSemanales.DataPropertyName = "HSSemanales";
            HsSemanales.FillWeight = 10F;
            HsSemanales.HeaderText = "Horas semanales";
            HsSemanales.MinimumWidth = 8;
            HsSemanales.Name = "HsSemanales";
            HsSemanales.ReadOnly = true;
            // 
            // HsTotales
            // 
            HsTotales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            HsTotales.DataPropertyName = "HSTotales";
            HsTotales.FillWeight = 10F;
            HsTotales.HeaderText = "Horas totales";
            HsTotales.MinimumWidth = 8;
            HsTotales.Name = "HsTotales";
            HsTotales.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Editar.FillWeight = 10F;
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Eliminar.FillWeight = 10F;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // lblTituloMaterias
            // 
            lblTituloMaterias.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTituloMaterias.AutoSize = true;
            tlpMaterias.SetColumnSpan(lblTituloMaterias, 2);
            lblTituloMaterias.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloMaterias.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblTituloMaterias.Location = new System.Drawing.Point(3, 0);
            lblTituloMaterias.Name = "lblTituloMaterias";
            lblTituloMaterias.Size = new System.Drawing.Size(1092, 37);
            lblTituloMaterias.TabIndex = 3;
            lblTituloMaterias.Text = "Materias del plan ";
            lblTituloMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslCrearMateria });
            toolStrip1.Location = new System.Drawing.Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(185, 34);
            toolStrip1.TabIndex = 0;
            // 
            // tslCrearMateria
            // 
            tslCrearMateria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tslCrearMateria.Image = (System.Drawing.Image)resources.GetObject("tslCrearMateria.Image");
            tslCrearMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            tslCrearMateria.Name = "tslCrearMateria";
            tslCrearMateria.Size = new System.Drawing.Size(121, 29);
            tslCrearMateria.Text = "Crear materia";
            tslCrearMateria.Click += tslCrearMateria_Click;
            // 
            // Materias
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1098, 450);
            Controls.Add(tscMaterias);
            Name = "Materias";
            Text = "Materias";
            Load += Materias_Load;
            tscMaterias.ContentPanel.ResumeLayout(false);
            tscMaterias.TopToolStripPanel.ResumeLayout(false);
            tscMaterias.TopToolStripPanel.PerformLayout();
            tscMaterias.ResumeLayout(false);
            tscMaterias.PerformLayout();
            tlpMaterias.ResumeLayout(false);
            tlpMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMaterias;
        private System.Windows.Forms.TableLayoutPanel tlpMaterias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblTituloMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsTotales;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.ToolStripButton tslCrearMateria;
    }
}