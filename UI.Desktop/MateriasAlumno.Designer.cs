namespace UI.Desktop
{
    partial class MateriasAlumno
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
            tlpAlumnosMaterias = new System.Windows.Forms.TableLayoutPanel();
            dgvMaterias = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cursos = new System.Windows.Forms.DataGridViewButtonColumn();
            btnActualizar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            tlpAlumnosMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // tlpAlumnosMaterias
            // 
            tlpAlumnosMaterias.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpAlumnosMaterias.ColumnCount = 2;
            tlpAlumnosMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpAlumnosMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpAlumnosMaterias.Controls.Add(dgvMaterias, 0, 0);
            tlpAlumnosMaterias.Controls.Add(btnActualizar, 0, 1);
            tlpAlumnosMaterias.Controls.Add(btnCancelar, 1, 1);
            tlpAlumnosMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpAlumnosMaterias.Location = new System.Drawing.Point(0, 0);
            tlpAlumnosMaterias.Name = "tlpAlumnosMaterias";
            tlpAlumnosMaterias.RowCount = 2;
            tlpAlumnosMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpAlumnosMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpAlumnosMaterias.Size = new System.Drawing.Size(800, 450);
            tlpAlumnosMaterias.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Materia, Cursos });
            tlpAlumnosMaterias.SetColumnSpan(dgvMaterias, 2);
            dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMaterias.Location = new System.Drawing.Point(3, 3);
            dgvMaterias.MultiSelect = false;
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.Size = new System.Drawing.Size(794, 403);
            dgvMaterias.TabIndex = 0;
            dgvMaterias.CellClick += dgvMaterias_CellClick;
            // 
            // Id
            // 
            Id.FillWeight = 10F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Materia
            // 
            Materia.DataPropertyName = "Descripcion";
            Materia.FillWeight = 70F;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Cursos
            // 
            Cursos.FillWeight = 10F;
            Cursos.HeaderText = "";
            Cursos.Name = "Cursos";
            Cursos.ReadOnly = true;
            Cursos.Text = "Cursos";
            Cursos.UseColumnTextForButtonValue = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(594, 412);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(96, 35);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(696, 412);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(101, 35);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // MateriasAlumno
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(tlpAlumnosMaterias);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "MateriasAlumno";
            Text = "MateriasAlumno";
            Load += MateriasAlumno_Load;
            tlpAlumnosMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAlumnosMaterias;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewButtonColumn Cursos;
    }
}