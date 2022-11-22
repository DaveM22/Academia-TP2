namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDocente = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.btnDocente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnCursos = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cbCargos = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDocente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDocente, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDocente, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCurso, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCursos, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCargo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbCargos, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 720F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1464, 992);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDocente
            // 
            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(399, 55);
            this.lblDocente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(82, 25);
            this.lblDocente.TabIndex = 0;
            this.lblDocente.Text = "Docente:";
            // 
            // txtDocente
            // 
            this.txtDocente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDocente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDocente.Location = new System.Drawing.Point(489, 60);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.PlaceholderText = "Seleccione un docente";
            this.txtDocente.ReadOnly = true;
            this.txtDocente.Size = new System.Drawing.Size(374, 31);
            this.txtDocente.TabIndex = 1;
            this.txtDocente.TextChanged += new System.EventHandler(this.txtDocente_TextChanged);
            // 
            // btnDocente
            // 
            this.btnDocente.Location = new System.Drawing.Point(871, 60);
            this.btnDocente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(194, 50);
            this.btnDocente.TabIndex = 2;
            this.btnDocente.Text = "Seleccionar docente";
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.btnDocente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(871, 239);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 53);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(756, 239);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 53);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitulo, 3);
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(489, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(523, 34);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Crear asignación de docente a curso";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(489, 182);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 31);
            this.textBox2.TabIndex = 4;
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(409, 177);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(62, 25);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso:";
            // 
            // btnCursos
            // 
            this.btnCursos.Location = new System.Drawing.Point(871, 182);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(194, 47);
            this.btnCursos.TabIndex = 3;
            this.btnCursos.Text = "Seleccionar curso";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(408, 115);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(64, 25);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "Cargo:";
            // 
            // cbCargos
            // 
            this.cbCargos.FormattingEnabled = true;
            this.cbCargos.Location = new System.Drawing.Point(489, 120);
            this.cbCargos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCargos.Name = "cbCargos";
            this.cbCargos.Size = new System.Drawing.Size(374, 33);
            this.cbCargos.TabIndex = 11;
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 992);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DocenteCursoDesktop";
            this.Text = "DocenteCursoDesktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DocenteCursoDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbCargos;
    }
}