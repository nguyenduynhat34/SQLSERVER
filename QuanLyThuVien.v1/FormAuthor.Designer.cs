namespace QuanLyThuVien.v1
{
    partial class FormAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthorName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorAddress = new System.Windows.Forms.TextBox();
            this.textBoxAuthorPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.buttonSaveAuthor = new System.Windows.Forms.Button();
            this.buttonAuthorEdit = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLTVDataSet = new QuanLyThuVien.v1.QLTVDataSet();
            this.iSBNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNTableAdapter = new QuanLyThuVien.v1.QLTVDataSetTableAdapters.ISBNTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên TG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ TG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại TG";
            // 
            // textBoxAuthorName
            // 
            this.textBoxAuthorName.Location = new System.Drawing.Point(287, 42);
            this.textBoxAuthorName.Name = "textBoxAuthorName";
            this.textBoxAuthorName.Size = new System.Drawing.Size(243, 20);
            this.textBoxAuthorName.TabIndex = 3;
            // 
            // textBoxAuthorAddress
            // 
            this.textBoxAuthorAddress.Location = new System.Drawing.Point(287, 81);
            this.textBoxAuthorAddress.Name = "textBoxAuthorAddress";
            this.textBoxAuthorAddress.Size = new System.Drawing.Size(243, 20);
            this.textBoxAuthorAddress.TabIndex = 4;
            // 
            // textBoxAuthorPhone
            // 
            this.textBoxAuthorPhone.Location = new System.Drawing.Point(287, 118);
            this.textBoxAuthorPhone.Name = "textBoxAuthorPhone";
            this.textBoxAuthorPhone.Size = new System.Drawing.Size(243, 20);
            this.textBoxAuthorPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tìm kiếm";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(289, 20);
            this.textBox4.TabIndex = 8;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = global::QuanLyThuVien.v1.Properties.Resources.find16;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(628, 209);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "  Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(709, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã tác giả",
            "Tên tác giả"});
            this.comboBox1.Location = new System.Drawing.Point(480, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteAuthor.Image")));
            this.buttonDeleteAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(683, 160);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAuthor.TabIndex = 36;
            this.buttonDeleteAuthor.Text = "Xóa";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAuthor
            // 
            this.buttonSaveAuthor.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAuthor.Image")));
            this.buttonSaveAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveAuthor.Location = new System.Drawing.Point(360, 160);
            this.buttonSaveAuthor.Name = "buttonSaveAuthor";
            this.buttonSaveAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAuthor.TabIndex = 35;
            this.buttonSaveAuthor.Text = "Lưu";
            this.buttonSaveAuthor.UseVisualStyleBackColor = true;
            // 
            // buttonAuthorEdit
            // 
            this.buttonAuthorEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonAuthorEdit.Image")));
            this.buttonAuthorEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAuthorEdit.Location = new System.Drawing.Point(228, 160);
            this.buttonAuthorEdit.Name = "buttonAuthorEdit";
            this.buttonAuthorEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonAuthorEdit.TabIndex = 34;
            this.buttonAuthorEdit.Text = "Sửa";
            this.buttonAuthorEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddAuthor.Image")));
            this.buttonAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddAuthor.Location = new System.Drawing.Point(102, 160);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAuthor.TabIndex = 33;
            this.buttonAddAuthor.Text = "   Thêm";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 150);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSBNBindingSource
            // 
            this.iSBNBindingSource.DataMember = "ISBN";
            this.iSBNBindingSource.DataSource = this.qLTVDataSet;
            // 
            // iSBNTableAdapter
            // 
            this.iSBNTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mã TG";
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.Location = new System.Drawing.Point(287, 10);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(243, 20);
            this.textBoxAuthorID.TabIndex = 39;
            // 
            // FormAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 415);
            this.Controls.Add(this.textBoxAuthorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDeleteAuthor);
            this.Controls.Add(this.buttonSaveAuthor);
            this.Controls.Add(this.buttonAuthorEdit);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAuthorPhone);
            this.Controls.Add(this.textBoxAuthorAddress);
            this.Controls.Add(this.textBoxAuthorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthor";
            this.Text = "FormAuthor";
            this.Load += new System.EventHandler(this.FormAuthor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.TextBox textBoxAuthorAddress;
        private System.Windows.Forms.TextBox textBoxAuthorPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.Button buttonSaveAuthor;
        private System.Windows.Forms.Button buttonAuthorEdit;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource iSBNBindingSource;
        private QLTVDataSetTableAdapters.ISBNTableAdapter iSBNTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAuthorID;
    }
}