namespace investing.FRM
{
    partial class FRMPROVEDORES
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnumext = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtlada = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.txttelefonoc = new System.Windows.Forms.TextBox();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.txtcuentab = new System.Windows.Forms.TextBox();
            this.DTGProveedores = new System.Windows.Forms.DataGridView();
            this.pROIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRONOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRORFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROLADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROTELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRONUMEROEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCTABANCARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROTELEFCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROREGIMENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROVEEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet6 = new investing.VENTASDataSet6();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.pROVEEDORESTableAdapter = new investing.VENTASDataSet6TableAdapters.PROVEEDORESTableAdapter();
            this.CMBREGIMEN = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEDORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "CORREO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "RFC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1190, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "LADA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1190, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "TELEFONO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1192, 327);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "NUMERO EXT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1192, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "CALLE:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(626, 341);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "REGIMEN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(614, 246);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "TELEFONO DE CONTACTO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(614, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "CONTACTO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(614, 95);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "CUENTA BANCARIA:";
            // 
            // txtnumext
            // 
            this.txtnumext.Location = new System.Drawing.Point(1360, 327);
            this.txtnumext.Margin = new System.Windows.Forms.Padding(6);
            this.txtnumext.Name = "txtnumext";
            this.txtnumext.Size = new System.Drawing.Size(196, 31);
            this.txtnumext.TabIndex = 28;
            this.txtnumext.TextChanged += new System.EventHandler(this.txtnumext_TextChanged);
            this.txtnumext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumext_KeyPress);
            // 
            // txtcalle
            // 
            this.txtcalle.Location = new System.Drawing.Point(1360, 243);
            this.txtcalle.Margin = new System.Windows.Forms.Padding(6);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(196, 31);
            this.txtcalle.TabIndex = 27;
            this.txtcalle.TextChanged += new System.EventHandler(this.txtcalle_TextChanged);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(1360, 174);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(6);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(196, 31);
            this.txttelefono.TabIndex = 26;
            this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtlada
            // 
            this.txtlada.Location = new System.Drawing.Point(1360, 89);
            this.txtlada.Margin = new System.Windows.Forms.Padding(6);
            this.txtlada.Name = "txtlada";
            this.txtlada.Size = new System.Drawing.Size(196, 31);
            this.txtlada.TabIndex = 25;
            this.txtlada.TextChanged += new System.EventHandler(this.txtlada_TextChanged);
            this.txtlada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlada_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(372, 174);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(196, 31);
            this.txtnombre.TabIndex = 24;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(372, 313);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(6);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(196, 31);
            this.txtcorreo.TabIndex = 23;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(372, 240);
            this.txtrfc.Margin = new System.Windows.Forms.Padding(6);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(196, 31);
            this.txtrfc.TabIndex = 22;
            this.txtrfc.TextChanged += new System.EventHandler(this.txtrfc_TextChanged);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(372, 92);
            this.TxtId.Margin = new System.Windows.Forms.Padding(6);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(94, 31);
            this.TxtId.TabIndex = 21;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // txttelefonoc
            // 
            this.txttelefonoc.Location = new System.Drawing.Point(944, 252);
            this.txttelefonoc.Margin = new System.Windows.Forms.Padding(6);
            this.txttelefonoc.Name = "txttelefonoc";
            this.txttelefonoc.Size = new System.Drawing.Size(196, 31);
            this.txttelefonoc.TabIndex = 31;
            this.txttelefonoc.TextChanged += new System.EventHandler(this.txttelefonoc_TextChanged);
            this.txttelefonoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefonoc_KeyPress);
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(944, 174);
            this.txtcontacto.Margin = new System.Windows.Forms.Padding(6);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(196, 31);
            this.txtcontacto.TabIndex = 30;
            this.txtcontacto.TextChanged += new System.EventHandler(this.txtcontacto_TextChanged);
            // 
            // txtcuentab
            // 
            this.txtcuentab.Location = new System.Drawing.Point(944, 95);
            this.txtcuentab.Margin = new System.Windows.Forms.Padding(6);
            this.txtcuentab.Name = "txtcuentab";
            this.txtcuentab.Size = new System.Drawing.Size(196, 31);
            this.txtcuentab.TabIndex = 29;
            this.txtcuentab.TextChanged += new System.EventHandler(this.txtcuentab_TextChanged);
            // 
            // DTGProveedores
            // 
            this.DTGProveedores.AutoGenerateColumns = false;
            this.DTGProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROIDDataGridViewTextBoxColumn,
            this.pRONOMBREDataGridViewTextBoxColumn,
            this.pRORFCDataGridViewTextBoxColumn,
            this.pROCORREODataGridViewTextBoxColumn,
            this.pROLADADataGridViewTextBoxColumn,
            this.pROTELEFONODataGridViewTextBoxColumn,
            this.pROCALLEDataGridViewTextBoxColumn,
            this.pRONUMEROEXTDataGridViewTextBoxColumn,
            this.pROCTABANCARIADataGridViewTextBoxColumn,
            this.pROCONTACTODataGridViewTextBoxColumn,
            this.pROTELEFCONTACTODataGridViewTextBoxColumn,
            this.pROREGIMENDataGridViewTextBoxColumn});
            this.DTGProveedores.DataSource = this.pROVEEDORESBindingSource;
            this.DTGProveedores.Location = new System.Drawing.Point(72, 461);
            this.DTGProveedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTGProveedores.Name = "DTGProveedores";
            this.DTGProveedores.RowHeadersWidth = 51;
            this.DTGProveedores.RowTemplate.Height = 24;
            this.DTGProveedores.Size = new System.Drawing.Size(1389, 391);
            this.DTGProveedores.TabIndex = 33;
            // 
            // pROIDDataGridViewTextBoxColumn
            // 
            this.pROIDDataGridViewTextBoxColumn.DataPropertyName = "PRO_ID";
            this.pROIDDataGridViewTextBoxColumn.HeaderText = "PRO_ID";
            this.pROIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROIDDataGridViewTextBoxColumn.Name = "pROIDDataGridViewTextBoxColumn";
            this.pROIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // pRONOMBREDataGridViewTextBoxColumn
            // 
            this.pRONOMBREDataGridViewTextBoxColumn.DataPropertyName = "PRO_NOMBRE";
            this.pRONOMBREDataGridViewTextBoxColumn.HeaderText = "PRO_NOMBRE";
            this.pRONOMBREDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pRONOMBREDataGridViewTextBoxColumn.Name = "pRONOMBREDataGridViewTextBoxColumn";
            this.pRONOMBREDataGridViewTextBoxColumn.Width = 200;
            // 
            // pRORFCDataGridViewTextBoxColumn
            // 
            this.pRORFCDataGridViewTextBoxColumn.DataPropertyName = "PRO_RFC";
            this.pRORFCDataGridViewTextBoxColumn.HeaderText = "PRO_RFC";
            this.pRORFCDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pRORFCDataGridViewTextBoxColumn.Name = "pRORFCDataGridViewTextBoxColumn";
            this.pRORFCDataGridViewTextBoxColumn.Width = 200;
            // 
            // pROCORREODataGridViewTextBoxColumn
            // 
            this.pROCORREODataGridViewTextBoxColumn.DataPropertyName = "PRO_CORREO";
            this.pROCORREODataGridViewTextBoxColumn.HeaderText = "PRO_CORREO";
            this.pROCORREODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROCORREODataGridViewTextBoxColumn.Name = "pROCORREODataGridViewTextBoxColumn";
            this.pROCORREODataGridViewTextBoxColumn.Width = 200;
            // 
            // pROLADADataGridViewTextBoxColumn
            // 
            this.pROLADADataGridViewTextBoxColumn.DataPropertyName = "PRO_LADA";
            this.pROLADADataGridViewTextBoxColumn.HeaderText = "PRO_LADA";
            this.pROLADADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROLADADataGridViewTextBoxColumn.Name = "pROLADADataGridViewTextBoxColumn";
            this.pROLADADataGridViewTextBoxColumn.Width = 200;
            // 
            // pROTELEFONODataGridViewTextBoxColumn
            // 
            this.pROTELEFONODataGridViewTextBoxColumn.DataPropertyName = "PRO_TELEFONO";
            this.pROTELEFONODataGridViewTextBoxColumn.HeaderText = "PRO_TELEFONO";
            this.pROTELEFONODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROTELEFONODataGridViewTextBoxColumn.Name = "pROTELEFONODataGridViewTextBoxColumn";
            this.pROTELEFONODataGridViewTextBoxColumn.Width = 200;
            // 
            // pROCALLEDataGridViewTextBoxColumn
            // 
            this.pROCALLEDataGridViewTextBoxColumn.DataPropertyName = "PRO_CALLE";
            this.pROCALLEDataGridViewTextBoxColumn.HeaderText = "PRO_CALLE";
            this.pROCALLEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROCALLEDataGridViewTextBoxColumn.Name = "pROCALLEDataGridViewTextBoxColumn";
            this.pROCALLEDataGridViewTextBoxColumn.Width = 200;
            // 
            // pRONUMEROEXTDataGridViewTextBoxColumn
            // 
            this.pRONUMEROEXTDataGridViewTextBoxColumn.DataPropertyName = "PRO_NUMERO_EXT";
            this.pRONUMEROEXTDataGridViewTextBoxColumn.HeaderText = "PRO_NUMERO_EXT";
            this.pRONUMEROEXTDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pRONUMEROEXTDataGridViewTextBoxColumn.Name = "pRONUMEROEXTDataGridViewTextBoxColumn";
            this.pRONUMEROEXTDataGridViewTextBoxColumn.Width = 200;
            // 
            // pROCTABANCARIADataGridViewTextBoxColumn
            // 
            this.pROCTABANCARIADataGridViewTextBoxColumn.DataPropertyName = "PRO_CTABANCARIA";
            this.pROCTABANCARIADataGridViewTextBoxColumn.HeaderText = "PRO_CTABANCARIA";
            this.pROCTABANCARIADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROCTABANCARIADataGridViewTextBoxColumn.Name = "pROCTABANCARIADataGridViewTextBoxColumn";
            this.pROCTABANCARIADataGridViewTextBoxColumn.Width = 200;
            // 
            // pROCONTACTODataGridViewTextBoxColumn
            // 
            this.pROCONTACTODataGridViewTextBoxColumn.DataPropertyName = "PRO_CONTACTO";
            this.pROCONTACTODataGridViewTextBoxColumn.HeaderText = "PRO_CONTACTO";
            this.pROCONTACTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROCONTACTODataGridViewTextBoxColumn.Name = "pROCONTACTODataGridViewTextBoxColumn";
            this.pROCONTACTODataGridViewTextBoxColumn.Width = 200;
            // 
            // pROTELEFCONTACTODataGridViewTextBoxColumn
            // 
            this.pROTELEFCONTACTODataGridViewTextBoxColumn.DataPropertyName = "PRO_TELEF_CONTACTO";
            this.pROTELEFCONTACTODataGridViewTextBoxColumn.HeaderText = "PRO_TELEF_CONTACTO";
            this.pROTELEFCONTACTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROTELEFCONTACTODataGridViewTextBoxColumn.Name = "pROTELEFCONTACTODataGridViewTextBoxColumn";
            this.pROTELEFCONTACTODataGridViewTextBoxColumn.Width = 200;
            // 
            // pROREGIMENDataGridViewTextBoxColumn
            // 
            this.pROREGIMENDataGridViewTextBoxColumn.DataPropertyName = "PRO_REGIMEN";
            this.pROREGIMENDataGridViewTextBoxColumn.HeaderText = "PRO_REGIMEN";
            this.pROREGIMENDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.pROREGIMENDataGridViewTextBoxColumn.Name = "pROREGIMENDataGridViewTextBoxColumn";
            this.pROREGIMENDataGridViewTextBoxColumn.Width = 200;
            // 
            // pROVEEDORESBindingSource
            // 
            this.pROVEEDORESBindingSource.DataMember = "PROVEEDORES";
            this.pROVEEDORESBindingSource.DataSource = this.vENTASDataSet6;
            // 
            // vENTASDataSet6
            // 
            this.vENTASDataSet6.DataSetName = "VENTASDataSet6";
            this.vENTASDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.Red;
            this.BTNDelete.Location = new System.Drawing.Point(429, 371);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(112, 50);
            this.BTNDelete.TabIndex = 35;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNInsert
            // 
            this.BTNInsert.BackColor = System.Drawing.Color.Chartreuse;
            this.BTNInsert.Location = new System.Drawing.Point(173, 371);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(228, 50);
            this.BTNInsert.TabIndex = 34;
            this.BTNInsert.Text = "Guardar/Actualizar";
            this.BTNInsert.UseVisualStyleBackColor = false;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // pROVEEDORESTableAdapter
            // 
            this.pROVEEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // CMBREGIMEN
            // 
            this.CMBREGIMEN.FormattingEnabled = true;
            this.CMBREGIMEN.Location = new System.Drawing.Point(944, 327);
            this.CMBREGIMEN.Name = "CMBREGIMEN";
            this.CMBREGIMEN.Size = new System.Drawing.Size(196, 33);
            this.CMBREGIMEN.TabIndex = 36;
            this.CMBREGIMEN.SelectedIndexChanged += new System.EventHandler(this.CMBREGIMEN_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::investing.Properties.Resources.PROVEEDOR;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // FRMPROVEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 866);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CMBREGIMEN);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.DTGProveedores);
            this.Controls.Add(this.txttelefonoc);
            this.Controls.Add(this.txtcontacto);
            this.Controls.Add(this.txtcuentab);
            this.Controls.Add(this.txtnumext);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtlada);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRMPROVEDORES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMPROVEDORES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMPROVEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVEEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnumext;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtlada;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox txttelefonoc;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.TextBox txtcuentab;
        private System.Windows.Forms.DataGridView DTGProveedores;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNInsert;
        private VENTASDataSet6 vENTASDataSet6;
        private System.Windows.Forms.BindingSource pROVEEDORESBindingSource;
        private VENTASDataSet6TableAdapters.PROVEEDORESTableAdapter pROVEEDORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRONOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRORFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROLADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROTELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCALLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRONUMEROEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCTABANCARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROTELEFCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROREGIMENDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CMBREGIMEN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}