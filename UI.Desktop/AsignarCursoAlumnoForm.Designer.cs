namespace UI.Desktop
{
    partial class AsignarCursoAlumnoForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarCursoAlumnoForm));
            tlpAsignarCurso = new System.Windows.Forms.TableLayoutPanel();
            lblAlumno = new System.Windows.Forms.Label();
            txtAlumno = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            textBoxConValidacion1 = new UserControls.TextBoxConValidacion();
            btnSeleccionarCurso = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cbCondicion = new System.Windows.Forms.ComboBox();
            btnCrear = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            tlpAsignarCurso.SuspendLayout();
            SuspendLayout();
            // 
            // tlpAsignarCurso
            // 
            tlpAsignarCurso.ColumnCount = 6;
            tlpAsignarCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpAsignarCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            tlpAsignarCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            tlpAsignarCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            tlpAsignarCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpAsignarCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpAsignarCurso.Controls.Add(lblAlumno, 1, 1);
            tlpAsignarCurso.Controls.Add(txtAlumno, 2, 1);
            tlpAsignarCurso.Controls.Add(label1, 1, 2);
            tlpAsignarCurso.Controls.Add(textBoxConValidacion1, 2, 2);
            tlpAsignarCurso.Controls.Add(btnSeleccionarCurso, 3, 2);
            tlpAsignarCurso.Controls.Add(label2, 1, 3);
            tlpAsignarCurso.Controls.Add(cbCondicion, 2, 3);
            tlpAsignarCurso.Controls.Add(btnCrear, 2, 4);
            tlpAsignarCurso.Controls.Add(btnCancelar, 3, 4);
            tlpAsignarCurso.Controls.Add(label3, 1, 0);
            tlpAsignarCurso.Controls.Add(textBox1, 2, 0);
            tlpAsignarCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpAsignarCurso.Location = new System.Drawing.Point(0, 0);
            tlpAsignarCurso.Name = "tlpAsignarCurso";
            tlpAsignarCurso.RowCount = 5;
            tlpAsignarCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tlpAsignarCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            tlpAsignarCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpAsignarCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlpAsignarCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            tlpAsignarCurso.Size = new System.Drawing.Size(800, 450);
            tlpAsignarCurso.TabIndex = 0;
            // 
            // lblAlumno
            // 
            lblAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new System.Drawing.Point(174, 47);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new System.Drawing.Size(77, 15);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "Alumno:";
            // 
            // txtAlumno
            // 
            txtAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAlumno.Enabled = false;
            txtAlumno.Location = new System.Drawing.Point(257, 43);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new System.Drawing.Size(226, 23);
            txtAlumno.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(174, 89);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Curso:";
            // 
            // textBoxConValidacion1
            // 
            textBoxConValidacion1.Location = new System.Drawing.Point(256, 75);
            textBoxConValidacion1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            textBoxConValidacion1.Name = "textBoxConValidacion1";
            textBoxConValidacion1.Size = new System.Drawing.Size(228, 43);
            textBoxConValidacion1.TabIndex = 3;
            // 
            // btnSeleccionarCurso
            // 
            btnSeleccionarCurso.Location = new System.Drawing.Point(489, 76);
            btnSeleccionarCurso.Name = "btnSeleccionarCurso";
            btnSeleccionarCurso.Size = new System.Drawing.Size(137, 31);
            btnSeleccionarCurso.TabIndex = 4;
            btnSeleccionarCurso.Text = "Seleccionar curso";
            btnSeleccionarCurso.UseVisualStyleBackColor = true;
            btnSeleccionarCurso.Click += btnSeleccionarCurso_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(174, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Condicion:";
            // 
            // cbCondicion
            // 
            cbCondicion.FormattingEnabled = true;
            cbCondicion.Location = new System.Drawing.Point(257, 123);
            cbCondicion.Name = "cbCondicion";
            cbCondicion.Size = new System.Drawing.Size(226, 23);
            cbCondicion.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCrear.BackColor = System.Drawing.Color.Green;
            btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCrear.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCrear.Location = new System.Drawing.Point(408, 170);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(75, 27);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(489, 170);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(174, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 15);
            label3.TabIndex = 9;
            label3.Text = "Plan:";
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Enabled = false;
            textBox1.Location = new System.Drawing.Point(257, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(226, 23);
            textBox1.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // AsignarCursoAlumnoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tlpAsignarCurso);
            Name = "AsignarCursoAlumnoForm";
            Text = "AsignarCursoAlumnoForm";
            Load += AsignarCursoAlumnoForm_Load;
            tlpAsignarCurso.ResumeLayout(false);
            tlpAsignarCurso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAsignarCurso;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label label1;
        private UserControls.TextBoxConValidacion textBoxConValidacion1;
        private System.Windows.Forms.Button btnSeleccionarCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}