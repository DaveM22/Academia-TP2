namespace UI.Desktop
{
    partial class MateriaSearchForm
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
            this.tscMaterias = new System.Windows.Forms.ToolStripContainer();
            this.tlpMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscMaterias.ContentPanel.SuspendLayout();
            this.tscMaterias.SuspendLayout();
            this.tlpMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // tscMaterias
            // 
            // 
            // tscMaterias.ContentPanel
            // 
            this.tscMaterias.ContentPanel.Controls.Add(this.tlpMaterias);
            this.tscMaterias.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tscMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMaterias.Location = new System.Drawing.Point(0, 0);
            this.tscMaterias.Name = "tscMaterias";
            this.tscMaterias.Size = new System.Drawing.Size(800, 450);
            this.tscMaterias.TabIndex = 0;
            this.tscMaterias.Text = "toolStripContainer1";
            // 
            // tlpMaterias
            // 
            this.tlpMaterias.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlpMaterias.ColumnCount = 2;
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.125F));
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.875F));
            this.tlpMaterias.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlpMaterias.Controls.Add(this.btnCancelar, 1, 1);
            this.tlpMaterias.Controls.Add(this.dgvMaterias, 0, 0);
            this.tlpMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpMaterias.Name = "tlpMaterias";
            this.tlpMaterias.RowCount = 2;
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaterias.Size = new System.Drawing.Size(800, 425);
            this.tlpMaterias.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.Green;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeleccionar.Location = new System.Drawing.Point(566, 380);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 42);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Location = new System.Drawing.Point(684, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Materia});
            this.tlpMaterias.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 62;
            this.dgvMaterias.RowTemplate.Height = 33;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(794, 371);
            this.dgvMaterias.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Descripcion";
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 8;
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // MateriaSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscMaterias);
            this.Name = "MateriaSearchForm";
            this.Text = "MateriaSearchForm";
            this.Load += new System.EventHandler(this.MateriaSearchForm_Load);
            this.tscMaterias.ContentPanel.ResumeLayout(false);
            this.tscMaterias.ResumeLayout(false);
            this.tscMaterias.PerformLayout();
            this.tlpMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMaterias;
        private System.Windows.Forms.TableLayoutPanel tlpMaterias;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
    }
}