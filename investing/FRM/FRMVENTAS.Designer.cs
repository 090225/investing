namespace investing.FRM
{
    partial class FRMVENTAS
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
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBtipDocumento = new System.Windows.Forms.ComboBox();
            this.CMBCliente = new System.Windows.Forms.ComboBox();
            this.CMBAlmacen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTGVentas = new System.Windows.Forms.DataGridView();
            this.tMPIDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPIDALMACENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPFOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPSERIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPIDTIPODOCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPIDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPCANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPIMPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMPVENTADETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet3 = new investing.VENTASDataSet3();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTFOLIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.TXTIMPORTE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTIVA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DTPFECHA = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.BTNAGG = new System.Windows.Forms.Button();
            this.TXTPRODUCTO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMPVENTADETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "VENTAS";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(1243, 116);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(200, 31);
            this.TxtMonto.TabIndex = 27;
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(338, 191);
            this.TxtSerie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(180, 31);
            this.TxtSerie.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "ALMACEN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "CLIENTE:";
            // 
            // CMBtipDocumento
            // 
            this.CMBtipDocumento.FormattingEnabled = true;
            this.CMBtipDocumento.Location = new System.Drawing.Point(338, 257);
            this.CMBtipDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBtipDocumento.Name = "CMBtipDocumento";
            this.CMBtipDocumento.Size = new System.Drawing.Size(180, 33);
            this.CMBtipDocumento.TabIndex = 21;
            // 
            // CMBCliente
            // 
            this.CMBCliente.FormattingEnabled = true;
            this.CMBCliente.Location = new System.Drawing.Point(832, 116);
            this.CMBCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBCliente.Name = "CMBCliente";
            this.CMBCliente.Size = new System.Drawing.Size(180, 33);
            this.CMBCliente.TabIndex = 20;
            // 
            // CMBAlmacen
            // 
            this.CMBAlmacen.FormattingEnabled = true;
            this.CMBAlmacen.Location = new System.Drawing.Point(832, 193);
            this.CMBAlmacen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBAlmacen.Name = "CMBAlmacen";
            this.CMBAlmacen.Size = new System.Drawing.Size(180, 33);
            this.CMBAlmacen.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1068, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "MONTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "SERIE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "FOLIO:";
            // 
            // DTGVentas
            // 
            this.DTGVentas.AutoGenerateColumns = false;
            this.DTGVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tMPIDCLIENTEDataGridViewTextBoxColumn,
            this.tMPIDALMACENDataGridViewTextBoxColumn,
            this.tMPFOLIODataGridViewTextBoxColumn,
            this.tMPSERIEDataGridViewTextBoxColumn,
            this.tMPIDTIPODOCTODataGridViewTextBoxColumn,
            this.tMPIDPRODUCTODataGridViewTextBoxColumn,
            this.tMPCANTIDADDataGridViewTextBoxColumn,
            this.tMPIMPORTEDataGridViewTextBoxColumn,
            this.tMPIVADataGridViewTextBoxColumn});
            this.DTGVentas.DataSource = this.tMPVENTADETALLEBindingSource;
            this.DTGVentas.Location = new System.Drawing.Point(67, 519);
            this.DTGVentas.Name = "DTGVentas";
            this.DTGVentas.RowHeadersWidth = 82;
            this.DTGVentas.RowTemplate.Height = 33;
            this.DTGVentas.Size = new System.Drawing.Size(1429, 419);
            this.DTGVentas.TabIndex = 30;
            this.DTGVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVentas_CellContentClick);
            // 
            // tMPIDCLIENTEDataGridViewTextBoxColumn
            // 
            this.tMPIDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "TMP_ID_CLIENTE";
            this.tMPIDCLIENTEDataGridViewTextBoxColumn.HeaderText = "TMP_ID_CLIENTE";
            this.tMPIDCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPIDCLIENTEDataGridViewTextBoxColumn.Name = "tMPIDCLIENTEDataGridViewTextBoxColumn";
            this.tMPIDCLIENTEDataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPIDALMACENDataGridViewTextBoxColumn
            // 
            this.tMPIDALMACENDataGridViewTextBoxColumn.DataPropertyName = "TMP_ID_ALMACEN";
            this.tMPIDALMACENDataGridViewTextBoxColumn.HeaderText = "TMP_ID_ALMACEN";
            this.tMPIDALMACENDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPIDALMACENDataGridViewTextBoxColumn.Name = "tMPIDALMACENDataGridViewTextBoxColumn";
            this.tMPIDALMACENDataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPFOLIODataGridViewTextBoxColumn
            // 
            this.tMPFOLIODataGridViewTextBoxColumn.DataPropertyName = "TMP_FOLIO";
            this.tMPFOLIODataGridViewTextBoxColumn.HeaderText = "TMP_FOLIO";
            this.tMPFOLIODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPFOLIODataGridViewTextBoxColumn.Name = "tMPFOLIODataGridViewTextBoxColumn";
            this.tMPFOLIODataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPSERIEDataGridViewTextBoxColumn
            // 
            this.tMPSERIEDataGridViewTextBoxColumn.DataPropertyName = "TMP_SERIE";
            this.tMPSERIEDataGridViewTextBoxColumn.HeaderText = "TMP_SERIE";
            this.tMPSERIEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPSERIEDataGridViewTextBoxColumn.Name = "tMPSERIEDataGridViewTextBoxColumn";
            this.tMPSERIEDataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPIDTIPODOCTODataGridViewTextBoxColumn
            // 
            this.tMPIDTIPODOCTODataGridViewTextBoxColumn.DataPropertyName = "TMP_ID_TIPODOCTO";
            this.tMPIDTIPODOCTODataGridViewTextBoxColumn.HeaderText = "TMP_ID_TIPODOCTO";
            this.tMPIDTIPODOCTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPIDTIPODOCTODataGridViewTextBoxColumn.Name = "tMPIDTIPODOCTODataGridViewTextBoxColumn";
            this.tMPIDTIPODOCTODataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPIDPRODUCTODataGridViewTextBoxColumn
            // 
            this.tMPIDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "TMP_ID_PRODUCTO";
            this.tMPIDPRODUCTODataGridViewTextBoxColumn.HeaderText = "TMP_ID_PRODUCTO";
            this.tMPIDPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPIDPRODUCTODataGridViewTextBoxColumn.Name = "tMPIDPRODUCTODataGridViewTextBoxColumn";
            this.tMPIDPRODUCTODataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPCANTIDADDataGridViewTextBoxColumn
            // 
            this.tMPCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "TMP_CANTIDAD";
            this.tMPCANTIDADDataGridViewTextBoxColumn.HeaderText = "TMP_CANTIDAD";
            this.tMPCANTIDADDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPCANTIDADDataGridViewTextBoxColumn.Name = "tMPCANTIDADDataGridViewTextBoxColumn";
            this.tMPCANTIDADDataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPIMPORTEDataGridViewTextBoxColumn
            // 
            this.tMPIMPORTEDataGridViewTextBoxColumn.DataPropertyName = "TMP_IMPORTE";
            this.tMPIMPORTEDataGridViewTextBoxColumn.HeaderText = "TMP_IMPORTE";
            this.tMPIMPORTEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPIMPORTEDataGridViewTextBoxColumn.Name = "tMPIMPORTEDataGridViewTextBoxColumn";
            this.tMPIMPORTEDataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPIVADataGridViewTextBoxColumn
            // 
            this.tMPIVADataGridViewTextBoxColumn.DataPropertyName = "TMP_IVA";
            this.tMPIVADataGridViewTextBoxColumn.HeaderText = "TMP_IVA";
            this.tMPIVADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tMPIVADataGridViewTextBoxColumn.Name = "tMPIVADataGridViewTextBoxColumn";
            this.tMPIVADataGridViewTextBoxColumn.Width = 200;
            // 
            // tMPVENTADETALLEBindingSource
            // 
            this.tMPVENTADETALLEBindingSource.DataMember = "TMPVENTA_DETALLE";
            this.tMPVENTADETALLEBindingSource.DataSource = this.vENTASDataSet3;
            // 
            // vENTASDataSet3
            // 
            this.vENTASDataSet3.DataSetName = "VENTASDataSet3";
            this.vENTASDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Red;
            this.BTNELIMINAR.Location = new System.Drawing.Point(1018, 424);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(112, 61);
            this.BTNELIMINAR.TabIndex = 37;
            this.BTNELIMINAR.Text = "Eliminar";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Location = new System.Drawing.Point(180, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 61);
            this.button2.TabIndex = 36;
            this.button2.Text = "Guardar Venta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::investing.Properties.Resources.VENTAS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // TXTFOLIO
            // 
            this.TXTFOLIO.Location = new System.Drawing.Point(338, 121);
            this.TXTFOLIO.Name = "TXTFOLIO";
            this.TXTFOLIO.Size = new System.Drawing.Size(180, 31);
            this.TXTFOLIO.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 413);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Producto:";
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(228, 476);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(180, 31);
            this.TXTCANTIDAD.TabIndex = 45;
            // 
            // TXTIMPORTE
            // 
            this.TXTIMPORTE.Location = new System.Drawing.Point(616, 411);
            this.TXTIMPORTE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIMPORTE.Name = "TXTIMPORTE";
            this.TXTIMPORTE.Size = new System.Drawing.Size(180, 31);
            this.TXTIMPORTE.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 415);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Importe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 476);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Cantidad";
            // 
            // TXTIVA
            // 
            this.TXTIVA.Location = new System.Drawing.Point(616, 470);
            this.TXTIVA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTIVA.Name = "TXTIVA";
            this.TXTIVA.Size = new System.Drawing.Size(180, 31);
            this.TXTIVA.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 474);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Iva";
            // 
            // DTPFECHA
            // 
            this.DTPFECHA.Location = new System.Drawing.Point(1243, 199);
            this.DTPFECHA.Name = "DTPFECHA";
            this.DTPFECHA.Size = new System.Drawing.Size(200, 31);
            this.DTPFECHA.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1068, 205);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "FECHA";
            // 
            // BTNAGG
            // 
            this.BTNAGG.BackColor = System.Drawing.Color.Chartreuse;
            this.BTNAGG.Location = new System.Drawing.Point(832, 424);
            this.BTNAGG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNAGG.Name = "BTNAGG";
            this.BTNAGG.Size = new System.Drawing.Size(147, 61);
            this.BTNAGG.TabIndex = 50;
            this.BTNAGG.Text = "AGREGAR";
            this.BTNAGG.UseVisualStyleBackColor = false;
            this.BTNAGG.Click += new System.EventHandler(this.BTNAGG_Click);
            // 
            // TXTPRODUCTO
            // 
            this.TXTPRODUCTO.Location = new System.Drawing.Point(228, 406);
            this.TXTPRODUCTO.Name = "TXTPRODUCTO";
            this.TXTPRODUCTO.Size = new System.Drawing.Size(180, 31);
            this.TXTPRODUCTO.TabIndex = 51;
            // 
            // FRMVENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 950);
            this.Controls.Add(this.TXTPRODUCTO);
            this.Controls.Add(this.BTNAGG);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DTPFECHA);
            this.Controls.Add(this.TXTIVA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXTCANTIDAD);
            this.Controls.Add(this.TXTIMPORTE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTFOLIO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DTGVentas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtSerie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CMBtipDocumento);
            this.Controls.Add(this.CMBCliente);
            this.Controls.Add(this.CMBAlmacen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMVENTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FECHA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMVENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMPVENTADETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBtipDocumento;
        private System.Windows.Forms.ComboBox CMBCliente;
        private System.Windows.Forms.ComboBox CMBAlmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTGVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPIDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPIDALMACENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPFOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPSERIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPIDTIPODOCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPIDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPCANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPIMPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMPIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tMPVENTADETALLEBindingSource;
        private VENTASDataSet3 vENTASDataSet3;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXTFOLIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.TextBox TXTIMPORTE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTIVA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTPFECHA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BTNAGG;
        private System.Windows.Forms.TextBox TXTPRODUCTO;
    }
}