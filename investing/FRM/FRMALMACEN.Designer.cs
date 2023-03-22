namespace investing.FRM
{
    partial class FRMALMACEN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTGAlmacen = new System.Windows.Forms.DataGridView();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ALMACEN";
            // 
            // DTGAlmacen
            // 
            this.DTGAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGAlmacen.Location = new System.Drawing.Point(99, 223);
            this.DTGAlmacen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTGAlmacen.Name = "DTGAlmacen";
            this.DTGAlmacen.RowHeadersWidth = 82;
            this.DTGAlmacen.RowTemplate.Height = 33;
            this.DTGAlmacen.Size = new System.Drawing.Size(575, 172);
            this.DTGAlmacen.TabIndex = 3;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(314, 78);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(314, 138);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // FRMALMACEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DTGAlmacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMALMACEN";
            this.Text = "FRMALMACEN";
            ((System.ComponentModel.ISupportInitialize)(this.DTGAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DTGAlmacen;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
    }
}