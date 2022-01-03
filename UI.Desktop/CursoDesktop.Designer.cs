namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlCursos = new System.Windows.Forms.TableLayoutPanel();
            this.nudCupo = new System.Windows.Forms.NumericUpDown();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.cmbComision = new System.Windows.Forms.ComboBox();
            this.nudAnioCalendario = new System.Windows.Forms.NumericUpDown();
            this.tlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // tlCursos
            // 
            this.tlCursos.ColumnCount = 3;
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCursos.Controls.Add(this.nudCupo, 1, 3);
            this.tlCursos.Controls.Add(this.lblAnioCalendario, 0, 2);
            this.tlCursos.Controls.Add(this.lblCupo, 0, 3);
            this.tlCursos.Controls.Add(this.btnAceptar, 1, 4);
            this.tlCursos.Controls.Add(this.btnCancelar, 2, 4);
            this.tlCursos.Controls.Add(this.cmbMateria, 1, 1);
            this.tlCursos.Controls.Add(this.lblMateria, 0, 1);
            this.tlCursos.Controls.Add(this.lblComision, 0, 0);
            this.tlCursos.Controls.Add(this.cmbComision, 1, 0);
            this.tlCursos.Controls.Add(this.nudAnioCalendario, 1, 2);
            this.tlCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCursos.Location = new System.Drawing.Point(0, 0);
            this.tlCursos.Name = "tlCursos";
            this.tlCursos.RowCount = 5;
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlCursos.Size = new System.Drawing.Size(529, 246);
            this.tlCursos.TabIndex = 0;
            // 
            // nudCupo
            // 
            this.nudCupo.Location = new System.Drawing.Point(125, 156);
            this.nudCupo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCupo.Name = "nudCupo";
            this.nudCupo.Size = new System.Drawing.Size(147, 31);
            this.nudCupo.TabIndex = 3;
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(3, 102);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(96, 50);
            this.lblAnioCalendario.TabIndex = 6;
            this.lblAnioCalendario.Text = "Año Calendario";
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(3, 153);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(55, 25);
            this.lblCupo.TabIndex = 7;
            this.lblCupo.Text = "Cupo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(292, 207);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(410, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbMateria
            // 
            this.tlCursos.SetColumnSpan(this.cmbMateria, 2);
            this.cmbMateria.DisplayMember = "Descripcion";
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(125, 54);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(397, 33);
            this.cmbMateria.TabIndex = 0;
            this.cmbMateria.Text = "Seleccione una materia";
            this.cmbMateria.ValueMember = "Id";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(3, 51);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(71, 25);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(3, 0);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(87, 25);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "Comisión";
            // 
            // cmbComision
            // 
            this.tlCursos.SetColumnSpan(this.cmbComision, 2);
            this.cmbComision.DisplayMember = "Descripcion";
            this.cmbComision.FormattingEnabled = true;
            this.cmbComision.Location = new System.Drawing.Point(125, 3);
            this.cmbComision.Name = "cmbComision";
            this.cmbComision.Size = new System.Drawing.Size(397, 33);
            this.cmbComision.TabIndex = 1;
            this.cmbComision.Text = "Seleccione una comision";
            this.cmbComision.ValueMember = "Id";
            this.cmbComision.SelectedIndexChanged += new System.EventHandler(this.cmbComision_SelectedIndexChanged);
            // 
            // nudAnioCalendario
            // 
            this.nudAnioCalendario.Location = new System.Drawing.Point(125, 105);
            this.nudAnioCalendario.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudAnioCalendario.Name = "nudAnioCalendario";
            this.nudAnioCalendario.Size = new System.Drawing.Size(147, 31);
            this.nudAnioCalendario.TabIndex = 2;
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 246);
            this.Controls.Add(this.tlCursos);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.Load += new System.EventHandler(this.CursoDesktop_Load);
            this.tlCursos.ResumeLayout(false);
            this.tlCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCalendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlCursos;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbComision;
        private System.Windows.Forms.NumericUpDown nudAnioCalendario;
        private System.Windows.Forms.NumericUpDown nudCupo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}