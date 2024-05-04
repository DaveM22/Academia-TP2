namespace UI.Desktop
{
    partial class ComisionDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComisionDesktop));
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            lblPlan = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            tlComision = new System.Windows.Forms.TableLayoutPanel();
            lblComision = new System.Windows.Forms.Label();
            btnSeleccionarPlan = new System.Windows.Forms.Button();
            txtPlan = new UserControls.TextBoxConValidacion();
            txtDescripcion = new UserControls.TextBoxConValidacion();
            nudAño = new UserControls.NumericUpDownValidation();
            notifyIcon1 = new System.Windows.Forms.NotifyIcon(components);
            numericUpDownValidation1 = new UserControls.NumericUpDownValidation();
            tlComision.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAceptar.BackColor = System.Drawing.Color.Green;
            btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAceptar.Location = new System.Drawing.Point(425, 197);
            btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(99, 35);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Brown;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Location = new System.Drawing.Point(528, 197);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(104, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPlan
            // 
            lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblPlan.Location = new System.Drawing.Point(207, 143);
            lblPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(33, 47);
            lblPlan.TabIndex = 4;
            lblPlan.Text = "Plan:";
            lblPlan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.Location = new System.Drawing.Point(136, 96);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 37);
            label2.TabIndex = 3;
            label2.Text = "Año Especialidad:";
            label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new System.Drawing.Point(136, 42);
            lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(104, 27);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion:";
            lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlComision
            // 
            tlComision.BackColor = System.Drawing.Color.CornflowerBlue;
            tlComision.ColumnCount = 5;
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlComision.Controls.Add(label2, 1, 2);
            tlComision.Controls.Add(lblComision, 1, 0);
            tlComision.Controls.Add(btnSeleccionarPlan, 3, 3);
            tlComision.Controls.Add(btnAceptar, 2, 4);
            tlComision.Controls.Add(btnCancelar, 3, 4);
            tlComision.Controls.Add(txtPlan, 2, 3);
            tlComision.Controls.Add(txtDescripcion, 2, 1);
            tlComision.Controls.Add(nudAño, 2, 2);
            tlComision.Controls.Add(lblDescripcion, 1, 1);
            tlComision.Controls.Add(lblPlan, 1, 3);
            tlComision.Controls.Add(numericUpDownValidation1, 0, 0);
            tlComision.Dock = System.Windows.Forms.DockStyle.Fill;
            tlComision.ForeColor = System.Drawing.SystemColors.HighlightText;
            tlComision.Location = new System.Drawing.Point(0, 0);
            tlComision.Margin = new System.Windows.Forms.Padding(2);
            tlComision.Name = "tlComision";
            tlComision.RowCount = 8;
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            tlComision.Size = new System.Drawing.Size(768, 316);
            tlComision.TabIndex = 0;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            tlComision.SetColumnSpan(lblComision, 3);
            lblComision.Dock = System.Windows.Forms.DockStyle.Fill;
            lblComision.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblComision.Location = new System.Drawing.Point(136, 0);
            lblComision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(496, 42);
            lblComision.TabIndex = 5;
            lblComision.Text = "Editar Comisión";
            lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionarPlan
            // 
            btnSeleccionarPlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btnSeleccionarPlan.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSeleccionarPlan.Location = new System.Drawing.Point(528, 140);
            btnSeleccionarPlan.Margin = new System.Windows.Forms.Padding(2);
            btnSeleccionarPlan.Name = "btnSeleccionarPlan";
            btnSeleccionarPlan.Size = new System.Drawing.Size(104, 26);
            btnSeleccionarPlan.TabIndex = 7;
            btnSeleccionarPlan.Text = "Seleccionar plan";
            btnSeleccionarPlan.UseVisualStyleBackColor = false;
            btnSeleccionarPlan.Click += btnSeleccionarPlan_Click;
            // 
            // txtPlan
            // 
            txtPlan.Location = new System.Drawing.Point(244, 140);
            txtPlan.Margin = new System.Windows.Forms.Padding(2);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new System.Drawing.Size(280, 47);
            txtPlan.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(244, 44);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(275, 45);
            txtDescripcion.TabIndex = 10;
            // 
            // nudAño
            // 
            nudAño.Location = new System.Drawing.Point(244, 93);
            nudAño.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            nudAño.Name = "nudAño";
            nudAño.Size = new System.Drawing.Size(280, 43);
            nudAño.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // numericUpDownValidation1
            // 
            numericUpDownValidation1.Location = new System.Drawing.Point(2, 2);
            numericUpDownValidation1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            numericUpDownValidation1.Name = "numericUpDownValidation1";
            numericUpDownValidation1.Size = new System.Drawing.Size(130, 37);
            numericUpDownValidation1.TabIndex = 12;
            // 
            // ComisionDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(768, 316);
            Controls.Add(tlComision);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ComisionDesktop";
            Text = "ComisionDesktop";
            Load += ComisionDesktop_Load;
            tlComision.ResumeLayout(false);
            tlComision.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlComision;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Button btnSeleccionarPlan;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private UserControls.TextBoxConValidacion txtPlan;
        private UserControls.TextBoxConValidacion txtDescripcion;
        private UserControls.NumericUpDownValidation nudAño;
        private UserControls.NumericUpDownValidation numericUpDownValidation1;
    }
}