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
            nudAño = new System.Windows.Forms.NumericUpDown();
            txtDescripcion = new System.Windows.Forms.TextBox();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            lblPlan = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            tlComision = new System.Windows.Forms.TableLayoutPanel();
            lblComision = new System.Windows.Forms.Label();
            txtPlan = new System.Windows.Forms.TextBox();
            btnSeleccionarPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)nudAño).BeginInit();
            tlComision.SuspendLayout();
            SuspendLayout();
            // 
            // nudAño
            // 
            tlComision.SetColumnSpan(nudAño, 2);
            nudAño.Location = new System.Drawing.Point(398, 75);
            nudAño.Maximum = new decimal(new int[] { 2999, 0, 0, 0 });
            nudAño.Name = "nudAño";
            nudAño.Size = new System.Drawing.Size(119, 31);
            nudAño.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            tlComision.SetColumnSpan(txtDescripcion, 2);
            txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescripcion.Location = new System.Drawing.Point(398, 38);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(474, 31);
            txtDescripcion.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAceptar.BackColor = System.Drawing.Color.Green;
            btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAceptar.Location = new System.Drawing.Point(605, 154);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(111, 42);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Brown;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Location = new System.Drawing.Point(722, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(111, 42);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(225, 109);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(45, 25);
            lblPlan.TabIndex = 4;
            lblPlan.Text = "Plan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(225, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(147, 25);
            label2.TabIndex = 3;
            label2.Text = "Año Especialidad";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(225, 35);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(104, 25);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // tlComision
            // 
            tlComision.BackColor = System.Drawing.Color.CornflowerBlue;
            tlComision.ColumnCount = 5;
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlComision.Controls.Add(lblDescripcion, 1, 1);
            tlComision.Controls.Add(label2, 1, 2);
            tlComision.Controls.Add(btnCancelar, 3, 7);
            tlComision.Controls.Add(btnAceptar, 2, 7);
            tlComision.Controls.Add(txtDescripcion, 2, 1);
            tlComision.Controls.Add(nudAño, 2, 2);
            tlComision.Controls.Add(lblPlan, 1, 6);
            tlComision.Controls.Add(lblComision, 1, 0);
            tlComision.Controls.Add(txtPlan, 2, 6);
            tlComision.Controls.Add(btnSeleccionarPlan, 3, 6);
            tlComision.Dock = System.Windows.Forms.DockStyle.Fill;
            tlComision.ForeColor = System.Drawing.SystemColors.HighlightText;
            tlComision.Location = new System.Drawing.Point(0, 0);
            tlComision.Name = "tlComision";
            tlComision.RowCount = 8;
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlComision.Size = new System.Drawing.Size(1097, 527);
            tlComision.TabIndex = 0;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            tlComision.SetColumnSpan(lblComision, 3);
            lblComision.Dock = System.Windows.Forms.DockStyle.Fill;
            lblComision.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblComision.Location = new System.Drawing.Point(225, 0);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(647, 35);
            lblComision.TabIndex = 5;
            lblComision.Text = "Editar Comisión";
            lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblComision.Click += label1_Click;
            // 
            // txtPlan
            // 
            txtPlan.Location = new System.Drawing.Point(398, 112);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new System.Drawing.Size(317, 31);
            txtPlan.TabIndex = 6;
            // 
            // btnSeleccionarPlan
            // 
            btnSeleccionarPlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            btnSeleccionarPlan.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSeleccionarPlan.Location = new System.Drawing.Point(722, 112);
            btnSeleccionarPlan.Name = "btnSeleccionarPlan";
            btnSeleccionarPlan.Size = new System.Drawing.Size(150, 33);
            btnSeleccionarPlan.TabIndex = 7;
            btnSeleccionarPlan.Text = "Seleccionar plan";
            btnSeleccionarPlan.UseVisualStyleBackColor = false;
            btnSeleccionarPlan.Click += btnSeleccionarPlan_Click;
            // 
            // ComisionDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1097, 527);
            Controls.Add(tlComision);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "ComisionDesktop";
            Text = "ComisionDesktop";
            Load += ComisionDesktop_Load;
            ((System.ComponentModel.ISupportInitialize)nudAño).EndInit();
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
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Button btnSeleccionarPlan;
    }
}