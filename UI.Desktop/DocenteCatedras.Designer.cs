namespace UI.Desktop
{
    partial class DocenteCatedras
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
            tlCatedras = new System.Windows.Forms.TableLayoutPanel();
            dgvCatedras = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Catedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tlCatedras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatedras).BeginInit();
            SuspendLayout();
            // 
            // tlCatedras
            // 
            tlCatedras.BackColor = System.Drawing.Color.CornflowerBlue;
            tlCatedras.ColumnCount = 2;
            tlCatedras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlCatedras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlCatedras.Controls.Add(button1, 0, 2);
            tlCatedras.Controls.Add(button2, 1, 2);
            tlCatedras.Controls.Add(dgvCatedras, 0, 1);
            tlCatedras.Controls.Add(label1, 0, 0);
            tlCatedras.Dock = System.Windows.Forms.DockStyle.Fill;
            tlCatedras.Location = new System.Drawing.Point(0, 0);
            tlCatedras.Name = "tlCatedras";
            tlCatedras.RowCount = 3;
            tlCatedras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            tlCatedras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlCatedras.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlCatedras.Size = new System.Drawing.Size(800, 450);
            tlCatedras.TabIndex = 0;
            tlCatedras.Paint += tlCatedras_Paint;
            // 
            // dgvCatedras
            // 
            dgvCatedras.AllowUserToAddRows = false;
            dgvCatedras.AllowUserToDeleteRows = false;
            dgvCatedras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatedras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatedras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Comision, Catedra, Actualizar });
            tlCatedras.SetColumnSpan(dgvCatedras, 2);
            dgvCatedras.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCatedras.Location = new System.Drawing.Point(3, 41);
            dgvCatedras.MultiSelect = false;
            dgvCatedras.Name = "dgvCatedras";
            dgvCatedras.ReadOnly = true;
            dgvCatedras.RowTemplate.Height = 25;
            dgvCatedras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCatedras.Size = new System.Drawing.Size(794, 368);
            dgvCatedras.TabIndex = 0;
            dgvCatedras.CellClick += dgvCatedras_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 10F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "Curso.Comision.Descripcion";
            Comision.FillWeight = 30F;
            Comision.HeaderText = "Comisión";
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // Catedra
            // 
            Catedra.DataPropertyName = "Curso.Materia.Descripcion";
            Catedra.FillWeight = 30F;
            Catedra.HeaderText = "Catedra";
            Catedra.MinimumWidth = 8;
            Catedra.Name = "Catedra";
            Catedra.ReadOnly = true;
            // 
            // Actualizar
            // 
            Actualizar.FillWeight = 10F;
            Actualizar.HeaderText = "";
            Actualizar.MinimumWidth = 8;
            Actualizar.Name = "Actualizar";
            Actualizar.ReadOnly = true;
            Actualizar.Text = "Registrar nota";
            Actualizar.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.Green;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            button1.Location = new System.Drawing.Point(641, 415);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 32);
            button1.TabIndex = 1;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Firebrick;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            button2.Location = new System.Drawing.Point(722, 415);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 32);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            tlCatedras.SetColumnSpan(label1, 2);
            label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(794, 27);
            label1.TabIndex = 3;
            label1.Text = "Materias asignadas";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocenteCatedras
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tlCatedras);
            Name = "DocenteCatedras";
            Text = "DocenteCatedras";
            Load += DocenteCatedras_Load;
            tlCatedras.ResumeLayout(false);
            tlCatedras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatedras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlCatedras;
        private System.Windows.Forms.DataGridView dgvCatedras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catedra;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.Label label1;
    }
}