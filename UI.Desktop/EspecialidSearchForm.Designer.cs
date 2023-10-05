namespace UI.Desktop
{
    partial class EspecialidadSearchForm
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
            tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            tlpEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            dgvEspecialidades = new System.Windows.Forms.DataGridView();
            IdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnSeleccionar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            tscEspecialidades.ContentPanel.SuspendLayout();
            tscEspecialidades.SuspendLayout();
            tlpEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            tscEspecialidades.ContentPanel.Controls.Add(tlpEspecialidades);
            tscEspecialidades.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(731, 245);
            tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            tscEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            tscEspecialidades.Name = "tscEspecialidades";
            tscEspecialidades.Size = new System.Drawing.Size(731, 270);
            tscEspecialidades.TabIndex = 0;
            tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tlpEspecialidades
            // 
            tlpEspecialidades.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpEspecialidades.ColumnCount = 2;
            tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.75F));
            tlpEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25F));
            tlpEspecialidades.Controls.Add(dgvEspecialidades, 0, 0);
            tlpEspecialidades.Controls.Add(btnSeleccionar, 0, 1);
            tlpEspecialidades.Controls.Add(btnCancelar, 1, 1);
            tlpEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpEspecialidades.Location = new System.Drawing.Point(0, 0);
            tlpEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            tlpEspecialidades.Name = "tlpEspecialidades";
            tlpEspecialidades.RowCount = 2;
            tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpEspecialidades.Size = new System.Drawing.Size(731, 245);
            tlpEspecialidades.TabIndex = 0;
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdEspecialidad, Descripcion });
            tlpEspecialidades.SetColumnSpan(dgvEspecialidades, 2);
            dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEspecialidades.Location = new System.Drawing.Point(2, 2);
            dgvEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersWidth = 62;
            dgvEspecialidades.RowTemplate.Height = 33;
            dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new System.Drawing.Size(727, 210);
            dgvEspecialidades.TabIndex = 0;
            // 
            // IdEspecialidad
            // 
            IdEspecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            IdEspecialidad.DataPropertyName = "Id";
            IdEspecialidad.FillWeight = 10F;
            IdEspecialidad.Frozen = true;
            IdEspecialidad.HeaderText = "Id";
            IdEspecialidad.MinimumWidth = 8;
            IdEspecialidad.Name = "IdEspecialidad";
            IdEspecialidad.ReadOnly = true;
            IdEspecialidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            IdEspecialidad.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripción";
            Descripcion.MinimumWidth = 94;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSeleccionar.BackColor = System.Drawing.Color.Green;
            btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSeleccionar.Location = new System.Drawing.Point(546, 216);
            btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(78, 27);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(628, 216);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(76, 27);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // EspecialidadSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 270);
            Controls.Add(tscEspecialidades);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            Name = "EspecialidadSearchForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Seleccione una especialidad";
            Load += EspecialidSearchForm_Load;
            tscEspecialidades.ContentPanel.ResumeLayout(false);
            tscEspecialidades.ResumeLayout(false);
            tscEspecialidades.PerformLayout();
            tlpEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.TableLayoutPanel tlpEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}