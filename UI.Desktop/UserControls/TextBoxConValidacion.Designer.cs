namespace UI.Desktop.UserControls
{
    partial class TextBoxConValidacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtData = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtData
            // 
            txtData.Location = new System.Drawing.Point(2, 2);
            txtData.Margin = new System.Windows.Forms.Padding(2);
            txtData.MaxLength = 50;
            txtData.Name = "txtData";
            txtData.Size = new System.Drawing.Size(336, 23);
            txtData.TabIndex = 0;
            txtData.TextChanged += textBox1_TextChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(2, 27);
            lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(0, 15);
            lblError.TabIndex = 1;
            // 
            // TextBoxConValidacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblError);
            Controls.Add(txtData);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "TextBoxConValidacion";
            Size = new System.Drawing.Size(340, 47);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblError;
    }
}
