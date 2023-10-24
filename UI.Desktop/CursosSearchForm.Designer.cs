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
            tscCursos = new System.Windows.Forms.ToolStripContainer();
            tlpCursos = new System.Windows.Forms.TableLayoutPanel();
            btnSeleccionar = new System.Windows.Forms.Button();
            dgvCursos = new System.Windows.Forms.DataGridView();
            btnCancelar = new System.Windows.Forms.Button();
            IdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tscCursos.ContentPanel.SuspendLayout();
            tscCursos.SuspendLayout();
            tlpCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // tscCursos
            // 
            // 
            // tscCursos.ContentPanel
            // 
            tscCursos.ContentPanel.Controls.Add(tlpCursos);
            tscCursos.ContentPanel.Size = new System.Drawing.Size(800, 442);
            tscCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            tscCursos.Location = new System.Drawing.Point(0, 0);
            tscCursos.Name = "tscCursos";
            tscCursos.Size = new System.Drawing.Size(800, 467);
            tscCursos.TabIndex = 0;
            tscCursos.Text = "toolStripContainer1";
            // 
            // tlpCursos
            // 
            tlpCursos.ColumnCount = 2;
            tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpCursos.Controls.Add(btnSeleccionar, 0, 1);
            tlpCursos.Controls.Add(dgvCursos, 0, 0);
            tlpCursos.Controls.Add(btnCancelar, 1, 1);
            tlpCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpCursos.Location = new System.Drawing.Point(0, 0);
            tlpCursos.Name = "tlpCursos";
            tlpCursos.RowCount = 2;
            tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.94118F));
            tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.058824F));
            tlpCursos.Size = new System.Drawing.Size(800, 442);
            tlpCursos.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSeleccionar.BackColor = System.Drawing.Color.Green;
            btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSeleccionar.Location = new System.Drawing.Point(631, 413);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(85, 26);
            btnSeleccionar.TabIndex = 0;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdCurso, Comision, Materia, AnioCalendario, Cupo });
            tlpCursos.SetColumnSpan(dgvCursos, 2);
            dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCursos.Location = new System.Drawing.Point(3, 3);
            dgvCursos.MultiSelect = false;
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.Size = new System.Drawing.Size(794, 404);
            dgvCursos.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(722, 413);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 26);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // IdCurso
            // 
            IdCurso.DataPropertyName = "Id";
            IdCurso.HeaderText = "IdCurso";
            IdCurso.Name = "IdCurso";
            IdCurso.ReadOnly = true;
            IdCurso.Visible = false;
            // 
            // Comision
            // 
            Comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Comision.DataPropertyName = "ComisionDescripcion";
            Comision.FillWeight = 40F;
            Comision.HeaderText = "Comision";
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // Materia
            // 
            Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Materia.DataPropertyName = "MateriaDescripcion";
            Materia.FillWeight = 40F;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            AnioCalendario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            AnioCalendario.DataPropertyName = "AnioCalendario";
            AnioCalendario.FillWeight = 10F;
            AnioCalendario.HeaderText = "Año calendario";
            AnioCalendario.Name = "AnioCalendario";
            AnioCalendario.ReadOnly = true;
            // 
            // Cupo
            // 
            Cupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Cupo.FillWeight = 10F;
            Cupo.HeaderText = "Cupo";
            Cupo.Name = "Cupo";
            Cupo.ReadOnly = true;
            // 
            // CursosSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 467);
            Controls.Add(tscCursos);
            MaximizeBox = false;
            Name = "CursosSearchForm";
            Text = "Cursos";
            Load += CursosSearchForm_Load;
            tscCursos.ContentPanel.ResumeLayout(false);
            tscCursos.ResumeLayout(false);
            tscCursos.PerformLayout();
            tlpCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
    }
}