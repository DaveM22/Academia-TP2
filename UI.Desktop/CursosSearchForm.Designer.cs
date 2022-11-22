namespace UI.Desktop
{
    partial class CursosSearchForm
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
            this.tscCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlpCursos = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscCursos.ContentPanel.SuspendLayout();
            this.tscCursos.SuspendLayout();
            this.tlpCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // tscCursos
            // 
            // 
            // tscCursos.ContentPanel
            // 
            this.tscCursos.ContentPanel.Controls.Add(this.tlpCursos);
            this.tscCursos.ContentPanel.Size = new System.Drawing.Size(800, 442);
            this.tscCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscCursos.Location = new System.Drawing.Point(0, 0);
            this.tscCursos.Name = "tscCursos";
            this.tscCursos.Size = new System.Drawing.Size(800, 467);
            this.tscCursos.TabIndex = 0;
            this.tscCursos.Text = "toolStripContainer1";
            // 
            // tlpCursos
            // 
            this.tlpCursos.ColumnCount = 2;
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCursos.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlpCursos.Controls.Add(this.dgvCursos, 0, 0);
            this.tlpCursos.Controls.Add(this.btnCancelar, 1, 1);
            this.tlpCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpCursos.Name = "tlpCursos";
            this.tlpCursos.RowCount = 2;
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.94118F));
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.058824F));
            this.tlpCursos.Size = new System.Drawing.Size(800, 442);
            this.tlpCursos.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Location = new System.Drawing.Point(641, 413);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 26);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(722, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 26);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCurso,
            this.Comision,
            this.Materia,
            this.AnioCalendario});
            this.tlpCursos.SetColumnSpan(this.dgvCursos, 2);
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowTemplate.Height = 25;
            this.dgvCursos.Size = new System.Drawing.Size(794, 404);
            this.dgvCursos.TabIndex = 2;
            // 
            // IdCurso
            // 
            this.IdCurso.DataPropertyName = "Id";
            this.IdCurso.HeaderText = "IdCurso";
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.ReadOnly = true;
            this.IdCurso.Visible = false;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "ComisionDescripcion";
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "MateriaDescripcion";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.DataPropertyName = "AnioCalendario";
            this.AnioCalendario.HeaderText = "Año calendario";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // CursosSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.tscCursos);
            this.Name = "CursosSearchForm";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.CursosSearchForm_Load);
            this.tscCursos.ContentPanel.ResumeLayout(false);
            this.tscCursos.ResumeLayout(false);
            this.tscCursos.PerformLayout();
            this.tlpCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscCursos;
        private System.Windows.Forms.TableLayoutPanel tlpCursos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
    }
}