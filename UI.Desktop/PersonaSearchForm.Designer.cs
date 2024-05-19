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
            btnCancelar = new System.Windows.Forms.Button();
            btnSeleccionar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            cbTipoPersona = new System.Windows.Forms.ComboBox();
            tlpPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tlpPersonas
            // 
            tlpPersonas.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpPersonas.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpPersonas.ColumnCount = 3;
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPersonas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpPersonas.Controls.Add(dgvPersonas, 0, 1);
            tlpPersonas.Controls.Add(btnCancelar, 2, 2);
            tlpPersonas.Controls.Add(btnSeleccionar, 1, 2);
            tlpPersonas.Controls.Add(label1, 0, 0);
            tlpPersonas.Controls.Add(cbTipoPersona, 1, 0);
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
            dgvPersonas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Legajo, Apellido, Nombre });
            tlpPersonas.SetColumnSpan(dgvPersonas, 3);
            dgvPersonas.Location = new System.Drawing.Point(3, 31);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.RowTemplate.Height = 25;
            dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.Size = new System.Drawing.Size(794, 396);
            dgvPersonas.TabIndex = 4;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 5F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Legajo
            // 
            Legajo.DataPropertyName = "Legajo";
            Legajo.FillWeight = 10F;
            Legajo.HeaderText = "Legajo";
            Legajo.MinimumWidth = 8;
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.FillWeight = 20F;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 20F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(689, 433);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(108, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSeleccionar.BackColor = System.Drawing.Color.Green;
            btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSeleccionar.Location = new System.Drawing.Point(578, 433);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(105, 32);
            btnSeleccionar.TabIndex = 0;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
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
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTipoPersona
            // 
            cbTipoPersona.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cbTipoPersona.FormattingEnabled = true;
            cbTipoPersona.Location = new System.Drawing.Point(115, 3);
            cbTipoPersona.Name = "cbTipoPersona";
            cbTipoPersona.Size = new System.Drawing.Size(288, 23);
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
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}