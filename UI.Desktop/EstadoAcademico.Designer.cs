namespace UI.Desktop
{
    partial class EstadoAcademico
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
            tscEstadoAcademico = new System.Windows.Forms.ToolStripContainer();
            tlpEstadoAcademico = new System.Windows.Forms.TableLayoutPanel();
            btnAgregar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            dgvEstadoAcademico = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblTitulo = new System.Windows.Forms.Label();
            tscEstadoAcademico.ContentPanel.SuspendLayout();
            tscEstadoAcademico.SuspendLayout();
            tlpEstadoAcademico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoAcademico).BeginInit();
            SuspendLayout();
            // 
            // tscEstadoAcademico
            // 
            // 
            // tscEstadoAcademico.ContentPanel
            // 
            tscEstadoAcademico.ContentPanel.Controls.Add(tlpEstadoAcademico);
            tscEstadoAcademico.ContentPanel.Size = new System.Drawing.Size(800, 403);
            tscEstadoAcademico.Dock = System.Windows.Forms.DockStyle.Fill;
            tscEstadoAcademico.Location = new System.Drawing.Point(0, 0);
            tscEstadoAcademico.Name = "tscEstadoAcademico";
            tscEstadoAcademico.Size = new System.Drawing.Size(800, 428);
            tscEstadoAcademico.TabIndex = 0;
            tscEstadoAcademico.Text = "toolStripContainer1";
            // 
            // tlpEstadoAcademico
            // 
            tlpEstadoAcademico.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpEstadoAcademico.ColumnCount = 2;
            tlpEstadoAcademico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpEstadoAcademico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpEstadoAcademico.Controls.Add(btnAgregar, 0, 2);
            tlpEstadoAcademico.Controls.Add(btnVolver, 1, 2);
            tlpEstadoAcademico.Controls.Add(dgvEstadoAcademico, 0, 1);
            tlpEstadoAcademico.Controls.Add(lblTitulo, 0, 0);
            tlpEstadoAcademico.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpEstadoAcademico.Location = new System.Drawing.Point(0, 0);
            tlpEstadoAcademico.Name = "tlpEstadoAcademico";
            tlpEstadoAcademico.RowCount = 3;
            tlpEstadoAcademico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            tlpEstadoAcademico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpEstadoAcademico.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpEstadoAcademico.Size = new System.Drawing.Size(800, 403);
            tlpEstadoAcademico.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAgregar.BackColor = System.Drawing.Color.Green;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnAgregar.Location = new System.Drawing.Point(579, 366);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(107, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Actualizar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.Firebrick;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnVolver.Location = new System.Drawing.Point(692, 366);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(105, 34);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver al inicio";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvEstadoAcademico
            // 
            dgvEstadoAcademico.AllowUserToAddRows = false;
            dgvEstadoAcademico.AllowUserToDeleteRows = false;
            dgvEstadoAcademico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstadoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoAcademico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Materia, Condicion, Nota });
            tlpEstadoAcademico.SetColumnSpan(dgvEstadoAcademico, 2);
            dgvEstadoAcademico.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEstadoAcademico.Location = new System.Drawing.Point(3, 40);
            dgvEstadoAcademico.MultiSelect = false;
            dgvEstadoAcademico.Name = "dgvEstadoAcademico";
            dgvEstadoAcademico.ReadOnly = true;
            dgvEstadoAcademico.RowTemplate.Height = 25;
            dgvEstadoAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEstadoAcademico.Size = new System.Drawing.Size(794, 320);
            dgvEstadoAcademico.TabIndex = 2;
            // 
            // Id
            // 
            Id.FillWeight = 5F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "Curso.Materia.Descripcion";
            Materia.FillWeight = 80F;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.DataPropertyName = "Condicion";
            Condicion.FillWeight = 10F;
            Condicion.HeaderText = "Condicion";
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.DataPropertyName = "Nota";
            Nota.FillWeight = 10F;
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tlpEstadoAcademico.SetColumnSpan(lblTitulo, 2);
            lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblTitulo.Location = new System.Drawing.Point(3, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(794, 32);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EstadoAcademico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 428);
            Controls.Add(tscEstadoAcademico);
            Name = "EstadoAcademico";
            Text = "EstadoAcademico";
            Load += EstadoAcademico_Load;
            tscEstadoAcademico.ContentPanel.ResumeLayout(false);
            tscEstadoAcademico.ResumeLayout(false);
            tscEstadoAcademico.PerformLayout();
            tlpEstadoAcademico.ResumeLayout(false);
            tlpEstadoAcademico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoAcademico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscEstadoAcademico;
        private System.Windows.Forms.TableLayoutPanel tlpEstadoAcademico;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvEstadoAcademico;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}