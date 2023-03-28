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
            this.components = new System.ComponentModel.Container();
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
            this.cDFOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIDTIPODOCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDCANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIMPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDUBICACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPRASDETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet11 = new investing.VENTASDataSet11();
            this.cOMPRASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet5 = new investing.VENTASDataSet5();
            this.DTMFecha = new System.Windows.Forms.DateTimePicker();
            this.cOMPRASTableAdapter = new investing.VENTASDataSet5TableAdapters.COMPRASTableAdapter();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cOMPRAS_DETALLETableAdapter = new investing.VENTASDataSet11TableAdapters.COMPRAS_DETALLETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DTGCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLIO:";
            // 
            // TxtFolio
            // 
            this.TxtFolio.Location = new System.Drawing.Point(498, 66);
            this.TxtFolio.Name = "TxtFolio";
            this.TxtFolio.Size = new System.Drawing.Size(121, 31);
            this.TxtFolio.TabIndex = 1;
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(498, 131);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(121, 31);
            this.TxtSerie.TabIndex = 2;
            // 
            // TxtFactura
            // 
            this.TxtFactura.Location = new System.Drawing.Point(973, 199);
            this.TxtFactura.Name = "TxtFactura";
            this.TxtFactura.Size = new System.Drawing.Size(121, 31);
            this.TxtFactura.TabIndex = 3;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(498, 266);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(121, 31);
            this.TxtMonto.TabIndex = 4;
            // 
            // CMBAlmacen
            // 
            this.CMBAlmacen.FormattingEnabled = true;
            this.CMBAlmacen.Location = new System.Drawing.Point(973, 131);
            this.CMBAlmacen.Name = "CMBAlmacen";
            this.CMBAlmacen.Size = new System.Drawing.Size(121, 33);
            this.CMBAlmacen.TabIndex = 6;
            // 
            // CMBTipoDocumento
            // 
            this.CMBTipoDocumento.FormattingEnabled = true;
            this.CMBTipoDocumento.Location = new System.Drawing.Point(498, 191);
            this.CMBTipoDocumento.Name = "CMBTipoDocumento";
            this.CMBTipoDocumento.Size = new System.Drawing.Size(121, 33);
            this.CMBTipoDocumento.TabIndex = 7;
            this.CMBTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CMBTipoDocumento_SelectedIndexChanged);
            // 
            // CMBProveedor
            // 
            this.CMBProveedor.FormattingEnabled = true;
            this.CMBProveedor.Location = new System.Drawing.Point(973, 66);
            this.CMBProveedor.Name = "CMBProveedor";
            this.CMBProveedor.Size = new System.Drawing.Size(121, 33);
            this.CMBProveedor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "SERIE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "TIPODOCUMENTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "MONTO:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "PROVEEDOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "ALMACEN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "FACTURA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "FECHA:";
            // 
            // DTGCompras
            // 
            this.DTGCompras.AutoGenerateColumns = false;
            this.DTGCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDFOLIODataGridViewTextBoxColumn,
            this.cDSERIEDataGridViewTextBoxColumn,
            this.cDIDTIPODOCTODataGridViewTextBoxColumn,
            this.cDIDPRODUCTODataGridViewTextBoxColumn,
            this.cDCANTIDADDataGridViewTextBoxColumn,
            this.cDIMPORTEDataGridViewTextBoxColumn,
            this.cDIVADataGridViewTextBoxColumn,
            this.cDUBICACIONDataGridViewTextBoxColumn});
            this.DTGCompras.DataSource = this.cOMPRASDETALLEBindingSource;
            this.DTGCompras.Location = new System.Drawing.Point(53, 471);
            this.DTGCompras.Name = "DTGCompras";
            this.DTGCompras.RowHeadersWidth = 82;
            this.DTGCompras.RowTemplate.Height = 33;
            this.DTGCompras.Size = new System.Drawing.Size(1407, 301);
            this.DTGCompras.TabIndex = 16;
            // 
            // cDFOLIODataGridViewTextBoxColumn
            // 
            this.cDFOLIODataGridViewTextBoxColumn.DataPropertyName = "CD_FOLIO";
            this.cDFOLIODataGridViewTextBoxColumn.HeaderText = "CD_FOLIO";
            this.cDFOLIODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDFOLIODataGridViewTextBoxColumn.Name = "cDFOLIODataGridViewTextBoxColumn";
            this.cDFOLIODataGridViewTextBoxColumn.Width = 200;
            // 
            // cDSERIEDataGridViewTextBoxColumn
            // 
            this.cDSERIEDataGridViewTextBoxColumn.DataPropertyName = "CD_SERIE";
            this.cDSERIEDataGridViewTextBoxColumn.HeaderText = "CD_SERIE";
            this.cDSERIEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDSERIEDataGridViewTextBoxColumn.Name = "cDSERIEDataGridViewTextBoxColumn";
            this.cDSERIEDataGridViewTextBoxColumn.Width = 200;
            // 
            // cDIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "CD_ID_TIPODOCTO";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "CD_ID_TIPODOCTO";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.Name = "cDIDTIPODOCTODataGridViewTextBoxColumn";
            this.cDIDTIPODOCTODataGridViewTextBoxColumn.Width = 200;
            // 
            // cDIDPRODUCTODataGridViewTextBoxColumn
            // 
            this.cDIDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "CD_ID_PRODUCTO";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.HeaderText = "CD_ID_PRODUCTO";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDIDPRODUCTODataGridViewTextBoxColumn.Name = "cDIDPRODUCTODataGridViewTextBoxColumn";
            this.cDIDPRODUCTODataGridViewTextBoxColumn.Width = 200;
            // 
            // cDCANTIDADDataGridViewTextBoxColumn
            // 
            this.cDCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CD_CANTIDAD";
            this.cDCANTIDADDataGridViewTextBoxColumn.HeaderText = "CD_CANTIDAD";
            this.cDCANTIDADDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDCANTIDADDataGridViewTextBoxColumn.Name = "cDCANTIDADDataGridViewTextBoxColumn";
            this.cDCANTIDADDataGridViewTextBoxColumn.Width = 200;
            // 
            // cDIMPORTEDataGridViewTextBoxColumn
            // 
            this.cDIMPORTEDataGridViewTextBoxColumn.DataPropertyName = "CD_IMPORTE";
            this.cDIMPORTEDataGridViewTextBoxColumn.HeaderText = "CD_IMPORTE";
            this.cDIMPORTEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDIMPORTEDataGridViewTextBoxColumn.Name = "cDIMPORTEDataGridViewTextBoxColumn";
            this.cDIMPORTEDataGridViewTextBoxColumn.Width = 200;
            // 
            // cDIVADataGridViewTextBoxColumn
            // 
            this.cDIVADataGridViewTextBoxColumn.DataPropertyName = "CD_IVA";
            this.cDIVADataGridViewTextBoxColumn.HeaderText = "CD_IVA";
            this.cDIVADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDIVADataGridViewTextBoxColumn.Name = "cDIVADataGridViewTextBoxColumn";
            this.cDIVADataGridViewTextBoxColumn.Width = 200;
            // 
            // cDUBICACIONDataGridViewTextBoxColumn
            // 
            this.cDUBICACIONDataGridViewTextBoxColumn.DataPropertyName = "CD_UBICACION";
            this.cDUBICACIONDataGridViewTextBoxColumn.HeaderText = "CD_UBICACION";
            this.cDUBICACIONDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cDUBICACIONDataGridViewTextBoxColumn.Name = "cDUBICACIONDataGridViewTextBoxColumn";
            this.cDUBICACIONDataGridViewTextBoxColumn.Width = 200;
            // 
            // cOMPRASDETALLEBindingSource
            // 
            this.cOMPRASDETALLEBindingSource.DataMember = "COMPRAS_DETALLE";
            this.cOMPRASDETALLEBindingSource.DataSource = this.vENTASDataSet11;
            // 
            // vENTASDataSet11
            // 
            this.vENTASDataSet11.DataSetName = "VENTASDataSet11";
            this.vENTASDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRASBindingSource
            // 
            this.cOMPRASBindingSource.DataMember = "COMPRAS";
            this.cOMPRASBindingSource.DataSource = this.vENTASDataSet5;
            // 
            // vENTASDataSet5
            // 
            this.vENTASDataSet5.DataSetName = "VENTASDataSet5";
            this.vENTASDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTMFecha
            // 
            this.DTMFecha.Location = new System.Drawing.Point(973, 266);
            this.DTMFecha.Name = "DTMFecha";
            this.DTMFecha.Size = new System.Drawing.Size(200, 31);
            this.DTMFecha.TabIndex = 17;
            this.DTMFecha.ValueChanged += new System.EventHandler(this.DTMFecha_ValueChanged);
            // 
            // cOMPRASTableAdapter
            // 
            this.cOMPRASTableAdapter.ClearBeforeFill = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.Red;
            this.BTNDelete.Location = new System.Drawing.Point(822, 410);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(112, 53);
            this.BTNDelete.TabIndex = 37;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = false;
            // 
            // BTNInsert
            // 
            this.BTNInsert.BackColor = System.Drawing.Color.Chartreuse;
            this.BTNInsert.Location = new System.Drawing.Point(566, 410);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(228, 53);
            this.BTNInsert.TabIndex = 36;
            this.BTNInsert.Text = "Guardar/Actualizar";
            this.BTNInsert.UseVisualStyleBackColor = false;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::investing.Properties.Resources.PRODCUTOS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // cOMPRAS_DETALLETableAdapter
            // 
            this.cOMPRAS_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // FRMCOMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 827);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNDelete);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCOMPRAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMCOMPRAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASDETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private VENTASDataSet5 vENTASDataSet5;
        private System.Windows.Forms.BindingSource cOMPRASBindingSource;
        private VENTASDataSet5TableAdapters.COMPRASTableAdapter cOMPRASTableAdapter;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VENTASDataSet11 vENTASDataSet11;
        private System.Windows.Forms.BindingSource cOMPRASDETALLEBindingSource;
        private VENTASDataSet11TableAdapters.COMPRAS_DETALLETableAdapter cOMPRAS_DETALLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDFOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIDTIPODOCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDCANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIMPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDUBICACIONDataGridViewTextBoxColumn;
    }
}