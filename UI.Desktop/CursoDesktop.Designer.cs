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
            tlCursos = new System.Windows.Forms.TableLayoutPanel();
            lblMateria = new System.Windows.Forms.Label();
            nudAnioCalendario = new System.Windows.Forms.NumericUpDown();
            lblAnioCalendario = new System.Windows.Forms.Label();
            nudCupo = new System.Windows.Forms.NumericUpDown();
            lblCupo = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnAceptar = new System.Windows.Forms.Button();
            lblComision = new System.Windows.Forms.Label();
            lblPlan = new System.Windows.Forms.Label();
            txtPlan = new System.Windows.Forms.TextBox();
            btnPlan = new System.Windows.Forms.Button();
            txtComision = new System.Windows.Forms.TextBox();
            txtMateria = new System.Windows.Forms.TextBox();
            btnMateria = new System.Windows.Forms.Button();
            lblCurso = new System.Windows.Forms.Label();
            btnComision = new System.Windows.Forms.Button();
            tlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAnioCalendario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            SuspendLayout();
            // 
            // tlCursos
            // 
            tlCursos.ColumnCount = 5;
            tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            tlCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlCursos.Controls.Add(lblMateria, 1, 3);
            tlCursos.Controls.Add(nudAnioCalendario, 2, 4);
            tlCursos.Controls.Add(lblAnioCalendario, 1, 4);
            tlCursos.Controls.Add(nudCupo, 2, 5);
            tlCursos.Controls.Add(lblCupo, 1, 5);
            tlCursos.Controls.Add(btnCancelar, 3, 6);
            tlCursos.Controls.Add(btnAceptar, 2, 6);
            tlCursos.Controls.Add(lblComision, 1, 2);
            tlCursos.Controls.Add(lblPlan, 1, 1);
            tlCursos.Controls.Add(txtPlan, 2, 1);
            tlCursos.Controls.Add(btnPlan, 3, 1);
            tlCursos.Controls.Add(txtComision, 2, 2);
            tlCursos.Controls.Add(txtMateria, 2, 3);
            tlCursos.Controls.Add(btnMateria, 3, 3);
            tlCursos.Controls.Add(lblCurso, 1, 0);
            tlCursos.Controls.Add(btnComision, 3, 2);
            tlCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlCursos.Location = new System.Drawing.Point(0, 0);
            tlCursos.Margin = new System.Windows.Forms.Padding(2);
            tlCursos.Name = "tlCursos";
            tlCursos.RowCount = 7;
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tlCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            tlCursos.Size = new System.Drawing.Size(695, 360);
            tlCursos.TabIndex = 0;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(58, 126);
            lblMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(47, 15);
            lblMateria.TabIndex = 4;
            lblMateria.Text = "Materia";
            // 
            // nudAnioCalendario
            // 
            nudAnioCalendario.Location = new System.Drawing.Point(166, 175);
            nudAnioCalendario.Margin = new System.Windows.Forms.Padding(2);
            nudAnioCalendario.Maximum = new decimal(new int[] { 2999, 0, 0, 0 });
            nudAnioCalendario.Name = "nudAnioCalendario";
            nudAnioCalendario.Size = new System.Drawing.Size(103, 23);
            nudAnioCalendario.TabIndex = 2;
            // 
            // lblAnioCalendario
            // 
            lblAnioCalendario.AutoSize = true;
            lblAnioCalendario.Location = new System.Drawing.Point(58, 173);
            lblAnioCalendario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAnioCalendario.Name = "lblAnioCalendario";
            lblAnioCalendario.Size = new System.Drawing.Size(89, 15);
            lblAnioCalendario.TabIndex = 6;
            lblAnioCalendario.Text = "Año Calendario";
            // 
            // nudCupo
            // 
            nudCupo.Location = new System.Drawing.Point(166, 221);
            nudCupo.Margin = new System.Windows.Forms.Padding(2);
            nudCupo.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new System.Drawing.Size(103, 23);
            nudCupo.TabIndex = 3;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new System.Drawing.Point(58, 219);
            lblCupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new System.Drawing.Size(36, 15);
            lblCupo.TabIndex = 7;
            lblCupo.Text = "Cupo";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(485, 269);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(78, 27);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAceptar.BackColor = System.Drawing.Color.Green;
            btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAceptar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnAceptar.Location = new System.Drawing.Point(403, 269);
            btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(78, 27);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(58, 79);
            lblComision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(58, 15);
            lblComision.TabIndex = 5;
            lblComision.Text = "Comisión";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(58, 32);
            lblPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(33, 15);
            lblPlan.TabIndex = 10;
            lblPlan.Text = "Plan:";
            // 
            // txtPlan
            // 
            txtPlan.Location = new System.Drawing.Point(166, 34);
            txtPlan.Margin = new System.Windows.Forms.Padding(2);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new System.Drawing.Size(306, 23);
            txtPlan.TabIndex = 11;
            // 
            // btnPlan
            // 
            btnPlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btnPlan.ForeColor = System.Drawing.SystemColors.ControlText;
            btnPlan.Location = new System.Drawing.Point(485, 34);
            btnPlan.Margin = new System.Windows.Forms.Padding(2);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new System.Drawing.Size(151, 23);
            btnPlan.TabIndex = 12;
            btnPlan.Text = "Seleccionar Plan";
            btnPlan.UseVisualStyleBackColor = false;
            btnPlan.Click += btnPlan_Click;
            // 
            // txtComision
            // 
            txtComision.Location = new System.Drawing.Point(166, 81);
            txtComision.Margin = new System.Windows.Forms.Padding(2);
            txtComision.Name = "txtComision";
            txtComision.Size = new System.Drawing.Size(306, 23);
            txtComision.TabIndex = 13;
            // 
            // txtMateria
            // 
            txtMateria.Location = new System.Drawing.Point(166, 128);
            txtMateria.Margin = new System.Windows.Forms.Padding(2);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new System.Drawing.Size(306, 23);
            txtMateria.TabIndex = 14;
            // 
            // btnMateria
            // 
            btnMateria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btnMateria.ForeColor = System.Drawing.SystemColors.ControlText;
            btnMateria.Location = new System.Drawing.Point(485, 128);
            btnMateria.Margin = new System.Windows.Forms.Padding(2);
            btnMateria.Name = "btnMateria";
            btnMateria.Size = new System.Drawing.Size(151, 23);
            btnMateria.TabIndex = 16;
            btnMateria.Text = "Seleccionar Materia";
            btnMateria.UseVisualStyleBackColor = false;
            btnMateria.Click += btnMateria_Click;
            // 
            // lblCurso
            // 
            lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblCurso.AutoSize = true;
            tlCursos.SetColumnSpan(lblCurso, 3);
            lblCurso.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCurso.Location = new System.Drawing.Point(279, 0);
            lblCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new System.Drawing.Size(136, 26);
            lblCurso.TabIndex = 17;
            lblCurso.Text = "Crear Curso";
            // 
            // btnComision
            // 
            btnComision.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btnComision.ForeColor = System.Drawing.SystemColors.ControlText;
            btnComision.Location = new System.Drawing.Point(485, 81);
            btnComision.Margin = new System.Windows.Forms.Padding(2);
            btnComision.Name = "btnComision";
            btnComision.Size = new System.Drawing.Size(151, 23);
            btnComision.TabIndex = 15;
            btnComision.Text = "Seleccionar comisión";
            btnComision.UseVisualStyleBackColor = false;
            btnComision.Click += btnComision_Click;
            // 
            // CursoDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.CornflowerBlue;
            ClientSize = new System.Drawing.Size(695, 360);
            Controls.Add(tlCursos);
            ForeColor = System.Drawing.SystemColors.HighlightText;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "CursoDesktop";
            Text = "CursoDesktop";
            Load += CursoDesktop_Load;
            tlCursos.ResumeLayout(false);
            tlCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAnioCalendario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
            ResumeLayout(false);
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