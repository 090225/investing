namespace investing.FRM
{
    partial class FRMCLIENTES
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtRfc = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtLada = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.TxtNumeroExt = new System.Windows.Forms.TextBox();
            this.TxtCuentaBancaria = new System.Windows.Forms.TextBox();
            this.TxtContacto = new System.Windows.Forms.TextBox();
            this.TxtTelefonoContacto = new System.Windows.Forms.TextBox();
            this.DTGClientes = new System.Windows.Forms.DataGridView();
            this.cLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLRFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLLADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLTELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNUMEROEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCTABANCARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLTELEFCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLREGIMENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet4 = new investing.VENTASDataSet4();
            this.cLIENTESTableAdapter = new investing.VENTASDataSet4TableAdapters.CLIENTESTableAdapter();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.CMBREGIMEN = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "RFC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "CORREO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1230, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "LADA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1172, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "TELEFONO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1218, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "CALLE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1145, 381);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "NUMERO EXT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "CUENTA BANCARIA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(656, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "CONTACTO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(502, 285);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "TELEFONO DE CONTACTO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(676, 376);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "REGIMEN:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(285, 110);
            this.TxtId.Margin = new System.Windows.Forms.Padding(6);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(196, 31);
            this.TxtId.TabIndex = 13;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // TxtRfc
            // 
            this.TxtRfc.Location = new System.Drawing.Point(285, 291);
            this.TxtRfc.Margin = new System.Windows.Forms.Padding(6);
            this.TxtRfc.Name = "TxtRfc";
            this.TxtRfc.Size = new System.Drawing.Size(196, 31);
            this.TxtRfc.TabIndex = 14;
            this.TxtRfc.TextChanged += new System.EventHandler(this.TxtRfc_TextChanged);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(285, 373);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(6);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(196, 31);
            this.TxtCorreo.TabIndex = 15;
            this.TxtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(285, 199);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(196, 31);
            this.TxtNombre.TabIndex = 16;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtLada
            // 
            this.TxtLada.Location = new System.Drawing.Point(1365, 110);
            this.TxtLada.Margin = new System.Windows.Forms.Padding(6);
            this.TxtLada.Name = "TxtLada";
            this.TxtLada.Size = new System.Drawing.Size(196, 31);
            this.TxtLada.TabIndex = 17;
            this.TxtLada.TextChanged += new System.EventHandler(this.TxtLada_TextChanged);
            this.TxtLada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLada_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(1365, 199);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(6);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(196, 31);
            this.TxtTelefono.TabIndex = 18;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtCalle
            // 
            this.TxtCalle.Location = new System.Drawing.Point(1365, 285);
            this.TxtCalle.Margin = new System.Windows.Forms.Padding(6);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(196, 31);
            this.TxtCalle.TabIndex = 19;
            this.TxtCalle.TextChanged += new System.EventHandler(this.TxtCalle_TextChanged);
            // 
            // TxtNumeroExt
            // 
            this.TxtNumeroExt.Location = new System.Drawing.Point(1365, 367);
            this.TxtNumeroExt.Margin = new System.Windows.Forms.Padding(6);
            this.TxtNumeroExt.Name = "TxtNumeroExt";
            this.TxtNumeroExt.Size = new System.Drawing.Size(196, 31);
            this.TxtNumeroExt.TabIndex = 20;
            this.TxtNumeroExt.TextChanged += new System.EventHandler(this.TxtNumeroExt_TextChanged);
            this.TxtNumeroExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroExt_KeyPress);
            // 
            // TxtCuentaBancaria
            // 
            this.TxtCuentaBancaria.Location = new System.Drawing.Point(887, 107);
            this.TxtCuentaBancaria.Margin = new System.Windows.Forms.Padding(6);
            this.TxtCuentaBancaria.Name = "TxtCuentaBancaria";
            this.TxtCuentaBancaria.Size = new System.Drawing.Size(196, 31);
            this.TxtCuentaBancaria.TabIndex = 21;
            this.TxtCuentaBancaria.TextChanged += new System.EventHandler(this.TxtCuentaBancaria_TextChanged);
            // 
            // TxtContacto
            // 
            this.TxtContacto.Location = new System.Drawing.Point(887, 202);
            this.TxtContacto.Margin = new System.Windows.Forms.Padding(6);
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(196, 31);
            this.TxtContacto.TabIndex = 22;
            this.TxtContacto.TextChanged += new System.EventHandler(this.TxtContacto_TextChanged);
            // 
            // TxtTelefonoContacto
            // 
            this.TxtTelefonoContacto.Location = new System.Drawing.Point(887, 285);
            this.TxtTelefonoContacto.Margin = new System.Windows.Forms.Padding(6);
            this.TxtTelefonoContacto.Name = "TxtTelefonoContacto";
            this.TxtTelefonoContacto.Size = new System.Drawing.Size(196, 31);
            this.TxtTelefonoContacto.TabIndex = 23;
            this.TxtTelefonoContacto.TextChanged += new System.EventHandler(this.TxtTelefonoContacto_TextChanged);
            this.TxtTelefonoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoContacto_KeyPress);
            // 
            // DTGClientes
            // 
            this.DTGClientes.AllowUserToAddRows = false;
            this.DTGClientes.AllowUserToDeleteRows = false;
            this.DTGClientes.AutoGenerateColumns = false;
            this.DTGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIDDataGridViewTextBoxColumn,
            this.cLNOMBREDataGridViewTextBoxColumn,
            this.cLRFCDataGridViewTextBoxColumn,
            this.cLCORREODataGridViewTextBoxColumn,
            this.cLLADADataGridViewTextBoxColumn,
            this.cLTELEFONODataGridViewTextBoxColumn,
            this.cLCALLEDataGridViewTextBoxColumn,
            this.cLNUMEROEXTDataGridViewTextBoxColumn,
            this.cLCTABANCARIADataGridViewTextBoxColumn,
            this.cLCONTACTODataGridViewTextBoxColumn,
            this.cLTELEFCONTACTODataGridViewTextBoxColumn,
            this.cLREGIMENDataGridViewTextBoxColumn});
            this.DTGClientes.DataSource = this.cLIENTESBindingSource;
            this.DTGClientes.Location = new System.Drawing.Point(31, 550);
            this.DTGClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTGClientes.Name = "DTGClientes";
            this.DTGClientes.ReadOnly = true;
            this.DTGClientes.RowHeadersWidth = 51;
            this.DTGClientes.RowTemplate.Height = 24;
            this.DTGClientes.Size = new System.Drawing.Size(1551, 327);
            this.DTGClientes.TabIndex = 28;
            this.DTGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGClientes_CellContentClick);
            // 
            // cLIDDataGridViewTextBoxColumn
            // 
            this.cLIDDataGridViewTextBoxColumn.DataPropertyName = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.HeaderText = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLIDDataGridViewTextBoxColumn.Name = "cLIDDataGridViewTextBoxColumn";
            this.cLIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLNOMBREDataGridViewTextBoxColumn
            // 
            this.cLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "CL_NOMBRE";
            this.cLNOMBREDataGridViewTextBoxColumn.HeaderText = "CL_NOMBRE";
            this.cLNOMBREDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLNOMBREDataGridViewTextBoxColumn.Name = "cLNOMBREDataGridViewTextBoxColumn";
            this.cLNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLNOMBREDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLRFCDataGridViewTextBoxColumn
            // 
            this.cLRFCDataGridViewTextBoxColumn.DataPropertyName = "CL_RFC";
            this.cLRFCDataGridViewTextBoxColumn.HeaderText = "CL_RFC";
            this.cLRFCDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLRFCDataGridViewTextBoxColumn.Name = "cLRFCDataGridViewTextBoxColumn";
            this.cLRFCDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLRFCDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLCORREODataGridViewTextBoxColumn
            // 
            this.cLCORREODataGridViewTextBoxColumn.DataPropertyName = "CL_CORREO";
            this.cLCORREODataGridViewTextBoxColumn.HeaderText = "CL_CORREO";
            this.cLCORREODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLCORREODataGridViewTextBoxColumn.Name = "cLCORREODataGridViewTextBoxColumn";
            this.cLCORREODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLCORREODataGridViewTextBoxColumn.Width = 200;
            // 
            // cLLADADataGridViewTextBoxColumn
            // 
            this.cLLADADataGridViewTextBoxColumn.DataPropertyName = "CL_LADA";
            this.cLLADADataGridViewTextBoxColumn.HeaderText = "CL_LADA";
            this.cLLADADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLLADADataGridViewTextBoxColumn.Name = "cLLADADataGridViewTextBoxColumn";
            this.cLLADADataGridViewTextBoxColumn.ReadOnly = true;
            this.cLLADADataGridViewTextBoxColumn.Width = 200;
            // 
            // cLTELEFONODataGridViewTextBoxColumn
            // 
            this.cLTELEFONODataGridViewTextBoxColumn.DataPropertyName = "CL_TELEFONO";
            this.cLTELEFONODataGridViewTextBoxColumn.HeaderText = "CL_TELEFONO";
            this.cLTELEFONODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLTELEFONODataGridViewTextBoxColumn.Name = "cLTELEFONODataGridViewTextBoxColumn";
            this.cLTELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLTELEFONODataGridViewTextBoxColumn.Width = 200;
            // 
            // cLCALLEDataGridViewTextBoxColumn
            // 
            this.cLCALLEDataGridViewTextBoxColumn.DataPropertyName = "CL_CALLE";
            this.cLCALLEDataGridViewTextBoxColumn.HeaderText = "CL_CALLE";
            this.cLCALLEDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLCALLEDataGridViewTextBoxColumn.Name = "cLCALLEDataGridViewTextBoxColumn";
            this.cLCALLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLCALLEDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLNUMEROEXTDataGridViewTextBoxColumn
            // 
            this.cLNUMEROEXTDataGridViewTextBoxColumn.DataPropertyName = "CL_NUMERO_EXT";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.HeaderText = "CL_NUMERO_EXT";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLNUMEROEXTDataGridViewTextBoxColumn.Name = "cLNUMEROEXTDataGridViewTextBoxColumn";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLNUMEROEXTDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLCTABANCARIADataGridViewTextBoxColumn
            // 
            this.cLCTABANCARIADataGridViewTextBoxColumn.DataPropertyName = "CL_CTABANCARIA";
            this.cLCTABANCARIADataGridViewTextBoxColumn.HeaderText = "CL_CTABANCARIA";
            this.cLCTABANCARIADataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLCTABANCARIADataGridViewTextBoxColumn.Name = "cLCTABANCARIADataGridViewTextBoxColumn";
            this.cLCTABANCARIADataGridViewTextBoxColumn.ReadOnly = true;
            this.cLCTABANCARIADataGridViewTextBoxColumn.Width = 200;
            // 
            // cLCONTACTODataGridViewTextBoxColumn
            // 
            this.cLCONTACTODataGridViewTextBoxColumn.DataPropertyName = "CL_CONTACTO";
            this.cLCONTACTODataGridViewTextBoxColumn.HeaderText = "CL_CONTACTO";
            this.cLCONTACTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLCONTACTODataGridViewTextBoxColumn.Name = "cLCONTACTODataGridViewTextBoxColumn";
            this.cLCONTACTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLCONTACTODataGridViewTextBoxColumn.Width = 200;
            // 
            // cLTELEFCONTACTODataGridViewTextBoxColumn
            // 
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.DataPropertyName = "CL_TELEF_CONTACTO";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.HeaderText = "CL_TELEF_CONTACTO";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.Name = "cLTELEFCONTACTODataGridViewTextBoxColumn";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.Width = 200;
            // 
            // cLREGIMENDataGridViewTextBoxColumn
            // 
            this.cLREGIMENDataGridViewTextBoxColumn.DataPropertyName = "CL_REGIMEN";
            this.cLREGIMENDataGridViewTextBoxColumn.HeaderText = "CL_REGIMEN";
            this.cLREGIMENDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cLREGIMENDataGridViewTextBoxColumn.Name = "cLREGIMENDataGridViewTextBoxColumn";
            this.cLREGIMENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLREGIMENDataGridViewTextBoxColumn.Width = 200;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.vENTASDataSet4;
            // 
            // vENTASDataSet4
            // 
            this.vENTASDataSet4.DataSetName = "VENTASDataSet4";
            this.vENTASDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.Red;
            this.BTNDelete.Location = new System.Drawing.Point(876, 446);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(112, 50);
            this.BTNDelete.TabIndex = 37;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNInsert
            // 
            this.BTNInsert.BackColor = System.Drawing.Color.Chartreuse;
            this.BTNInsert.Location = new System.Drawing.Point(620, 446);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(228, 50);
            this.BTNInsert.TabIndex = 36;
            this.BTNInsert.Text = "Guardar/Actualizar";
            this.BTNInsert.UseVisualStyleBackColor = false;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click_1);
            // 
            // CMBREGIMEN
            // 
            this.CMBREGIMEN.FormattingEnabled = true;
            this.CMBREGIMEN.Location = new System.Drawing.Point(887, 376);
            this.CMBREGIMEN.Name = "CMBREGIMEN";
            this.CMBREGIMEN.Size = new System.Drawing.Size(196, 33);
            this.CMBREGIMEN.TabIndex = 38;
            this.CMBREGIMEN.SelectedIndexChanged += new System.EventHandler(this.CMBREGIMEN_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::investing.Properties.Resources.CLIENTE;
            this.pictureBox1.Location = new System.Drawing.Point(31, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FRMCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2080, 921);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CMBREGIMEN);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.DTGClientes);
            this.Controls.Add(this.TxtTelefonoContacto);
            this.Controls.Add(this.TxtContacto);
            this.Controls.Add(this.TxtCuentaBancaria);
            this.Controls.Add(this.TxtNumeroExt);
            this.Controls.Add(this.TxtCalle);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtLada);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtRfc);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FRMCLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMCLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet4)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtRfc;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtLada;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.TextBox TxtNumeroExt;
        private System.Windows.Forms.TextBox TxtCuentaBancaria;
        private System.Windows.Forms.TextBox TxtContacto;
        private System.Windows.Forms.TextBox TxtTelefonoContacto;
        private System.Windows.Forms.DataGridView DTGClientes;
        private VENTASDataSet4 vENTASDataSet4;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private VENTASDataSet4TableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLRFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLLADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLTELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCALLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNUMEROEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCTABANCARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLTELEFCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLREGIMENDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.ComboBox CMBREGIMEN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}