namespace UI.Desktop
{
    partial class formLogin
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
            lblUsuario = new System.Windows.Forms.Label();
            txtUsuario = new System.Windows.Forms.MaskedTextBox();
            lblClave = new System.Windows.Forms.Label();
            txtClave = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new System.Drawing.Point(76, 47);
            lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(141, 46);
            txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(148, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new System.Drawing.Point(76, 87);
            lblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new System.Drawing.Size(36, 15);
            lblClave.TabIndex = 2;
            lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new System.Drawing.Point(141, 83);
            txtClave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new System.Drawing.Size(148, 23);
            txtClave.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(150, 124);
            btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(78, 26);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(368, 210);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "formLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ingresar al sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
    }
}