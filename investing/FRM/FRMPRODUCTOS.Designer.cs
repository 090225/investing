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
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CMBUnidad
            // 
            this.CMBUnidad.FormattingEnabled = true;
            this.CMBUnidad.Location = new System.Drawing.Point(313, 235);
            this.CMBUnidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBUnidad.Name = "CMBUnidad";
            this.CMBUnidad.Size = new System.Drawing.Size(180, 33);
            this.CMBUnidad.TabIndex = 52;
            // 
            // CMBTipoProducto
            // 
            this.CMBTipoProducto.FormattingEnabled = true;
            this.CMBTipoProducto.Location = new System.Drawing.Point(774, 132);
            this.CMBTipoProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMBTipoProducto.Name = "CMBTipoProducto";
            this.CMBTipoProducto.Size = new System.Drawing.Size(180, 33);
            this.CMBTipoProducto.TabIndex = 51;
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(774, 311);
            this.TxtIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(148, 31);
            this.TxtIva.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 311);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "IVA:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(774, 224);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(148, 31);
            this.TxtPrecio.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "PRECIO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "TIPOPRODUCTO:";
            // 
            // TxtStockMaximo
            // 
            this.TxtStockMaximo.Location = new System.Drawing.Point(774, 50);
            this.TxtStockMaximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStockMaximo.Name = "TxtStockMaximo";
            this.TxtStockMaximo.Size = new System.Drawing.Size(148, 31);
            this.TxtStockMaximo.TabIndex = 45;
            // 
            // TxtStockMinimo
            // 
            this.TxtStockMinimo.Location = new System.Drawing.Point(344, 322);
            this.TxtStockMinimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStockMinimo.Name = "TxtStockMinimo";
            this.TxtStockMinimo.Size = new System.Drawing.Size(148, 31);
            this.TxtStockMinimo.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "STOCKMAXIMO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "STOCKMINIMO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "UNIDAD:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(344, 147);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(148, 31);
            this.TxtNombre.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(326, 57);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(148, 31);
            this.TxtId.TabIndex = 37;
            // 
            // BTNInsert
            // 
            this.BTNInsert.Location = new System.Drawing.Point(1055, 57);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(109, 49);
            this.BTNInsert.TabIndex = 54;
            this.BTNInsert.Text = "INSERT";
            this.BTNInsert.UseVisualStyleBackColor = true;
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(1055, 136);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(109, 49);
            this.BTNDelete.TabIndex = 55;
            this.BTNDelete.Text = "DELETE";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(1055, 206);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(109, 49);
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
            this.dataGridView1.DataSource = this.vENTASDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(96, 480);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 175);
            this.dataGridView1.TabIndex = 57;
            // 
            // FRMPRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMPRODUCTOS";
            this.Text = "FRMPRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}