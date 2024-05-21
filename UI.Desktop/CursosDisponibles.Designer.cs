namespace UI.Desktop
{
    partial class CursosDisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursosDisponibles));
            tlpCursosDisponibles = new System.Windows.Forms.TableLayoutPanel();
            btnVolver = new System.Windows.Forms.Button();
            dgvCursosDisponibles = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            label1 = new System.Windows.Forms.Label();
            niCursosDisponibles = new System.Windows.Forms.NotifyIcon(components);
            tlpCursosDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursosDisponibles).BeginInit();
            SuspendLayout();
            // 
            // tlpCursosDisponibles
            // 
            tlpCursosDisponibles.ColumnCount = 2;
            tlpCursosDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCursosDisponibles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpCursosDisponibles.Controls.Add(btnVolver, 1, 2);
            tlpCursosDisponibles.Controls.Add(dgvCursosDisponibles, 0, 1);
            tlpCursosDisponibles.Controls.Add(label1, 0, 0);
            tlpCursosDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpCursosDisponibles.Location = new System.Drawing.Point(0, 0);
            tlpCursosDisponibles.Name = "tlpCursosDisponibles";
            tlpCursosDisponibles.RowCount = 3;
            tlpCursosDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tlpCursosDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCursosDisponibles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpCursosDisponibles.Size = new System.Drawing.Size(800, 450);
            tlpCursosDisponibles.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.Firebrick;
            btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnVolver.Location = new System.Drawing.Point(658, 412);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(139, 35);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver hacia atras";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvCursosDisponibles
            // 
            dgvCursosDisponibles.AllowUserToAddRows = false;
            dgvCursosDisponibles.AllowUserToDeleteRows = false;
            dgvCursosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursosDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Comision, Seleccionar });
            tlpCursosDisponibles.SetColumnSpan(dgvCursosDisponibles, 2);
            dgvCursosDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCursosDisponibles.Location = new System.Drawing.Point(3, 33);
            dgvCursosDisponibles.MultiSelect = false;
            dgvCursosDisponibles.Name = "dgvCursosDisponibles";
            dgvCursosDisponibles.ReadOnly = true;
            dgvCursosDisponibles.RowTemplate.Height = 25;
            dgvCursosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCursosDisponibles.Size = new System.Drawing.Size(794, 373);
            dgvCursosDisponibles.TabIndex = 1;
            dgvCursosDisponibles.CellClick += dgvCursosDisponibles_CellClick;
            dgvCursosDisponibles.Paint += dgvCursosDisponibles_Paint;
            // 
            // Id
            // 
            Id.FillWeight = 10F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "Comision.Descripcion";
            Comision.FillWeight = 70F;
            Comision.HeaderText = "Comisión";
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // Seleccionar
            // 
            Seleccionar.FillWeight = 20F;
            Seleccionar.HeaderText = "";
            Seleccionar.Name = "Seleccionar";
            Seleccionar.ReadOnly = true;
            Seleccionar.Text = "Seleccionar";
            Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            tlpCursosDisponibles.SetColumnSpan(label1, 2);
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(794, 25);
            label1.TabIndex = 2;
            label1.Text = "Cursos disponibles:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // niCursosDisponibles
            // 
            niCursosDisponibles.Icon = (System.Drawing.Icon)resources.GetObject("niCursosDisponibles.Icon");
            niCursosDisponibles.Visible = true;
            // 
            // CursosDisponibles
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tlpCursosDisponibles);
            Name = "CursosDisponibles";
            Text = "CursosDisponibles";
            Load += CursosDisponibles_Load;
            tlpCursosDisponibles.ResumeLayout(false);
            tlpCursosDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursosDisponibles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCursosDisponibles;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvCursosDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.NotifyIcon niCursosDisponibles;
    }
}