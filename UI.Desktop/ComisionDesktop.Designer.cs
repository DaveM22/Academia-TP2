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
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPlan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tlComision = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.btnSeleccionarPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.tlComision.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAño
            // 
            this.tlComision.SetColumnSpan(this.nudAño, 2);
            this.nudAño.Location = new System.Drawing.Point(398, 75);
            this.nudAño.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(119, 31);
            this.nudAño.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.tlComision.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(398, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(474, 31);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.Green;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(605, 154);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 42);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(722, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 42);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(225, 109);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(45, 25);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Plan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año Especialidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(225, 35);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 25);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // tlComision
            // 
            this.tlComision.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlComision.ColumnCount = 5;
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlComision.Controls.Add(this.lblDescripcion, 1, 1);
            this.tlComision.Controls.Add(this.label2, 1, 2);
            this.tlComision.Controls.Add(this.btnCancelar, 3, 7);
            this.tlComision.Controls.Add(this.btnAceptar, 2, 7);
            this.tlComision.Controls.Add(this.txtDescripcion, 2, 1);
            this.tlComision.Controls.Add(this.nudAño, 2, 2);
            this.tlComision.Controls.Add(this.lblPlan, 1, 6);
            this.tlComision.Controls.Add(this.label1, 1, 0);
            this.tlComision.Controls.Add(this.txtPlan, 2, 6);
            this.tlComision.Controls.Add(this.btnSeleccionarPlan, 3, 6);
            this.tlComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComision.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlComision.Location = new System.Drawing.Point(0, 0);
            this.tlComision.Name = "tlComision";
            this.tlComision.RowCount = 8;
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComision.Size = new System.Drawing.Size(1097, 526);
            this.tlComision.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlComision.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Editar Comisión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(398, 112);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(318, 31);
            this.txtPlan.TabIndex = 6;
            // 
            // btnSeleccionarPlan
            // 
            this.btnSeleccionarPlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeleccionarPlan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeleccionarPlan.Location = new System.Drawing.Point(722, 112);
            this.btnSeleccionarPlan.Name = "btnSeleccionarPlan";
            this.btnSeleccionarPlan.Size = new System.Drawing.Size(150, 34);
            this.btnSeleccionarPlan.TabIndex = 7;
            this.btnSeleccionarPlan.Text = "Seleccionar plan";
            this.btnSeleccionarPlan.UseVisualStyleBackColor = false;
            this.btnSeleccionarPlan.Click += new System.EventHandler(this.btnSeleccionarPlan_Click);
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 526);
            this.Controls.Add(this.tlComision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ComisionDesktop";
            this.Text = "ComisionDesktop";
            this.Load += new System.EventHandler(this.ComisionDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.tlComision.ResumeLayout(false);
            this.tlComision.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Button btnSeleccionarPlan;
    }
}