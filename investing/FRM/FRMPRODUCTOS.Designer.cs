namespace investing.FRM
{
    partial class W
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
            this.CMBUnidad = new System.Windows.Forms.ComboBox();
            this.CMBTipoProducto = new System.Windows.Forms.ComboBox();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtStockMaximo = new System.Windows.Forms.TextBox();
            this.TxtStockMinimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.pRNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDUNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet1 = new investing.VENTASDataSet1();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.dtgproductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRNOMBREDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDUNIDADDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMINDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMAXDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDTPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRPRECIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet10 = new investing.VENTASDataSet10();
            this.pRODUCTOSTableAdapter = new investing.VENTASDataSet10TableAdapters.PRODUCTOSTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CMBUnidad
            // 
            this.CMBUnidad.FormattingEnabled = true;
            this.CMBUnidad.Location = new System.Drawing.Point(371, 260);
            this.CMBUnidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBUnidad.Name = "CMBUnidad";
            this.CMBUnidad.Size = new System.Drawing.Size(180, 33);
            this.CMBUnidad.TabIndex = 52;
            this.CMBUnidad.SelectedIndexChanged += new System.EventHandler(this.CMBUnidad_SelectedIndexChanged);
            // 
            // CMBTipoProducto
            // 
            this.CMBTipoProducto.FormattingEnabled = true;
            this.CMBTipoProducto.Location = new System.Drawing.Point(831, 157);
            this.CMBTipoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBTipoProducto.Name = "CMBTipoProducto";
            this.CMBTipoProducto.Size = new System.Drawing.Size(180, 33);
            this.CMBTipoProducto.TabIndex = 51;
            this.CMBTipoProducto.SelectedIndexChanged += new System.EventHandler(this.CMBTipoProducto_SelectedIndexChanged);
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(831, 337);
            this.TxtIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIva.MaxLength = 15;
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(148, 31);
            this.TxtIva.TabIndex = 50;
            this.TxtIva.TextChanged += new System.EventHandler(this.TxtIva_TextChanged);
            this.TxtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIva_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 337);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "IVA:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(831, 254);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.MaxLength = 15;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(148, 31);
            this.TxtPrecio.TabIndex = 48;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged_1);
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "PRECIO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "TIPOPRODUCTO:";
            // 
            // TxtStockMaximo
            // 
            this.TxtStockMaximo.Location = new System.Drawing.Point(831, 76);
            this.TxtStockMaximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStockMaximo.MaxLength = 15;
            this.TxtStockMaximo.Name = "TxtStockMaximo";
            this.TxtStockMaximo.Size = new System.Drawing.Size(148, 31);
            this.TxtStockMaximo.TabIndex = 45;
            this.TxtStockMaximo.TextChanged += new System.EventHandler(this.TxtStockMaximo_TextChanged);
            this.TxtStockMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockMaximo_KeyPress);
            // 
            // TxtStockMinimo
            // 
            this.TxtStockMinimo.Location = new System.Drawing.Point(371, 347);
            this.TxtStockMinimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStockMinimo.MaxLength = 15;
            this.TxtStockMinimo.Name = "TxtStockMinimo";
            this.TxtStockMinimo.Size = new System.Drawing.Size(148, 31);
            this.TxtStockMinimo.TabIndex = 44;
            this.TxtStockMinimo.TextChanged += new System.EventHandler(this.TxtStockMinimo_TextChanged);
            this.TxtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockMinimo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "STOCKMAXIMO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "STOCKMINIMO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "UNIDAD:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(371, 175);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(148, 31);
            this.TxtNombre.TabIndex = 40;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(371, 82);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(148, 31);
            this.TxtId.TabIndex = 37;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // pRNOMBREDataGridViewTextBoxColumn
            // 
            this.pRNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.HeaderText = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRNOMBREDataGridViewTextBoxColumn.Name = "pRNOMBREDataGridViewTextBoxColumn";
            this.pRNOMBREDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRIDUNIDADDataGridViewTextBoxColumn
            // 
            this.pRIDUNIDADDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.HeaderText = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRIDUNIDADDataGridViewTextBoxColumn.Name = "pRIDUNIDADDataGridViewTextBoxColumn";
            this.pRIDUNIDADDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRSTOCKMINDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMINDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRSTOCKMINDataGridViewTextBoxColumn.Name = "pRSTOCKMINDataGridViewTextBoxColumn";
            this.pRSTOCKMINDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRSTOCKMAXDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMAXDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRSTOCKMAXDataGridViewTextBoxColumn.Name = "pRSTOCKMAXDataGridViewTextBoxColumn";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRIDTPDataGridViewTextBoxColumn
            // 
            this.pRIDTPDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.HeaderText = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRIDTPDataGridViewTextBoxColumn.Name = "pRIDTPDataGridViewTextBoxColumn";
            this.pRIDTPDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRPRECIODataGridViewTextBoxColumn
            // 
            this.pRPRECIODataGridViewTextBoxColumn.DataPropertyName = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.HeaderText = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRPRECIODataGridViewTextBoxColumn.Name = "pRPRECIODataGridViewTextBoxColumn";
            this.pRPRECIODataGridViewTextBoxColumn.Width = 125;
            // 
            // pRIVADataGridViewTextBoxColumn
            // 
            this.pRIVADataGridViewTextBoxColumn.DataPropertyName = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.HeaderText = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRIVADataGridViewTextBoxColumn.Name = "pRIVADataGridViewTextBoxColumn";
            this.pRIVADataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataSource = this.vENTASDataSet1;
            this.pRODUCTOSBindingSource.Position = 0;
            // 
            // vENTASDataSet1
            // 
            this.vENTASDataSet1.DataSetName = "VENTASDataSet1";
            this.vENTASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.Chartreuse;
            this.BTNGUARDAR.Location = new System.Drawing.Point(371, 419);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(228, 61);
            this.BTNGUARDAR.TabIndex = 60;
            this.BTNGUARDAR.Text = "Guardar";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dtgproductos
            // 
            this.dtgproductos.AutoGenerateColumns = false;
            this.dtgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.pRNOMBREDataGridViewTextBoxColumn1,
            this.pRIDUNIDADDataGridViewTextBoxColumn1,
            this.pRSTOCKMINDataGridViewTextBoxColumn1,
            this.pRSTOCKMAXDataGridViewTextBoxColumn1,
            this.pRIDTPDataGridViewTextBoxColumn1,
            this.pRPRECIODataGridViewTextBoxColumn1,
            this.pRIVADataGridViewTextBoxColumn1});
            this.dtgproductos.DataSource = this.pRODUCTOSBindingSource1;
            this.dtgproductos.Location = new System.Drawing.Point(82, 501);
            this.dtgproductos.Name = "dtgproductos";
            this.dtgproductos.RowHeadersWidth = 82;
            this.dtgproductos.RowTemplate.Height = 33;
            this.dtgproductos.Size = new System.Drawing.Size(1152, 371);
            this.dtgproductos.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PR_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PR_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRNOMBREDataGridViewTextBoxColumn1
            // 
            this.pRNOMBREDataGridViewTextBoxColumn1.DataPropertyName = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn1.HeaderText = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.pRNOMBREDataGridViewTextBoxColumn1.Name = "pRNOMBREDataGridViewTextBoxColumn1";
            this.pRNOMBREDataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRIDUNIDADDataGridViewTextBoxColumn1
            // 
            this.pRIDUNIDADDataGridViewTextBoxColumn1.DataPropertyName = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn1.HeaderText = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.pRIDUNIDADDataGridViewTextBoxColumn1.Name = "pRIDUNIDADDataGridViewTextBoxColumn1";
            this.pRIDUNIDADDataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRSTOCKMINDataGridViewTextBoxColumn1
            // 
            this.pRSTOCKMINDataGridViewTextBoxColumn1.DataPropertyName = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn1.HeaderText = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.pRSTOCKMINDataGridViewTextBoxColumn1.Name = "pRSTOCKMINDataGridViewTextBoxColumn1";
            this.pRSTOCKMINDataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRSTOCKMAXDataGridViewTextBoxColumn1
            // 
            this.pRSTOCKMAXDataGridViewTextBoxColumn1.DataPropertyName = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn1.HeaderText = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.pRSTOCKMAXDataGridViewTextBoxColumn1.Name = "pRSTOCKMAXDataGridViewTextBoxColumn1";
            this.pRSTOCKMAXDataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRIDTPDataGridViewTextBoxColumn1
            // 
            this.pRIDTPDataGridViewTextBoxColumn1.DataPropertyName = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn1.HeaderText = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.pRIDTPDataGridViewTextBoxColumn1.Name = "pRIDTPDataGridViewTextBoxColumn1";
            this.pRIDTPDataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRPRECIODataGridViewTextBoxColumn1
            // 
            this.pRPRECIODataGridViewTextBoxColumn1.DataPropertyName = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn1.HeaderText = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.pRPRECIODataGridViewTextBoxColumn1.Name = "pRPRECIODataGridViewTextBoxColumn1";
            this.pRPRECIODataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRIVADataGridViewTextBoxColumn1
            // 
            this.pRIVADataGridViewTextBoxColumn1.DataPropertyName = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn1.HeaderText = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.pRIVADataGridViewTextBoxColumn1.Name = "pRIVADataGridViewTextBoxColumn1";
            this.pRIVADataGridViewTextBoxColumn1.Width = 200;
            // 
            // pRODUCTOSBindingSource1
            // 
            this.pRODUCTOSBindingSource1.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource1.DataSource = this.vENTASDataSet10;
            // 
            // vENTASDataSet10
            // 
            this.vENTASDataSet10.DataSetName = "VENTASDataSet10";
            this.vENTASDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::investing.Properties.Resources.COMPRAS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnactualizar.Location = new System.Drawing.Point(710, 419);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(228, 61);
            this.btnactualizar.TabIndex = 65;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // W
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 943);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgproductos);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.CMBUnidad);
            this.Controls.Add(this.CMBTipoProducto);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtStockMaximo);
            this.Controls.Add(this.TxtStockMinimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtId);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "W";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMPRODUCTOS";
            this.Load += new System.EventHandler(this.FRMPRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBUnidad;
        private System.Windows.Forms.ComboBox CMBTipoProducto;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtStockMaximo;
        private System.Windows.Forms.TextBox TxtStockMinimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.BindingSource vENTASDataSetBindingSource;
    
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet1 vENTASDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
 
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDUNIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.DataGridView dtgproductos;
        private VENTASDataSet10 vENTASDataSet10;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
        private VENTASDataSet10TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNOMBREDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDUNIDADDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMINDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMAXDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDTPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRPRECIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVADataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnactualizar;
    }
}