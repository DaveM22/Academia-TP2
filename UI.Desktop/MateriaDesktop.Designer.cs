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
            tlpMateria = new System.Windows.Forms.TableLayoutPanel();
            txtMateria = new UserControls.TextBoxConValidacion();
            nudHsTotales = new UserControls.NumericUpDownValidation();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nudHsSemanales = new UserControls.NumericUpDownValidation();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            tlpMateria.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMateria
            // 
            tlpMateria.ColumnCount = 4;
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMateria.Controls.Add(txtMateria, 2, 1);
            tlpMateria.Controls.Add(nudHsTotales, 2, 3);
            tlpMateria.Controls.Add(label2, 1, 3);
            tlpMateria.Controls.Add(label1, 1, 1);
            tlpMateria.Controls.Add(nudHsSemanales, 2, 5);
            tlpMateria.Controls.Add(btnGuardar, 2, 7);
            tlpMateria.Controls.Add(btnCancelar, 3, 7);
            tlpMateria.Controls.Add(label3, 1, 5);
            tlpMateria.Controls.Add(lblTitulo, 0, 0);
            tlpMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tlpMateria.Location = new System.Drawing.Point(0, 0);
            tlpMateria.Name = "tlpMateria";
            tlpMateria.RowCount = 8;
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tlpMateria.Size = new System.Drawing.Size(660, 254);
            tlpMateria.TabIndex = 0;
            // 
            // txtMateria
            // 
            txtMateria.Location = new System.Drawing.Point(265, 40);
            txtMateria.Name = "txtMateria";
            tlpMateria.SetRowSpan(txtMateria, 2);
            txtMateria.Size = new System.Drawing.Size(296, 52);
            txtMateria.TabIndex = 9;
            // 
            // nudHsTotales
            // 
            nudHsTotales.Location = new System.Drawing.Point(265, 98);
            nudHsTotales.Name = "nudHsTotales";
            tlpMateria.SetRowSpan(nudHsTotales, 2);
            nudHsTotales.Size = new System.Drawing.Size(296, 53);
            nudHsTotales.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(99, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Horas semanales:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(99, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Descripción:";
            // 
            // nudHsSemanales
            // 
            nudHsSemanales.Location = new System.Drawing.Point(265, 157);
            nudHsSemanales.Name = "nudHsSemanales";
            tlpMateria.SetRowSpan(nudHsSemanales, 2);
            nudHsSemanales.Size = new System.Drawing.Size(296, 52);
            nudHsSemanales.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Location = new System.Drawing.Point(449, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(112, 35);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Location = new System.Drawing.Point(567, 215);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(88, 35);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(99, 157);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Horas totales";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTitulo.AutoSize = true;
            tlpMateria.SetColumnSpan(lblTitulo, 4);
            lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(284, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(92, 37);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "label4";
            // 
            // MateriaDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.CornflowerBlue;
            ClientSize = new System.Drawing.Size(660, 254);
            ControlBox = false;
            Controls.Add(tlpMateria);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "MateriaDesktop";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Crear materia";
            Load += MateriaDesktop_Load;
            tlpMateria.ResumeLayout(false);
            tlpMateria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private UserControls.TextBoxConValidacion txtMateria;
        private UserControls.NumericUpDownValidation nudHsSemanales;
        private UserControls.NumericUpDownValidation nudHsTotales;
        private System.Windows.Forms.Label lblTitulo;
    }
}