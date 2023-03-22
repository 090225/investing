namespace investing.FRM
{
    partial class FRMCOMPRAS
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
            this.TxtFolio = new System.Windows.Forms.TextBox();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.TxtFactura = new System.Windows.Forms.TextBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.CMBAlmacen = new System.Windows.Forms.ComboBox();
            this.CMBTipoDocumento = new System.Windows.Forms.ComboBox();
            this.CMBProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DTGCompras = new System.Windows.Forms.DataGridView();
            this.DTMFecha = new System.Windows.Forms.DateTimePicker();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            // 
            // TxtFolio
            // 
            this.TxtFolio.Location = new System.Drawing.Point(243, 94);
            this.TxtFolio.Name = "TxtFolio";
            this.TxtFolio.Size = new System.Drawing.Size(100, 31);
            this.TxtFolio.TabIndex = 1;
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(243, 159);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(100, 31);
            this.TxtSerie.TabIndex = 2;
            // 
            // TxtFactura
            // 
            this.TxtFactura.Location = new System.Drawing.Point(660, 227);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.Size = new System.Drawing.Size(100, 31);
            this.TxtFactura.TabIndex = 3;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(243, 294);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(100, 31);
            this.TxtMonto.TabIndex = 4;
            // 
            // CMBAlmacen
            // 
            this.CMBAlmacen.FormattingEnabled = true;
            this.CMBAlmacen.Location = new System.Drawing.Point(639, 159);
            this.CMBAlmacen.Name = "CMBAlmacen";
            this.CMBAlmacen.Size = new System.Drawing.Size(121, 33);
            this.CMBAlmacen.TabIndex = 6;
            // 
            // CMBTipoDocumento
            // 
            this.CMBTipoDocumento.FormattingEnabled = true;
            this.CMBTipoDocumento.Location = new System.Drawing.Point(243, 219);
            this.CMBTipoDocumento.Name = "CMBTipoDocumento";
            this.CMBTipoDocumento.Size = new System.Drawing.Size(121, 33);
            this.CMBTipoDocumento.TabIndex = 7;
            // 
            // CMBProveedor
            // 
            this.CMBProveedor.FormattingEnabled = true;
            this.CMBProveedor.Location = new System.Drawing.Point(639, 94);
            this.CMBProveedor.Name = "CMBProveedor";
            this.CMBProveedor.Size = new System.Drawing.Size(121, 33);
            this.CMBProveedor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "SERIE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "TIPODOCUMENTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "MONTO:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "PROVEEDOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "ALMACEN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "FACTURA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "FECHA:";
            // 
            // DTGCompras
            // 
            this.DTGCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGCompras.Location = new System.Drawing.Point(97, 414);
            this.DTGCompras.Name = "DTGCompras";
            this.DTGCompras.RowHeadersWidth = 82;
            this.DTGCompras.RowTemplate.Height = 33;
            this.DTGCompras.Size = new System.Drawing.Size(1183, 301);
            this.DTGCompras.TabIndex = 16;
            // 
            // DTMFecha
            // 
            this.DTMFecha.Location = new System.Drawing.Point(639, 300);
            this.DTMFecha.Name = "DTMFecha";
            this.DTMFecha.Size = new System.Drawing.Size(200, 31);
            this.DTMFecha.TabIndex = 17;
            // 
            // BTNInsert
            // 
            this.BTNInsert.Location = new System.Drawing.Point(1051, 97);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(136, 46);
            this.BTNInsert.TabIndex = 18;
            this.BTNInsert.Text = "INSERT";
            this.BTNInsert.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(1051, 247);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(136, 46);
            this.BTNUpdate.TabIndex = 19;
            this.BTNUpdate.Text = "UPDATE";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(1051, 169);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(136, 37);
            this.BTNDelete.TabIndex = 20;
            this.BTNDelete.Text = "DELETE";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // FRMCOMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 827);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.DTMFecha);
            this.Controls.Add(this.DTGCompras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBProveedor);
            this.Controls.Add(this.CMBTipoDocumento);
            this.Controls.Add(this.CMBAlmacen);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtFactura);
            this.Controls.Add(this.TxtSerie);
            this.Controls.Add(this.TxtFolio);
            this.Controls.Add(this.label1);
            this.Name = "FRMCOMPRAS";
            this.Text = "FRMCOMPRAS";
            ((System.ComponentModel.ISupportInitialize)(this.DTGCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFolio;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.TextBox TxtFactura;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.ComboBox CMBAlmacen;
        private System.Windows.Forms.ComboBox CMBTipoDocumento;
        private System.Windows.Forms.ComboBox CMBProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DTGCompras;
        private System.Windows.Forms.DateTimePicker DTMFecha;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNDelete;
    }
}