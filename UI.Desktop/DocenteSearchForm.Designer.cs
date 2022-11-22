namespace UI.Desktop
{
    partial class DocenteSearchForm
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
            this.tsDocentes = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocente = new System.Windows.Forms.DataGridView();
            this.IdDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.tsDocentes.ContentPanel.SuspendLayout();
            this.tsDocentes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // tsDocentes
            // 
            // 
            // tsDocentes.ContentPanel
            // 
            this.tsDocentes.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.tsDocentes.ContentPanel.Size = new System.Drawing.Size(853, 425);
            this.tsDocentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsDocentes.Location = new System.Drawing.Point(0, 0);
            this.tsDocentes.Name = "tsDocentes";
            this.tsDocentes.Size = new System.Drawing.Size(853, 450);
            this.tsDocentes.TabIndex = 0;
            this.tsDocentes.Text = "toolStripContainer1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.75F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDocente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvDocente
            // 
            this.dgvDocente.AllowUserToAddRows = false;
            this.dgvDocente.AllowUserToDeleteRows = false;
            this.dgvDocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDocente,
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.Plan});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDocente, 2);
            this.dgvDocente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocente.Location = new System.Drawing.Point(3, 3);
            this.dgvDocente.MultiSelect = false;
            this.dgvDocente.Name = "dgvDocente";
            this.dgvDocente.ReadOnly = true;
            this.dgvDocente.RowTemplate.Height = 25;
            this.dgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocente.Size = new System.Drawing.Size(847, 385);
            this.dgvDocente.TabIndex = 1;
            // 
            // IdDocente
            // 
            this.IdDocente.DataPropertyName = "Id";
            this.IdDocente.HeaderText = "IdDocente";
            this.IdDocente.Name = "IdDocente";
            this.IdDocente.ReadOnly = true;
            this.IdDocente.Visible = false;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "PlanDescripcion";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(772, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Location = new System.Drawing.Point(675, 394);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(91, 28);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // DocenteSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.tsDocentes);
            this.Name = "DocenteSearchForm";
            this.Text = "DocenteSearchForm";
            this.Load += new System.EventHandler(this.DocenteSearchForm_Load);
            this.tsDocentes.ContentPanel.ResumeLayout(false);
            this.tsDocentes.ResumeLayout(false);
            this.tsDocentes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsDocentes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvDocente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
    }
}