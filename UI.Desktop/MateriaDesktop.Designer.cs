namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tlpMateria = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.nudHsSemanales = new System.Windows.Forms.NumericUpDown();
            this.nudHsTotales = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsSemanales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMateria
            // 
            this.tlpMateria.ColumnCount = 4;
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.75926F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.24074F));
            this.tlpMateria.Controls.Add(this.label3, 1, 3);
            this.tlpMateria.Controls.Add(this.label2, 1, 2);
            this.tlpMateria.Controls.Add(this.label1, 1, 1);
            this.tlpMateria.Controls.Add(this.txtMateria, 2, 1);
            this.tlpMateria.Controls.Add(this.nudHsSemanales, 2, 2);
            this.tlpMateria.Controls.Add(this.nudHsTotales, 2, 3);
            this.tlpMateria.Controls.Add(this.btnGuardar, 2, 4);
            this.tlpMateria.Controls.Add(this.btnCancelar, 3, 4);
            this.tlpMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlpMateria.Location = new System.Drawing.Point(0, 0);
            this.tlpMateria.Name = "tlpMateria";
            this.tlpMateria.RowCount = 5;
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlpMateria.Size = new System.Drawing.Size(628, 244);
            this.tlpMateria.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas totales";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas semanales";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción";
            // 
            // txtMateria
            // 
            this.txtMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMateria.Location = new System.Drawing.Point(199, 24);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(304, 31);
            this.txtMateria.TabIndex = 4;
            // 
            // nudHsSemanales
            // 
            this.nudHsSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudHsSemanales.Location = new System.Drawing.Point(199, 80);
            this.nudHsSemanales.Name = "nudHsSemanales";
            this.nudHsSemanales.Size = new System.Drawing.Size(151, 31);
            this.nudHsSemanales.TabIndex = 5;
            // 
            // nudHsTotales
            // 
            this.nudHsTotales.Location = new System.Drawing.Point(199, 128);
            this.nudHsTotales.Name = "nudHsTotales";
            this.nudHsTotales.Size = new System.Drawing.Size(151, 31);
            this.nudHsTotales.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(391, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 47);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(509, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 47);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(628, 244);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMateria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MateriaDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear materia";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tlpMateria.ResumeLayout(false);
            this.tlpMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsSemanales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHsTotales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.NumericUpDown nudHsSemanales;
        private System.Windows.Forms.NumericUpDown nudHsTotales;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}