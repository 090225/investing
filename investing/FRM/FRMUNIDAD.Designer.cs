namespace investing.FRM
{
    partial class FRMUNIDAD
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.DTGUNIDAD = new System.Windows.Forms.DataGridView();
            this.uNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet7 = new investing.VENTASDataSet7();
            this.uNIDADTableAdapter = new investing.VENTASDataSet7TableAdapters.UNIDADTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGUNIDAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "UNIDAD";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(444, 163);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdesc.MaxLength = 100;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(148, 31);
            this.txtdesc.TabIndex = 8;
            this.txtdesc.TextChanged += new System.EventHandler(this.txtdesc_TextChanged);
            this.txtdesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "DESCRIPCION:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(444, 67);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 31);
            this.txtid.TabIndex = 6;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // BTNInsert
            // 
            this.BTNInsert.BackColor = System.Drawing.Color.LawnGreen;
            this.BTNInsert.Location = new System.Drawing.Point(140, 239);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(237, 64);
            this.BTNInsert.TabIndex = 28;
            this.BTNInsert.Text = "Guardar";
            this.BTNInsert.UseVisualStyleBackColor = false;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // DTGUNIDAD
            // 
            this.DTGUNIDAD.AllowUserToAddRows = false;
            this.DTGUNIDAD.AllowUserToDeleteRows = false;
            this.DTGUNIDAD.AutoGenerateColumns = false;
            this.DTGUNIDAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGUNIDAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNIDDataGridViewTextBoxColumn,
            this.uNDESCRIPCIONDataGridViewTextBoxColumn});
            this.DTGUNIDAD.DataSource = this.uNIDADBindingSource;
            this.DTGUNIDAD.Location = new System.Drawing.Point(140, 327);
            this.DTGUNIDAD.Name = "DTGUNIDAD";
            this.DTGUNIDAD.ReadOnly = true;
            this.DTGUNIDAD.RowHeadersWidth = 82;
            this.DTGUNIDAD.RowTemplate.Height = 33;
            this.DTGUNIDAD.Size = new System.Drawing.Size(586, 263);
            this.DTGUNIDAD.TabIndex = 31;
            this.DTGUNIDAD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uNIDDataGridViewTextBoxColumn
            // 
            this.uNIDDataGridViewTextBoxColumn.DataPropertyName = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.HeaderText = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.uNIDDataGridViewTextBoxColumn.Name = "uNIDDataGridViewTextBoxColumn";
            this.uNIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // uNDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.Name = "uNDESCRIPCIONDataGridViewTextBoxColumn";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.Width = 200;
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.vENTASDataSet7;
            // 
            // vENTASDataSet7
            // 
            this.vENTASDataSet7.DataSetName = "VENTASDataSet7";
            this.vENTASDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::investing.Properties.Resources.UNIDAD;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnact
            // 
            this.btnact.BackColor = System.Drawing.Color.LawnGreen;
            this.btnact.Location = new System.Drawing.Point(489, 239);
            this.btnact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnact.Name = "btnact";
            this.btnact.Size = new System.Drawing.Size(237, 64);
            this.btnact.TabIndex = 33;
            this.btnact.Text = "Actualizar";
            this.btnact.UseVisualStyleBackColor = false;
            this.btnact.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMUNIDAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 633);
            this.Controls.Add(this.btnact);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DTGUNIDAD);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMUNIDAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMUNIDAD";
            this.Load += new System.EventHandler(this.FRMUNIDAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGUNIDAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.DataGridView DTGUNIDAD;
        private VENTASDataSet7 vENTASDataSet7;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private VENTASDataSet7TableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNDESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnact;
    }
}