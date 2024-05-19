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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaDesktop));
            tlpMateria = new System.Windows.Forms.TableLayoutPanel();
            nudHsTotales = new UserControls.NumericUpDownValidation();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nudHsSemanales = new UserControls.NumericUpDownValidation();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            txtMateria = new UserControls.TextBoxConValidacion();
            niAlerta = new System.Windows.Forms.NotifyIcon(components);
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            tlpMateria.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMateria
            // 
            tlpMateria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tlpMateria.ColumnCount = 4;
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
            tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpMateria.Controls.Add(nudHsTotales, 2, 2);
            tlpMateria.Controls.Add(label2, 1, 2);
            tlpMateria.Controls.Add(label1, 1, 1);
            tlpMateria.Controls.Add(nudHsSemanales, 2, 3);
            tlpMateria.Controls.Add(btnGuardar, 2, 4);
            tlpMateria.Controls.Add(btnCancelar, 3, 4);
            tlpMateria.Controls.Add(label3, 1, 3);
            tlpMateria.Controls.Add(lblTitulo, 0, 0);
            tlpMateria.Controls.Add(txtMateria, 2, 1);
            tlpMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            tlpMateria.Location = new System.Drawing.Point(0, 0);
            tlpMateria.Margin = new System.Windows.Forms.Padding(2);
            tlpMateria.Name = "tlpMateria";
            tlpMateria.RowCount = 5;
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpMateria.Size = new System.Drawing.Size(715, 386);
            tlpMateria.TabIndex = 0;
            tlpMateria.Paint += tlpMateria_Paint;
            // 
            // nudHsTotales
            // 
            nudHsTotales.Location = new System.Drawing.Point(277, 132);
            nudHsTotales.Margin = new System.Windows.Forms.Padding(1);
            nudHsTotales.Name = "nudHsTotales";
            nudHsTotales.Size = new System.Drawing.Size(276, 53);
            nudHsTotales.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(162, 134);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 51);
            label2.TabIndex = 1;
            label2.Text = "Horas semanales:";
            label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(195, 80);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 45);
            label1.TabIndex = 0;
            label1.Text = "Descripción:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudHsSemanales
            // 
            nudHsSemanales.Location = new System.Drawing.Point(277, 190);
            nudHsSemanales.Margin = new System.Windows.Forms.Padding(1);
            nudHsSemanales.Name = "nudHsSemanales";
            nudHsSemanales.Size = new System.Drawing.Size(276, 49);
            nudHsSemanales.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Location = new System.Drawing.Point(475, 244);
            btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(78, 27);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Location = new System.Drawing.Point(557, 244);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(74, 27);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(162, 189);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 51);
            label3.TabIndex = 2;
            label3.Text = "Horas totales:";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTitulo.AutoSize = true;
            tlpMateria.SetColumnSpan(lblTitulo, 4);
            lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTitulo.Location = new System.Drawing.Point(326, 24);
            lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(63, 25);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "label4";
            // 
            // txtMateria
            // 
            txtMateria.Location = new System.Drawing.Point(277, 75);
            txtMateria.Margin = new System.Windows.Forms.Padding(1);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new System.Drawing.Size(276, 53);
            txtMateria.TabIndex = 9;
            // 
            // niAlerta
            // 
            niAlerta.Icon = (System.Drawing.Icon)resources.GetObject("niAlerta.Icon");
            niAlerta.Visible = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "niMateria";
            notifyIcon1.Visible = true;
            // 
            // MateriaDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.CornflowerBlue;
            ClientSize = new System.Drawing.Size(715, 386);
            ControlBox = false;
            Controls.Add(tlpMateria);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.NotifyIcon niAlerta;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}