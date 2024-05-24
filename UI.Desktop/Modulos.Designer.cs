namespace UI.Desktop
{
    partial class Modulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulos));
            tscModulos = new System.Windows.Forms.ToolStripContainer();
            tlpModulos = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            btnActualizar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            dgvModulos = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsbNuevoRol = new System.Windows.Forms.ToolStripButton();
            tscModulos.ContentPanel.SuspendLayout();
            tscModulos.TopToolStripPanel.SuspendLayout();
            tscModulos.SuspendLayout();
            tlpModulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModulos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tscModulos
            // 
            // 
            // tscModulos.ContentPanel
            // 
            tscModulos.ContentPanel.Controls.Add(tlpModulos);
            tscModulos.ContentPanel.Size = new System.Drawing.Size(800, 438);
            tscModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            tscModulos.Location = new System.Drawing.Point(0, 0);
            tscModulos.Name = "tscModulos";
            tscModulos.Size = new System.Drawing.Size(800, 463);
            tscModulos.TabIndex = 0;
            tscModulos.Text = "toolStripContainer1";
            // 
            // tscModulos.TopToolStripPanel
            // 
            tscModulos.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tlpModulos
            // 
            tlpModulos.ColumnCount = 2;
            tlpModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpModulos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpModulos.Controls.Add(label1, 0, 0);
            tlpModulos.Controls.Add(btnActualizar, 0, 2);
            tlpModulos.Controls.Add(btnCancelar, 1, 2);
            tlpModulos.Controls.Add(dgvModulos, 0, 1);
            tlpModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpModulos.Location = new System.Drawing.Point(0, 0);
            tlpModulos.Name = "tlpModulos";
            tlpModulos.RowCount = 3;
            tlpModulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tlpModulos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpModulos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpModulos.Size = new System.Drawing.Size(800, 438);
            tlpModulos.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            tlpModulos.SetColumnSpan(label1, 2);
            label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(794, 23);
            label1.TabIndex = 0;
            label1.Text = "Modulos del usuario";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.Green;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnActualizar.Location = new System.Drawing.Point(576, 396);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(93, 39);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnCancelar.Location = new System.Drawing.Point(675, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(122, 39);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Volver a usuario";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvModulos
            // 
            dgvModulos.AllowUserToAddRows = false;
            dgvModulos.AllowUserToDeleteRows = false;
            dgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Modulo, Quitar });
            tlpModulos.SetColumnSpan(dgvModulos, 2);
            dgvModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvModulos.Location = new System.Drawing.Point(3, 39);
            dgvModulos.MultiSelect = false;
            dgvModulos.Name = "dgvModulos";
            dgvModulos.ReadOnly = true;
            dgvModulos.RowTemplate.Height = 25;
            dgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvModulos.Size = new System.Drawing.Size(794, 351);
            dgvModulos.TabIndex = 3;
            // 
            // Id
            // 
            Id.FillWeight = 10F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Modulo
            // 
            Modulo.DataPropertyName = "Modulo.Descripcion";
            Modulo.FillWeight = 90F;
            Modulo.HeaderText = "Nombre de modulo";
            Modulo.Name = "Modulo";
            Modulo.ReadOnly = true;
            // 
            // Quitar
            // 
            Quitar.FillWeight = 10F;
            Quitar.HeaderText = "";
            Quitar.Name = "Quitar";
            Quitar.ReadOnly = true;
            Quitar.Text = "Quitar";
            Quitar.UseColumnTextForButtonValue = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbNuevoRol });
            toolStrip1.Location = new System.Drawing.Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(144, 25);
            toolStrip1.TabIndex = 0;
            // 
            // tsbNuevoRol
            // 
            tsbNuevoRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbNuevoRol.Image = (System.Drawing.Image)resources.GetObject("tsbNuevoRol.Image");
            tsbNuevoRol.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbNuevoRol.Name = "tsbNuevoRol";
            tsbNuevoRol.Size = new System.Drawing.Size(132, 22);
            tsbNuevoRol.Text = "Asignar nuevo modulo";
            tsbNuevoRol.Click += tsbNuevoRol_Click;
            // 
            // Modulos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 463);
            Controls.Add(tscModulos);
            Name = "Modulos";
            Text = "Modulos";
            Load += Modulos_Load;
            tscModulos.ContentPanel.ResumeLayout(false);
            tscModulos.TopToolStripPanel.ResumeLayout(false);
            tscModulos.TopToolStripPanel.PerformLayout();
            tscModulos.ResumeLayout(false);
            tscModulos.PerformLayout();
            tlpModulos.ResumeLayout(false);
            tlpModulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModulos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscModulos;
        private System.Windows.Forms.TableLayoutPanel tlpModulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevoRol;
        private System.Windows.Forms.DataGridView dgvModulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
    }
}