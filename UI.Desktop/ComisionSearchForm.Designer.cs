namespace UI.Desktop
{
    partial class ComisionSearchForm
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
            tscComisiones = new System.Windows.Forms.ToolStripContainer();
            tlpComisiones = new System.Windows.Forms.TableLayoutPanel();
            btnSeleccionar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            dgvComisiones = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AnioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tscComisiones.ContentPanel.SuspendLayout();
            tscComisiones.SuspendLayout();
            tlpComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
            SuspendLayout();
            // 
            // tscComisiones
            // 
            // 
            // tscComisiones.ContentPanel
            // 
            tscComisiones.ContentPanel.Controls.Add(tlpComisiones);
            tscComisiones.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tscComisiones.ContentPanel.Size = new System.Drawing.Size(560, 255);
            tscComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            tscComisiones.Location = new System.Drawing.Point(0, 0);
            tscComisiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tscComisiones.Name = "tscComisiones";
            tscComisiones.Size = new System.Drawing.Size(560, 270);
            tscComisiones.TabIndex = 0;
            tscComisiones.Text = "toolStripContainer1";
            // 
            // tlpComisiones
            // 
            tlpComisiones.BackColor = System.Drawing.Color.CornflowerBlue;
            tlpComisiones.ColumnCount = 2;
            tlpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.25F));
            tlpComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.75F));
            tlpComisiones.Controls.Add(btnSeleccionar, 0, 1);
            tlpComisiones.Controls.Add(btnCancelar, 1, 1);
            tlpComisiones.Controls.Add(dgvComisiones, 0, 0);
            tlpComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpComisiones.Location = new System.Drawing.Point(0, 0);
            tlpComisiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tlpComisiones.Name = "tlpComisiones";
            tlpComisiones.RowCount = 2;
            tlpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpComisiones.Size = new System.Drawing.Size(560, 255);
            tlpComisiones.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSeleccionar.BackColor = System.Drawing.Color.Green;
            btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnSeleccionar.Location = new System.Drawing.Point(397, 224);
            btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new System.Drawing.Size(78, 29);
            btnSeleccionar.TabIndex = 0;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(479, 224);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(78, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvComisiones
            // 
            dgvComisiones.AllowUserToAddRows = false;
            dgvComisiones.AllowUserToDeleteRows = false;
            dgvComisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Comision, AnioEspecialidad, Plan });
            tlpComisiones.SetColumnSpan(dgvComisiones, 2);
            dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvComisiones.Location = new System.Drawing.Point(2, 2);
            dgvComisiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dgvComisiones.MultiSelect = false;
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.ReadOnly = true;
            dgvComisiones.RowHeadersWidth = 62;
            dgvComisiones.RowTemplate.Height = 33;
            dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvComisiones.Size = new System.Drawing.Size(556, 218);
            dgvComisiones.TabIndex = 2;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Comision
            // 
            Comision.DataPropertyName = "Descripcion";
            Comision.HeaderText = "Comisión";
            Comision.MinimumWidth = 8;
            Comision.Name = "Comision";
            Comision.ReadOnly = true;
            // 
            // AnioEspecialidad
            // 
            AnioEspecialidad.DataPropertyName = "AnioEspecialidad";
            AnioEspecialidad.HeaderText = "Año especialidad";
            AnioEspecialidad.MinimumWidth = 8;
            AnioEspecialidad.Name = "AnioEspecialidad";
            AnioEspecialidad.ReadOnly = true;
            // 
            // Plan
            // 
            Plan.DataPropertyName = "Plan.Descripcion";
            Plan.HeaderText = "Plan";
            Plan.MinimumWidth = 8;
            Plan.Name = "Plan";
            Plan.ReadOnly = true;
            // 
            // ComisionSearchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 270);
            Controls.Add(tscComisiones);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "ComisionSearchForm";
            Text = "ComisionSearchForm";
            Load += ComisionSearchForm_Load;
            tscComisiones.ContentPanel.ResumeLayout(false);
            tscComisiones.ResumeLayout(false);
            tscComisiones.PerformLayout();
            tlpComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscComisiones;
        private System.Windows.Forms.TableLayoutPanel tlpComisiones;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
    }
}