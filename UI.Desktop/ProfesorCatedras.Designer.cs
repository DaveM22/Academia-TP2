namespace UI.Desktop
{
    partial class ProfesorCatedras
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
            tlProfesorCatedras = new System.Windows.Forms.TableLayoutPanel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            tlProfesorCatedras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tlProfesorCatedras
            // 
            tlProfesorCatedras.ColumnCount = 2;
            tlProfesorCatedras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.75F));
            tlProfesorCatedras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25F));
            tlProfesorCatedras.Controls.Add(dataGridView1, 0, 1);
            tlProfesorCatedras.Controls.Add(button1, 1, 2);
            tlProfesorCatedras.Controls.Add(button2, 0, 2);
            tlProfesorCatedras.Dock = System.Windows.Forms.DockStyle.Fill;
            tlProfesorCatedras.Location = new System.Drawing.Point(0, 0);
            tlProfesorCatedras.Name = "tlProfesorCatedras";
            tlProfesorCatedras.RowCount = 3;
            tlProfesorCatedras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlProfesorCatedras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            tlProfesorCatedras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlProfesorCatedras.Size = new System.Drawing.Size(800, 450);
            tlProfesorCatedras.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlProfesorCatedras.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(3, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(794, 342);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Firebrick;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            button1.Location = new System.Drawing.Point(689, 402);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button2.BackColor = System.Drawing.Color.Green;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            button2.Location = new System.Drawing.Point(608, 402);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = false;
            // 
            // ProfesorCatedras
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tlProfesorCatedras);
            Name = "ProfesorCatedras";
            Text = "ProfesorCatedras";
            tlProfesorCatedras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlProfesorCatedras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}