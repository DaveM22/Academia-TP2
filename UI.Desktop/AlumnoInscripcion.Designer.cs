namespace UI.Desktop
{
    partial class AlumnoInscripcion
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
            tlpIncripcion = new System.Windows.Forms.TableLayoutPanel();
            lblAlumno = new System.Windows.Forms.Label();
            txtAlumno = new UserControls.TextBoxConValidacion();
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lblTitulo = new System.Windows.Forms.Label();
            btnSeleccionarAlumno = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            tlpIncripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tlpIncripcion
            // 
            tlpIncripcion.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpIncripcion.ColumnCount = 5;
            tlpIncripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpIncripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            tlpIncripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            tlpIncripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            tlpIncripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpIncripcion.Controls.Add(lblAlumno, 1, 2);
            tlpIncripcion.Controls.Add(txtAlumno, 2, 2);
            tlpIncripcion.Controls.Add(label1, 1, 3);
            tlpIncripcion.Controls.Add(dataGridView1, 1, 4);
            tlpIncripcion.Controls.Add(lblTitulo, 2, 0);
            tlpIncripcion.Controls.Add(btnCancelar, 3, 5);
            tlpIncripcion.Controls.Add(btnSeleccionarAlumno, 3, 3);
            tlpIncripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpIncripcion.Location = new System.Drawing.Point(0, 0);
            tlpIncripcion.Name = "tlpIncripcion";
            tlpIncripcion.RowCount = 6;
            tlpIncripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpIncripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tlpIncripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            tlpIncripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tlpIncripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            tlpIncripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpIncripcion.Size = new System.Drawing.Size(812, 561);
            tlpIncripcion.TabIndex = 0;
            // 
            // lblAlumno
            // 
            lblAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblAlumno.AutoSize = true;
            lblAlumno.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblAlumno.Location = new System.Drawing.Point(128, 64);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new System.Drawing.Size(53, 15);
            lblAlumno.TabIndex = 1;
            lblAlumno.Text = "Alumno:";
            // 
            // txtAlumno
            // 
            txtAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtAlumno.Location = new System.Drawing.Point(254, 59);
            txtAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new System.Drawing.Size(254, 25);
            txtAlumno.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            label1.Location = new System.Drawing.Point(128, 99);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 15);
            label1.TabIndex = 4;
            label1.Text = "Cursos a inscribir:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpIncripcion.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(128, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(555, 365);
            dataGridView1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tlpIncripcion.SetColumnSpan(lblTitulo, 5);
            lblTitulo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblTitulo.Location = new System.Drawing.Point(3, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(806, 22);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Inscripción de alumno";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionarAlumno
            // 
            btnSeleccionarAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSeleccionarAlumno.Location = new System.Drawing.Point(513, 92);
            btnSeleccionarAlumno.Name = "btnSeleccionarAlumno";
            btnSeleccionarAlumno.Size = new System.Drawing.Size(170, 28);
            btnSeleccionarAlumno.TabIndex = 3;
            btnSeleccionarAlumno.Text = "Seleccionar alumno";
            btnSeleccionarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(596, 499);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(87, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AlumnoInscripcion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(812, 561);
            Controls.Add(tlpIncripcion);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "AlumnoInscripcion";
            Text = "AlumnoInscripcion";
            tlpIncripcion.ResumeLayout(false);
            tlpIncripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpIncripcion;
        private System.Windows.Forms.Label lblAlumno;
        private UserControls.TextBoxConValidacion txtAlumno;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSeleccionarAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelar;
    }
}