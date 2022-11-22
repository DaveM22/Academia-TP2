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
            this.lblMateria = new System.Windows.Forms.Label();
            this.nudAnioCalendario = new System.Windows.Forms.NumericUpDown();
            this.lblAnioCalendario = new System.Windows.Forms.Label();
            this.nudCupo = new System.Windows.Forms.NumericUpDown();
            this.lblCupo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.btnPlan = new System.Windows.Forms.Button();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnMateria = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnComision = new System.Windows.Forms.Button();
            this.tlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlCursos
            // 
            this.tlCursos.ColumnCount = 5;
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 456F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCursos.Controls.Add(this.lblMateria, 1, 3);
            this.tlCursos.Controls.Add(this.nudAnioCalendario, 2, 4);
            this.tlCursos.Controls.Add(this.lblAnioCalendario, 1, 4);
            this.tlCursos.Controls.Add(this.nudCupo, 2, 5);
            this.tlCursos.Controls.Add(this.lblCupo, 1, 5);
            this.tlCursos.Controls.Add(this.btnCancelar, 3, 6);
            this.tlCursos.Controls.Add(this.btnAceptar, 2, 6);
            this.tlCursos.Controls.Add(this.lblComision, 1, 2);
            this.tlCursos.Controls.Add(this.lblPlan, 1, 1);
            this.tlCursos.Controls.Add(this.txtPlan, 2, 1);
            this.tlCursos.Controls.Add(this.btnPlan, 3, 1);
            this.tlCursos.Controls.Add(this.txtComision, 2, 2);
            this.tlCursos.Controls.Add(this.txtMateria, 2, 3);
            this.tlCursos.Controls.Add(this.btnMateria, 3, 3);
            this.tlCursos.Controls.Add(this.lblCurso, 1, 0);
            this.tlCursos.Controls.Add(this.btnComision, 3, 2);
            this.tlCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCursos.Location = new System.Drawing.Point(0, 0);
            this.tlCursos.Name = "tlCursos";
            this.tlCursos.RowCount = 7;
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlCursos.Size = new System.Drawing.Size(993, 386);
            this.tlCursos.TabIndex = 0;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(80, 203);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(71, 25);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia";
            // 
            // nudAnioCalendario
            // 
            this.nudAnioCalendario.Location = new System.Drawing.Point(235, 250);
            this.nudAnioCalendario.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudAnioCalendario.Name = "nudAnioCalendario";
            this.nudAnioCalendario.Size = new System.Drawing.Size(147, 31);
            this.nudAnioCalendario.TabIndex = 2;
            // 
            // lblAnioCalendario
            // 
            this.lblAnioCalendario.AutoSize = true;
            this.lblAnioCalendario.Location = new System.Drawing.Point(80, 247);
            this.lblAnioCalendario.Name = "lblAnioCalendario";
            this.lblAnioCalendario.Size = new System.Drawing.Size(134, 25);
            this.lblAnioCalendario.TabIndex = 6;
            this.lblAnioCalendario.Text = "Año Calendario";
            // 
            // nudCupo
            // 
            this.nudCupo.Location = new System.Drawing.Point(235, 292);
            this.nudCupo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudCupo.Name = "nudCupo";
            this.nudCupo.Size = new System.Drawing.Size(147, 31);
            this.nudCupo.TabIndex = 3;
            // 
            // lblCupo
            // 
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(80, 289);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(55, 25);
            this.lblCupo.TabIndex = 7;
            this.lblCupo.Text = "Cupo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.Location = new System.Drawing.Point(691, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.Green;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAceptar.Location = new System.Drawing.Point(573, 332);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 45);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(80, 151);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(87, 25);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "Comisión";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(80, 98);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(49, 25);
            this.lblPlan.TabIndex = 10;
            this.lblPlan.Text = "Plan:";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(235, 101);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(436, 31);
            this.txtPlan.TabIndex = 11;
            // 
            // btnPlan
            // 
            this.btnPlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlan.Location = new System.Drawing.Point(691, 101);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(222, 34);
            this.btnPlan.TabIndex = 12;
            this.btnPlan.Text = "Seleccionar Plan";
            this.btnPlan.UseVisualStyleBackColor = false;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(235, 154);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(436, 31);
            this.txtComision.TabIndex = 13;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(235, 206);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(436, 31);
            this.txtMateria.TabIndex = 14;
            // 
            // btnMateria
            // 
            this.btnMateria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMateria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMateria.Location = new System.Drawing.Point(691, 206);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(222, 34);
            this.btnMateria.TabIndex = 16;
            this.btnMateria.Text = "Seleccionar Materia";
            this.btnMateria.UseVisualStyleBackColor = false;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCurso.AutoSize = true;
            this.tlCursos.SetColumnSpan(this.lblCurso, 3);
            this.lblCurso.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurso.Location = new System.Drawing.Point(395, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(203, 37);
            this.lblCurso.TabIndex = 17;
            this.lblCurso.Text = "Crear Curso";
            // 
            // btnComision
            // 
            this.btnComision.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnComision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComision.Location = new System.Drawing.Point(691, 154);
            this.btnComision.Name = "btnComision";
            this.btnComision.Size = new System.Drawing.Size(222, 34);
            this.btnComision.TabIndex = 15;
            this.btnComision.Text = "Seleccionar comisión";
            this.btnComision.UseVisualStyleBackColor = false;
            this.btnComision.Click += new System.EventHandler(this.btnComision_Click);
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(993, 386);
            this.Controls.Add(this.tlCursos);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.Load += new System.EventHandler(this.CursoDesktop_Load);
            this.tlCursos.ResumeLayout(false);
            this.tlCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlCursos;
        private System.Windows.Forms.NumericUpDown nudAnioCalendario;
        private System.Windows.Forms.NumericUpDown nudCupo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblAnioCalendario;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnComision;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Label lblCurso;
    }
}