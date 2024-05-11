namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioDesktop));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            txtNombreUsuario = new UserControls.TextBoxConValidacion();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtClave = new UserControls.TextBoxConValidacion();
            label3 = new System.Windows.Forms.Label();
            cbHabilitado = new System.Windows.Forms.CheckBox();
            txtNombre = new UserControls.TextBoxConValidacion();
            txtApellido = new UserControls.TextBoxConValidacion();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            txtPlan = new UserControls.TextBoxConValidacion();
            lblPersona = new System.Windows.Forms.Label();
            btnPlan = new System.Windows.Forms.Button();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblTitulo = new System.Windows.Forms.Label();
            niUsuario = new System.Windows.Forms.NotifyIcon(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 584F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtNombreUsuario, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(txtClave, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(cbHabilitado, 2, 3);
            tableLayoutPanel1.Controls.Add(txtNombre, 2, 4);
            tableLayoutPanel1.Controls.Add(txtApellido, 2, 5);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 5);
            tableLayoutPanel1.Controls.Add(btnGuardar, 2, 8);
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 8);
            tableLayoutPanel1.Controls.Add(txtPlan, 2, 7);
            tableLayoutPanel1.Controls.Add(lblPersona, 1, 7);
            tableLayoutPanel1.Controls.Add(btnPlan, 3, 7);
            tableLayoutPanel1.Controls.Add(lblEmail, 1, 6);
            tableLayoutPanel1.Controls.Add(txtEmail, 2, 6);
            tableLayoutPanel1.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1259, 653);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            txtNombreUsuario.Location = new System.Drawing.Point(307, 62);
            txtNombreUsuario.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new System.Drawing.Size(582, 67);
            txtNombreUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(133, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(166, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 131);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            txtClave.Location = new System.Drawing.Point(307, 133);
            txtClave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            txtClave.Name = "txtClave";
            txtClave.Size = new System.Drawing.Size(582, 69);
            txtClave.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(133, 204);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 25);
            label3.TabIndex = 4;
            label3.Text = "Habilitado";
            // 
            // cbHabilitado
            // 
            cbHabilitado.AutoSize = true;
            cbHabilitado.Location = new System.Drawing.Point(309, 207);
            cbHabilitado.Name = "cbHabilitado";
            cbHabilitado.Size = new System.Drawing.Size(22, 21);
            cbHabilitado.TabIndex = 5;
            cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(307, 244);
            txtNombre.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(580, 68);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(307, 320);
            txtApellido.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(580, 74);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(133, 242);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(78, 25);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(133, 318);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(78, 25);
            label5.TabIndex = 9;
            label5.Text = "Apellido";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnGuardar.Location = new System.Drawing.Point(776, 582);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(111, 43);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(893, 582);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(111, 43);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPlan
            // 
            txtPlan.Enabled = false;
            txtPlan.Location = new System.Drawing.Point(307, 498);
            txtPlan.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new System.Drawing.Size(409, 72);
            txtPlan.TabIndex = 11;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new System.Drawing.Point(133, 496);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new System.Drawing.Size(74, 25);
            lblPersona.TabIndex = 10;
            lblPersona.Text = "Persona";
            // 
            // btnPlan
            // 
            btnPlan.Location = new System.Drawing.Point(893, 499);
            btnPlan.Name = "btnPlan";
            btnPlan.Size = new System.Drawing.Size(193, 42);
            btnPlan.TabIndex = 12;
            btnPlan.Text = "Seleccionar persona";
            btnPlan.UseVisualStyleBackColor = true;
            btnPlan.Click += btnPlan_Click_1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(133, 396);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(54, 25);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(309, 399);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(407, 31);
            txtEmail.TabIndex = 16;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 3);
            lblTitulo.Location = new System.Drawing.Point(134, 17);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(990, 25);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // niUsuario
            // 
            niUsuario.Icon = (System.Drawing.Icon)resources.GetObject("niUsuario.Icon");
            niUsuario.Visible = true;
            // 
            // UsuarioDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1259, 653);
            Controls.Add(tableLayoutPanel1);
            Name = "UsuarioDesktop";
            Text = "UsuarioDesktop";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.TextBoxConValidacion txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UserControls.TextBoxConValidacion txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbHabilitado;
        private UserControls.TextBoxConValidacion txtNombre;
        private UserControls.TextBoxConValidacion txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPersona;
        private UserControls.TextBoxConValidacion txtPlan;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NotifyIcon niUsuario;
    }
}