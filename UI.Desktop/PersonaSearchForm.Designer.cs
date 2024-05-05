namespace UI.Desktop
{
    partial class PersonaSearchForm
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
            tlpPersonas = new System.Windows.Forms.TableLayoutPanel();
            dgvPersonas = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            cbTipoPersona = new System.Windows.Forms.ComboBox();
            tlpPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tlpPersonas
            // 
            tlpPersonas.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpPersonas.ColumnCount = 3;
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.139534F));
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.860466F));
            tlpPersonas.Controls.Add(dgvPersonas, 0, 1);
            tlpPersonas.Controls.Add(button2, 2, 2);
            tlpPersonas.Controls.Add(button1, 1, 2);
            tlpPersonas.Controls.Add(label1, 0, 0);
            tlpPersonas.Controls.Add(cbTipoPersona, 1, 0);
            tlpPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPersonas.Location = new System.Drawing.Point(0, 0);
            tlpPersonas.Name = "tlpPersonas";
            tlpPersonas.RowCount = 2;
            tlpPersonas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            tlpPersonas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPersonas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpPersonas.Size = new System.Drawing.Size(800, 468);
            tlpPersonas.TabIndex = 0;
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Legajo, Apellido, Nombre, Editar, Borrar });
            tlpPersonas.SetColumnSpan(dgvPersonas, 3);
            dgvPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPersonas.Location = new System.Drawing.Point(3, 31);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowTemplate.Height = 25;
            dgvPersonas.Size = new System.Drawing.Size(794, 396);
            dgvPersonas.TabIndex = 4;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 5F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Legajo
            // 
            Legajo.DataPropertyName = "Legajo";
            Legajo.FillWeight = 10F;
            Legajo.HeaderText = "Legajo";
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.FillWeight = 20F;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 20F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.FillWeight = 10F;
            Editar.HeaderText = "";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Borrar
            // 
            Borrar.FillWeight = 10F;
            Borrar.HeaderText = "";
            Borrar.Name = "Borrar";
            Borrar.ReadOnly = true;
            Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Borrar.Text = "Borrar";
            Borrar.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Firebrick;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            button2.Location = new System.Drawing.Point(687, 433);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(108, 32);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            button1.Location = new System.Drawing.Point(576, 433);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 32);
            button1.TabIndex = 0;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo persona:";
            // 
            // cbTipoPersona
            // 
            cbTipoPersona.FormattingEnabled = true;
            cbTipoPersona.Location = new System.Drawing.Point(115, 3);
            cbTipoPersona.Name = "cbTipoPersona";
            cbTipoPersona.Size = new System.Drawing.Size(246, 23);
            cbTipoPersona.TabIndex = 6;
            cbTipoPersona.SelectedIndexChanged += cbTipoPersona_SelectedIndexChanged;
            // 
            // PersonaSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 468);
            Controls.Add(tlpPersonas);
            Name = "PersonaSearchForm";
            Text = "PersonaSearchForm";
            Load += PersonaSearchForm_Load;
            tlpPersonas.ResumeLayout(false);
            tlpPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPersonas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}