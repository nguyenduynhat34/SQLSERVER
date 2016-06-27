namespace QuanLyThuVien.v1
{
    partial class FormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            this.iSBNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new QuanLyThuVien.v1.QLTVDataSet();
            this.iSBNTableAdapter = new QuanLyThuVien.v1.QLTVDataSetTableAdapters.ISBNTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qLTVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet1 = new QuanLyThuVien.v1.QLTVDataSet();
            this.iSBNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mATLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANGONNGUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHAXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTRANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANXUATBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYXUATBANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hINHANHPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOIDUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHOSACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSACHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBNBindingSource
            // 
            this.iSBNBindingSource.DataMember = "ISBN";
            this.iSBNBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSBNTableAdapter
            // 
            this.iSBNTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(209, 34);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(339, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(719, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "   Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(800, 34);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tác giả",
            "Nhà xuất bản"});
            this.comboBox1.Location = new System.Drawing.Point(569, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // qLTVDataSetBindingSource
            // 
            this.qLTVDataSetBindingSource.DataSource = this.qLTVDataSet;
            this.qLTVDataSetBindingSource.Position = 0;
            // 
            // qLTVDataSet1
            // 
            this.qLTVDataSet1.DataSetName = "QLTVDataSet";
            this.qLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSBNBindingSource1
            // 
            this.iSBNBindingSource1.DataMember = "ISBN";
            this.iSBNBindingSource1.DataSource = this.qLTVDataSet1;
            // 
            // mATLDataGridViewTextBoxColumn
            // 
            this.mATLDataGridViewTextBoxColumn.DataPropertyName = "MATL";
            this.mATLDataGridViewTextBoxColumn.HeaderText = "MATL";
            this.mATLDataGridViewTextBoxColumn.Name = "mATLDataGridViewTextBoxColumn";
            this.mATLDataGridViewTextBoxColumn.Visible = false;
            // 
            // mANGONNGUDataGridViewTextBoxColumn
            // 
            this.mANGONNGUDataGridViewTextBoxColumn.DataPropertyName = "MANGONNGU";
            this.mANGONNGUDataGridViewTextBoxColumn.HeaderText = "MANGONNGU";
            this.mANGONNGUDataGridViewTextBoxColumn.Name = "mANGONNGUDataGridViewTextBoxColumn";
            this.mANGONNGUDataGridViewTextBoxColumn.Visible = false;
            // 
            // nHAXBDataGridViewTextBoxColumn
            // 
            this.nHAXBDataGridViewTextBoxColumn.DataPropertyName = "NHAXB";
            this.nHAXBDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            this.nHAXBDataGridViewTextBoxColumn.Name = "nHAXBDataGridViewTextBoxColumn";
            // 
            // gIADataGridViewTextBoxColumn
            // 
            this.gIADataGridViewTextBoxColumn.DataPropertyName = "GIA";
            this.gIADataGridViewTextBoxColumn.HeaderText = "Giá";
            this.gIADataGridViewTextBoxColumn.Name = "gIADataGridViewTextBoxColumn";
            // 
            // sOTRANGDataGridViewTextBoxColumn
            // 
            this.sOTRANGDataGridViewTextBoxColumn.DataPropertyName = "SOTRANG";
            this.sOTRANGDataGridViewTextBoxColumn.HeaderText = "Số trang";
            this.sOTRANGDataGridViewTextBoxColumn.Name = "sOTRANGDataGridViewTextBoxColumn";
            // 
            // lANXUATBANDataGridViewTextBoxColumn
            // 
            this.lANXUATBANDataGridViewTextBoxColumn.DataPropertyName = "LANXUATBAN";
            this.lANXUATBANDataGridViewTextBoxColumn.HeaderText = "Lần xuất bản";
            this.lANXUATBANDataGridViewTextBoxColumn.Name = "lANXUATBANDataGridViewTextBoxColumn";
            // 
            // nGAYXUATBANDataGridViewTextBoxColumn
            // 
            this.nGAYXUATBANDataGridViewTextBoxColumn.DataPropertyName = "NGAYXUATBAN";
            this.nGAYXUATBANDataGridViewTextBoxColumn.HeaderText = "Ngày xuất bản";
            this.nGAYXUATBANDataGridViewTextBoxColumn.Name = "nGAYXUATBANDataGridViewTextBoxColumn";
            // 
            // hINHANHPATHDataGridViewTextBoxColumn
            // 
            this.hINHANHPATHDataGridViewTextBoxColumn.DataPropertyName = "HINHANHPATH";
            this.hINHANHPATHDataGridViewTextBoxColumn.HeaderText = "HINHANHPATH";
            this.hINHANHPATHDataGridViewTextBoxColumn.Name = "hINHANHPATHDataGridViewTextBoxColumn";
            this.hINHANHPATHDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOIDUNGDataGridViewTextBoxColumn
            // 
            this.nOIDUNGDataGridViewTextBoxColumn.DataPropertyName = "NOIDUNG";
            this.nOIDUNGDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.nOIDUNGDataGridViewTextBoxColumn.Name = "nOIDUNGDataGridViewTextBoxColumn";
            // 
            // kHOSACHDataGridViewTextBoxColumn
            // 
            this.kHOSACHDataGridViewTextBoxColumn.DataPropertyName = "KHOSACH";
            this.kHOSACHDataGridViewTextBoxColumn.HeaderText = "Khổ sách";
            this.kHOSACHDataGridViewTextBoxColumn.Name = "kHOSACHDataGridViewTextBoxColumn";
            // 
            // tENSACHDataGridViewTextBoxColumn
            // 
            this.tENSACHDataGridViewTextBoxColumn.DataPropertyName = "TENSACH";
            this.tENSACHDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tENSACHDataGridViewTextBoxColumn.Name = "tENSACHDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "Mã đầu sách";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.tENSACHDataGridViewTextBoxColumn,
            this.kHOSACHDataGridViewTextBoxColumn,
            this.nOIDUNGDataGridViewTextBoxColumn,
            this.hINHANHPATHDataGridViewTextBoxColumn,
            this.nGAYXUATBANDataGridViewTextBoxColumn,
            this.lANXUATBANDataGridViewTextBoxColumn,
            this.sOTRANGDataGridViewTextBoxColumn,
            this.gIADataGridViewTextBoxColumn,
            this.nHAXBDataGridViewTextBoxColumn,
            this.mANGONNGUDataGridViewTextBoxColumn,
            this.mATLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iSBNBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 267);
            this.dataGridView1.TabIndex = 6;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource iSBNBindingSource;
        private QLTVDataSetTableAdapters.ISBNTableAdapter iSBNTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource qLTVDataSetBindingSource;
        private QLTVDataSet qLTVDataSet1;
        private System.Windows.Forms.BindingSource iSBNBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANGONNGUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHAXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTRANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANXUATBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYXUATBANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hINHANHPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOIDUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kHOSACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSACHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}