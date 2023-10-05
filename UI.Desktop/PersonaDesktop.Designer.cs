namespace UI.Desktop
{
    partial class PersonaDesktop
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblTitulo = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            txtPlan = new UserControls.TextBoxConValidacion();
            btnSeleccionarPlan = new System.Windows.Forms.Button();
            lblPlan = new System.Windows.Forms.Label();
            lblFechaNacimiento = new System.Windows.Forms.Label();
            dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new UserControls.TextBoxConValidacion();
            label3 = new System.Windows.Forms.Label();
            txtTelefono = new UserControls.TextBoxConValidacion();
            label2 = new System.Windows.Forms.Label();
            txtDireccion = new UserControls.TextBoxConValidacion();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new UserControls.TextBoxConValidacion();
            lblApellido = new System.Windows.Forms.Label();
            txtApellido = new UserControls.TextBoxConValidacion();
            lblLegajo = new System.Windows.Forms.Label();
            nudLegajo = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLegajo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 2, 9);
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 9);
            tableLayoutPanel1.Controls.Add(txtPlan, 2, 8);
            tableLayoutPanel1.Controls.Add(btnSeleccionarPlan, 3, 8);
            tableLayoutPanel1.Controls.Add(lblPlan, 1, 8);
            tableLayoutPanel1.Controls.Add(lblFechaNacimiento, 1, 7);
            tableLayoutPanel1.Controls.Add(dtFechaNacimiento, 2, 7);
            tableLayoutPanel1.Controls.Add(lblEmail, 1, 6);
            tableLayoutPanel1.Controls.Add(txtEmail, 2, 6);
            tableLayoutPanel1.Controls.Add(label3, 1, 5);
            tableLayoutPanel1.Controls.Add(txtTelefono, 2, 5);
            tableLayoutPanel1.Controls.Add(label2, 1, 4);
            tableLayoutPanel1.Controls.Add(txtDireccion, 2, 4);
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 3);
            tableLayoutPanel1.Controls.Add(txtNombre, 2, 3);
            tableLayoutPanel1.Controls.Add(lblApellido, 1, 2);
            tableLayoutPanel1.Controls.Add(txtApellido, 2, 2);
            tableLayoutPanel1.Controls.Add(lblLegajo, 1, 1);
            tableLayoutPanel1.Controls.Add(nudLegajo, 2, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            tableLayoutPanel1.Size = new System.Drawing.Size(778, 446);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitulo, 5);
            lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblTitulo.Location = new System.Drawing.Point(312, 0);
            lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(153, 26);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Edita persona";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.BackColor = System.Drawing.Color.Green;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnGuardar.Location = new System.Drawing.Point(365, 373);
            btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(102, 32);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(471, 373);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(100, 32);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar\r\n";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPlan
            // 
            txtPlan.Location = new System.Drawing.Point(252, 325);
            txtPlan.Margin = new System.Windows.Forms.Padding(1);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new System.Drawing.Size(214, 38);
            txtPlan.TabIndex = 14;
            // 
            // btnSeleccionarPlan
            // 
            btnSeleccionarPlan.Location = new System.Drawing.Point(471, 326);
            btnSeleccionarPlan.Margin = new System.Windows.Forms.Padding(2);
            btnSeleccionarPlan.Name = "btnSeleccionarPlan";
            btnSeleccionarPlan.Size = new System.Drawing.Size(129, 25);
            btnSeleccionarPlan.TabIndex = 16;
            btnSeleccionarPlan.Text = "Seleccionar plan";
            btnSeleccionarPlan.UseVisualStyleBackColor = true;
            btnSeleccionarPlan.Click += btnSeleccionarPlan_Click;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblPlan.Location = new System.Drawing.Point(177, 324);
            lblPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(30, 15);
            lblPlan.TabIndex = 13;
            lblPlan.Text = "Plan";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblFechaNacimiento.Location = new System.Drawing.Point(177, 282);
            lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new System.Drawing.Size(67, 30);
            lblFechaNacimiento.TabIndex = 11;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new System.Drawing.Point(253, 284);
            dtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new System.Drawing.Size(214, 23);
            dtFechaNacimiento.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblEmail.Location = new System.Drawing.Point(177, 241);
            lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(36, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(252, 242);
            txtEmail.Margin = new System.Windows.Forms.Padding(1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(214, 39);
            txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            label3.Location = new System.Drawing.Point(177, 198);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(252, 199);
            txtTelefono.Margin = new System.Windows.Forms.Padding(1);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(214, 39);
            txtTelefono.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            label2.Location = new System.Drawing.Point(177, 155);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(252, 156);
            txtDireccion.Margin = new System.Windows.Forms.Padding(1);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(214, 40);
            txtDireccion.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblNombre.Location = new System.Drawing.Point(177, 112);
            lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(252, 113);
            txtNombre.Margin = new System.Windows.Forms.Padding(1);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(214, 38);
            txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblApellido.Location = new System.Drawing.Point(177, 70);
            lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(252, 71);
            txtApellido.Margin = new System.Windows.Forms.Padding(1);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(214, 38);
            txtApellido.TabIndex = 1;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblLegajo.Location = new System.Drawing.Point(178, 26);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new System.Drawing.Size(42, 15);
            lblLegajo.TabIndex = 19;
            lblLegajo.Text = "Legajo";
            // 
            // nudLegajo
            // 
            nudLegajo.Location = new System.Drawing.Point(254, 29);
            nudLegajo.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudLegajo.Name = "nudLegajo";
            nudLegajo.Size = new System.Drawing.Size(126, 23);
            nudLegajo.TabIndex = 20;
            // 
            // PersonaDesktop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(778, 446);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "PersonaDesktop";
            Text = "PersonaDesktop";
            Load += PersonaDesktop_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLegajo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private UserControls.TextBoxConValidacion txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private UserControls.TextBoxConValidacion txtNombre;
        private System.Windows.Forms.Label label2;
        private UserControls.TextBoxConValidacion txtDireccion;
        private UserControls.TextBoxConValidacion txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
        private UserControls.TextBoxConValidacion txtEmail;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblPlan;
        private UserControls.TextBoxConValidacion txtPlan;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Button btnSeleccionarPlan;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.NumericUpDown nudLegajo;
    }
}