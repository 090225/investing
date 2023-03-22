namespace investing.FRM
{
    partial class FRMPRODUCTOS
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
            this.BTNInsert = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.vENTASDataSet = new investing.VENTASDataSet();
            this.vENTASDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vENTASDataSet1 = new investing.VENTASDataSet1();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSTableAdapter = new investing.VENTASDataSet1TableAdapters.PRODUCTOSTableAdapter();
            this.pRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDUNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CMBUnidad
            // 
            this.CMBUnidad.FormattingEnabled = true;
            this.CMBUnidad.Location = new System.Drawing.Point(209, 150);
            this.CMBUnidad.Name = "CMBUnidad";
            this.CMBUnidad.Size = new System.Drawing.Size(121, 24);
            this.CMBUnidad.TabIndex = 52;
            // 
            // CMBTipoProducto
            // 
            this.CMBTipoProducto.FormattingEnabled = true;
            this.CMBTipoProducto.Location = new System.Drawing.Point(516, 84);
            this.CMBTipoProducto.Name = "CMBTipoProducto";
            this.CMBTipoProducto.Size = new System.Drawing.Size(121, 24);
            this.CMBTipoProducto.TabIndex = 51;
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(516, 199);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(100, 22);
            this.TxtIva.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "IVA:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(516, 143);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 22);
            this.TxtPrecio.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "PRECIO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "TIPOPRODUCTO:";
            // 
            // TxtStockMaximo
            // 
            this.TxtStockMaximo.Location = new System.Drawing.Point(516, 32);
            this.TxtStockMaximo.Name = "TxtStockMaximo";
            this.TxtStockMaximo.Size = new System.Drawing.Size(100, 22);
            this.TxtStockMaximo.TabIndex = 45;
            // 
            // TxtStockMinimo
            // 
            this.TxtStockMinimo.Location = new System.Drawing.Point(229, 206);
            this.TxtStockMinimo.Name = "TxtStockMinimo";
            this.TxtStockMinimo.Size = new System.Drawing.Size(100, 22);
            this.TxtStockMinimo.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "STOCKMAXIMO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "STOCKMINIMO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "UNIDAD:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(229, 94);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtNombre.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(217, 36);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 37;
            // 
            // BTNInsert
            // 
            this.BTNInsert.Location = new System.Drawing.Point(703, 36);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(73, 31);
            this.BTNInsert.TabIndex = 54;
            this.BTNInsert.Text = "INSERT";
            this.BTNInsert.UseVisualStyleBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(703, 87);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(73, 31);
            this.BTNDelete.TabIndex = 55;
            this.BTNDelete.Text = "DELETE";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(703, 132);
            this.BTNUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(73, 31);
            this.BTNUpdate.TabIndex = 56;
            this.BTNUpdate.Text = "UPDATE";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            // 
            // vENTASDataSet
            // 
            this.vENTASDataSet.DataSetName = "VENTASDataSet";
            this.vENTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASDataSetBindingSource
            // 
            this.vENTASDataSetBindingSource.DataSource = this.vENTASDataSet;
            this.vENTASDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRIDDataGridViewTextBoxColumn,
            this.pRNOMBREDataGridViewTextBoxColumn,
            this.pRIDUNIDADDataGridViewTextBoxColumn,
            this.pRSTOCKMINDataGridViewTextBoxColumn,
            this.pRSTOCKMAXDataGridViewTextBoxColumn,
            this.pRIDTPDataGridViewTextBoxColumn,
            this.pRPRECIODataGridViewTextBoxColumn,
            this.pRIVADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 247);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 192);
            this.dataGridView1.TabIndex = 57;
            // 
            // vENTASDataSet1
            // 
            this.vENTASDataSet1.DataSetName = "VENTASDataSet1";
            this.vENTASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.vENTASDataSet1;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // pRIDDataGridViewTextBoxColumn
            // 
            this.pRIDDataGridViewTextBoxColumn.DataPropertyName = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.HeaderText = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRIDDataGridViewTextBoxColumn.Name = "pRIDDataGridViewTextBoxColumn";
            this.pRIDDataGridViewTextBoxColumn.Width = 125;
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
            // FRMPRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNInsert);
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
            this.Name = "FRMPRODUCTOS";
            this.Text = "FRMPRODUCTOS";
            this.Load += new System.EventHandler(this.FRMPRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
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
        private VENTASDataSet vENTASDataSet;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet1 vENTASDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private VENTASDataSet1TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDUNIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVADataGridViewTextBoxColumn;
    }
}