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
            this.CMBId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTGAlmacen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CMBId
            // 
            this.CMBId.FormattingEnabled = true;
            this.CMBId.Location = new System.Drawing.Point(470, 123);
            this.CMBId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBId.Name = "CMBId";
            this.CMBId.Size = new System.Drawing.Size(180, 33);
            this.CMBId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ALMACEN";
            // 
            // DTGAlmacen
            // 
            this.DTGAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGAlmacen.Location = new System.Drawing.Point(149, 348);
            this.DTGAlmacen.Name = "DTGAlmacen";
            this.DTGAlmacen.RowHeadersWidth = 82;
            this.DTGAlmacen.RowTemplate.Height = 33;
            this.DTGAlmacen.Size = new System.Drawing.Size(862, 269);
            this.DTGAlmacen.TabIndex = 3;
            // 
            // FRMALMACEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.DTGAlmacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMALMACEN";
            this.Text = "FRMALMACEN";
            ((System.ComponentModel.ISupportInitialize)(this.DTGAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DTGAlmacen;
    }
}