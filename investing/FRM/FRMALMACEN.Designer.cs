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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTGAlmacen = new System.Windows.Forms.DataGridView();
            this.aLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMACENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet2 = new investing.VENTASDataSet2();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aLMACENESTableAdapter = new investing.VENTASDataSet2TableAdapters.ALMACENESTableAdapter();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ALMACEN";
            // 
            // DTGAlmacen
            // 
            this.DTGAlmacen.AllowUserToAddRows = false;
            this.DTGAlmacen.AllowUserToDeleteRows = false;
            this.DTGAlmacen.AutoGenerateColumns = false;
            this.DTGAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLIDDataGridViewTextBoxColumn,
            this.aLNOMBREDataGridViewTextBoxColumn});
            this.DTGAlmacen.DataSource = this.aLMACENESBindingSource;
            this.DTGAlmacen.Location = new System.Drawing.Point(100, 347);
            this.DTGAlmacen.Name = "DTGAlmacen";
            this.DTGAlmacen.ReadOnly = true;
            this.DTGAlmacen.RowHeadersWidth = 82;
            this.DTGAlmacen.RowTemplate.Height = 33;
            this.DTGAlmacen.Size = new System.Drawing.Size(526, 269);
            this.DTGAlmacen.TabIndex = 3;
            this.DTGAlmacen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGAlmacen_CellClick);
            this.DTGAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGAlmacen_CellContentClick);
            this.DTGAlmacen.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGAlmacen_CellContentDoubleClick);
            this.DTGAlmacen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGAlmacen_CellDoubleClick);
            // 
            // aLIDDataGridViewTextBoxColumn
            // 
            this.aLIDDataGridViewTextBoxColumn.DataPropertyName = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.HeaderText = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.aLIDDataGridViewTextBoxColumn.Name = "aLIDDataGridViewTextBoxColumn";
            this.aLIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // aLNOMBREDataGridViewTextBoxColumn
            // 
            this.aLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.HeaderText = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.aLNOMBREDataGridViewTextBoxColumn.Name = "aLNOMBREDataGridViewTextBoxColumn";
            this.aLNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLNOMBREDataGridViewTextBoxColumn.Width = 200;
            // 
            // aLMACENESBindingSource
            // 
            this.aLMACENESBindingSource.DataMember = "ALMACENES";
            this.aLMACENESBindingSource.DataSource = this.vENTASDataSet2;
            // 
            // vENTASDataSet2
            // 
            this.vENTASDataSet2.DataSetName = "VENTASDataSet2";
            this.vENTASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(272, 115);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(148, 31);
            this.TxtId.TabIndex = 4;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(272, 209);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(148, 31);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // aLMACENESTableAdapter
            // 
            this.aLMACENESTableAdapter.ClearBeforeFill = true;
            // 
            // BTNInsert
            // 
            this.BTNInsert.BackColor = System.Drawing.Color.LawnGreen;
            this.BTNInsert.Location = new System.Drawing.Point(100, 276);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(243, 57);
            this.BTNInsert.TabIndex = 28;
            this.BTNInsert.Text = "Guardar/Actualizar";
            this.BTNInsert.UseVisualStyleBackColor = false;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::investing.Properties.Resources.ALMACEN;
            this.pictureBox1.Location = new System.Drawing.Point(10, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.Red;
            this.BTNDelete.Location = new System.Drawing.Point(440, 276);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(146, 57);
            this.BTNDelete.TabIndex = 29;
            this.BTNDelete.Text = "Eliminar";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // FRMALMACEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.DTGAlmacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMALMACEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FRMALMACEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private VENTASDataSet2 vENTASDataSet2;
        private System.Windows.Forms.BindingSource aLMACENESBindingSource;
        private VENTASDataSet2TableAdapters.ALMACENESTableAdapter aLMACENESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNDelete;
    }
}