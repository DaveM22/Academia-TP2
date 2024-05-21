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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteCursoDesktop));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblDocente = new System.Windows.Forms.Label();
            txtDocente = new System.Windows.Forms.TextBox();
            btnDocente = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            lblTitulo = new System.Windows.Forms.Label();
            txtCurso = new System.Windows.Forms.TextBox();
            lblCurso = new System.Windows.Forms.Label();
            btnCursos = new System.Windows.Forms.Button();
            lblCargo = new System.Windows.Forms.Label();
            cbCargos = new System.Windows.Forms.ComboBox();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblDocente, 1, 1);
            tableLayoutPanel1.Controls.Add(txtDocente, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDocente, 3, 1);
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 4);
            tableLayoutPanel1.Controls.Add(btnGuardar, 2, 4);
            tableLayoutPanel1.Controls.Add(lblTitulo, 2, 0);
            tableLayoutPanel1.Controls.Add(txtCurso, 2, 3);
            tableLayoutPanel1.Controls.Add(lblCurso, 1, 3);
            tableLayoutPanel1.Controls.Add(btnCursos, 3, 3);
            tableLayoutPanel1.Controls.Add(lblCargo, 1, 2);
            tableLayoutPanel1.Controls.Add(cbCargos, 2, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 442F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1025, 595);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // lblDocente
            // 
            lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDocente.AutoSize = true;
            lblDocente.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblDocente.Location = new System.Drawing.Point(280, 44);
            lblDocente.Name = "lblDocente";
            lblDocente.Size = new System.Drawing.Size(54, 15);
            lblDocente.TabIndex = 0;
            lblDocente.Text = "Docente:";
            // 
            // txtDocente
            // 
            txtDocente.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDocente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            txtDocente.Location = new System.Drawing.Point(340, 40);
            txtDocente.Name = "txtDocente";
            txtDocente.PlaceholderText = "Seleccione un docente";
            txtDocente.ReadOnly = true;
            txtDocente.Size = new System.Drawing.Size(263, 23);
            txtDocente.TabIndex = 1;
            txtDocente.TextChanged += txtDocente_TextChanged;
            // 
            // btnDocente
            // 
            btnDocente.Location = new System.Drawing.Point(609, 36);
            btnDocente.Name = "btnDocente";
            btnDocente.Size = new System.Drawing.Size(136, 30);
            btnDocente.TabIndex = 2;
            btnDocente.Text = "Seleccionar docente";
            btnDocente.UseVisualStyleBackColor = true;
            btnDocente.Click += btnDocente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(609, 133);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnGuardar.Location = new System.Drawing.Point(528, 133);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 32);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 3);
            lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblTitulo.Location = new System.Drawing.Point(340, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(352, 22);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Crear asignación de docente a curso";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurso
            // 
            txtCurso.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCurso.Location = new System.Drawing.Point(340, 103);
            txtCurso.Name = "txtCurso";
            txtCurso.ReadOnly = true;
            txtCurso.Size = new System.Drawing.Size(263, 23);
            txtCurso.TabIndex = 4;
            // 
            // lblCurso
            // 
            lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCurso.AutoSize = true;
            lblCurso.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblCurso.Location = new System.Drawing.Point(280, 107);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new System.Drawing.Size(54, 15);
            lblCurso.TabIndex = 5;
            lblCurso.Text = "Curso:";
            // 
            // btnCursos
            // 
            btnCursos.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnCursos.Location = new System.Drawing.Point(609, 102);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new System.Drawing.Size(136, 25);
            btnCursos.TabIndex = 3;
            btnCursos.Text = "Seleccionar curso";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // lblCargo
            // 
            lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblCargo.AutoSize = true;
            lblCargo.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblCargo.Location = new System.Drawing.Point(280, 77);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new System.Drawing.Size(54, 15);
            lblCargo.TabIndex = 10;
            lblCargo.Text = "Cargo:";
            // 
            // cbCargos
            // 
            cbCargos.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCargos.Location = new System.Drawing.Point(340, 73);
            cbCargos.Name = "cbCargos";
            cbCargos.Size = new System.Drawing.Size(263, 23);
            cbCargos.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "niDocenteCurso";
            notifyIcon1.Visible = true;
            // 
            // DocenteCursoDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1025, 595);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "DocenteCursoDesktop";
            Text = "DocenteCursoDesktop";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += DocenteCursoDesktop_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cbCargos;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}