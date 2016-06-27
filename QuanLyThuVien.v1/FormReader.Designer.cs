namespace QuanLyThuVien.v1
{
    partial class FormReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReader));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxReaderID = new System.Windows.Forms.TextBox();
            this.textBoxReaderFirstname = new System.Windows.Forms.TextBox();
            this.textBoxReaderLastname = new System.Windows.Forms.TextBox();
            this.textBoxReaderEmail = new System.Windows.Forms.TextBox();
            this.textBoxReaderNumberID = new System.Windows.Forms.TextBox();
            this.textBoxReaderPhone = new System.Windows.Forms.TextBox();
            this.textBoxReaderAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.panelSex = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelActive = new System.Windows.Forms.Panel();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.radioButtonUnActive = new System.Windows.Forms.RadioButton();
            this.dateTimePickerReaderBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeginDay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDay = new System.Windows.Forms.DateTimePicker();
            this.buttonDeleteReader = new System.Windows.Forms.Button();
            this.buttonSaveReader = new System.Windows.Forms.Button();
            this.buttonReaderEdit = new System.Windows.Forms.Button();
            this.buttonAddReader = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearchCancel = new System.Windows.Forms.Button();
            this.buttonSearchReader = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qLTVDataSet = new QuanLyThuVien.v1.QLTVDataSet();
            this.iSBNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNTableAdapter = new QuanLyThuVien.v1.QLTVDataSetTableAdapters.ISBNTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelSex.SuspendLayout();
            this.panelActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số CMND";
            // 
            // textBoxReaderID
            // 
            this.textBoxReaderID.Location = new System.Drawing.Point(202, 11);
            this.textBoxReaderID.Name = "textBoxReaderID";
            this.textBoxReaderID.Size = new System.Drawing.Size(146, 20);
            this.textBoxReaderID.TabIndex = 5;
            // 
            // textBoxReaderFirstname
            // 
            this.textBoxReaderFirstname.Location = new System.Drawing.Point(202, 38);
            this.textBoxReaderFirstname.Name = "textBoxReaderFirstname";
            this.textBoxReaderFirstname.Size = new System.Drawing.Size(146, 20);
            this.textBoxReaderFirstname.TabIndex = 6;
            // 
            // textBoxReaderLastname
            // 
            this.textBoxReaderLastname.Location = new System.Drawing.Point(202, 67);
            this.textBoxReaderLastname.Name = "textBoxReaderLastname";
            this.textBoxReaderLastname.Size = new System.Drawing.Size(146, 20);
            this.textBoxReaderLastname.TabIndex = 7;
            // 
            // textBoxReaderEmail
            // 
            this.textBoxReaderEmail.Location = new System.Drawing.Point(202, 98);
            this.textBoxReaderEmail.Name = "textBoxReaderEmail";
            this.textBoxReaderEmail.Size = new System.Drawing.Size(146, 20);
            this.textBoxReaderEmail.TabIndex = 8;
            // 
            // textBoxReaderNumberID
            // 
            this.textBoxReaderNumberID.Location = new System.Drawing.Point(202, 130);
            this.textBoxReaderNumberID.Name = "textBoxReaderNumberID";
            this.textBoxReaderNumberID.Size = new System.Drawing.Size(146, 20);
            this.textBoxReaderNumberID.TabIndex = 9;
            // 
            // textBoxReaderPhone
            // 
            this.textBoxReaderPhone.Location = new System.Drawing.Point(520, 65);
            this.textBoxReaderPhone.Name = "textBoxReaderPhone";
            this.textBoxReaderPhone.Size = new System.Drawing.Size(146, 20);
            this.textBoxReaderPhone.TabIndex = 16;
            // 
            // textBoxReaderAddress
            // 
            this.textBoxReaderAddress.Location = new System.Drawing.Point(520, 38);
            this.textBoxReaderAddress.Name = "textBoxReaderAddress";
            this.textBoxReaderAddress.Size = new System.Drawing.Size(146, 20);
            this.textBoxReaderAddress.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hoạt động";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày hết hạn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày làm thẻ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Địa chỉ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(135, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Giới tính";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(14, 5);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMale.TabIndex = 32;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Nam";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(94, 5);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(39, 17);
            this.radioButtonFemale.TabIndex = 33;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Nữ";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // panelSex
            // 
            this.panelSex.Controls.Add(this.radioButtonMale);
            this.panelSex.Controls.Add(this.radioButtonFemale);
            this.panelSex.Location = new System.Drawing.Point(202, 156);
            this.panelSex.Name = "panelSex";
            this.panelSex.Size = new System.Drawing.Size(146, 24);
            this.panelSex.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(429, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Ngày sinh";
            // 
            // panelActive
            // 
            this.panelActive.Controls.Add(this.radioButtonActive);
            this.panelActive.Controls.Add(this.radioButtonUnActive);
            this.panelActive.Location = new System.Drawing.Point(520, 156);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(146, 24);
            this.panelActive.TabIndex = 35;
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Location = new System.Drawing.Point(14, 5);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(38, 17);
            this.radioButtonActive.TabIndex = 32;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "Có";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnActive
            // 
            this.radioButtonUnActive.AutoSize = true;
            this.radioButtonUnActive.Location = new System.Drawing.Point(94, 5);
            this.radioButtonUnActive.Name = "radioButtonUnActive";
            this.radioButtonUnActive.Size = new System.Drawing.Size(56, 17);
            this.radioButtonUnActive.TabIndex = 33;
            this.radioButtonUnActive.TabStop = true;
            this.radioButtonUnActive.Text = "Không";
            this.radioButtonUnActive.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReaderBirth
            // 
            this.dateTimePickerReaderBirth.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerReaderBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReaderBirth.Location = new System.Drawing.Point(520, 11);
            this.dateTimePickerReaderBirth.Name = "dateTimePickerReaderBirth";
            this.dateTimePickerReaderBirth.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerReaderBirth.TabIndex = 36;
            // 
            // dateTimePickerBeginDay
            // 
            this.dateTimePickerBeginDay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBeginDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginDay.Location = new System.Drawing.Point(520, 93);
            this.dateTimePickerBeginDay.Name = "dateTimePickerBeginDay";
            this.dateTimePickerBeginDay.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerBeginDay.TabIndex = 37;
            // 
            // dateTimePickerEndDay
            // 
            this.dateTimePickerEndDay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDay.Location = new System.Drawing.Point(520, 122);
            this.dateTimePickerEndDay.Name = "dateTimePickerEndDay";
            this.dateTimePickerEndDay.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerEndDay.TabIndex = 38;
            // 
            // buttonDeleteReader
            // 
            this.buttonDeleteReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteReader.Image")));
            this.buttonDeleteReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteReader.Location = new System.Drawing.Point(673, 203);
            this.buttonDeleteReader.Name = "buttonDeleteReader";
            this.buttonDeleteReader.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteReader.TabIndex = 42;
            this.buttonDeleteReader.Text = "Xóa";
            this.buttonDeleteReader.UseVisualStyleBackColor = true;
            this.buttonDeleteReader.Click += new System.EventHandler(this.buttonDeleteReader_Click);
            // 
            // buttonSaveReader
            // 
            this.buttonSaveReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveReader.Image")));
            this.buttonSaveReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveReader.Location = new System.Drawing.Point(350, 203);
            this.buttonSaveReader.Name = "buttonSaveReader";
            this.buttonSaveReader.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveReader.TabIndex = 41;
            this.buttonSaveReader.Text = "Lưu";
            this.buttonSaveReader.UseVisualStyleBackColor = true;
            this.buttonSaveReader.Click += new System.EventHandler(this.buttonSaveReader_Click);
            // 
            // buttonReaderEdit
            // 
            this.buttonReaderEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonReaderEdit.Image")));
            this.buttonReaderEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReaderEdit.Location = new System.Drawing.Point(218, 203);
            this.buttonReaderEdit.Name = "buttonReaderEdit";
            this.buttonReaderEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonReaderEdit.TabIndex = 40;
            this.buttonReaderEdit.Text = "Sửa";
            this.buttonReaderEdit.UseVisualStyleBackColor = true;
            this.buttonReaderEdit.Click += new System.EventHandler(this.buttonReaderEdit_Click);
            // 
            // buttonAddReader
            // 
            this.buttonAddReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddReader.Image")));
            this.buttonAddReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddReader.Location = new System.Drawing.Point(92, 203);
            this.buttonAddReader.Name = "buttonAddReader";
            this.buttonAddReader.Size = new System.Drawing.Size(75, 23);
            this.buttonAddReader.TabIndex = 39;
            this.buttonAddReader.Text = "   Thêm";
            this.buttonAddReader.UseVisualStyleBackColor = true;
            this.buttonAddReader.Click += new System.EventHandler(this.buttonAddReader_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 295);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(991, 211);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonSearchCancel
            // 
            this.buttonSearchCancel.Location = new System.Drawing.Point(675, 252);
            this.buttonSearchCancel.Name = "buttonSearchCancel";
            this.buttonSearchCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCancel.TabIndex = 48;
            this.buttonSearchCancel.Text = "Hủy";
            this.buttonSearchCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSearchReader
            // 
            this.buttonSearchReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchReader.Image")));
            this.buttonSearchReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchReader.Location = new System.Drawing.Point(584, 252);
            this.buttonSearchReader.Name = "buttonSearchReader";
            this.buttonSearchReader.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchReader.TabIndex = 47;
            this.buttonSearchReader.Text = "  Tìm kiếm";
            this.buttonSearchReader.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã độc giả",
            "Tên độc giả",
            "Số CMND"});
            this.comboBox1.Location = new System.Drawing.Point(444, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(121, 254);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(304, 20);
            this.textBoxSearch.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Tìm kiếm";
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
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(490, 203);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 49;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 518);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearchCancel);
            this.Controls.Add(this.buttonSearchReader);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDeleteReader);
            this.Controls.Add(this.buttonSaveReader);
            this.Controls.Add(this.buttonReaderEdit);
            this.Controls.Add(this.buttonAddReader);
            this.Controls.Add(this.dateTimePickerEndDay);
            this.Controls.Add(this.dateTimePickerBeginDay);
            this.Controls.Add(this.dateTimePickerReaderBirth);
            this.Controls.Add(this.panelActive);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelSex);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxReaderPhone);
            this.Controls.Add(this.textBoxReaderAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxReaderNumberID);
            this.Controls.Add(this.textBoxReaderEmail);
            this.Controls.Add(this.textBoxReaderLastname);
            this.Controls.Add(this.textBoxReaderFirstname);
            this.Controls.Add(this.textBoxReaderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReader";
            this.Load += new System.EventHandler(this.FormReader_Load);
            this.panelSex.ResumeLayout(false);
            this.panelSex.PerformLayout();
            this.panelActive.ResumeLayout(false);
            this.panelActive.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReaderID;
        private System.Windows.Forms.TextBox textBoxReaderFirstname;
        private System.Windows.Forms.TextBox textBoxReaderLastname;
        private System.Windows.Forms.TextBox textBoxReaderEmail;
        private System.Windows.Forms.TextBox textBoxReaderNumberID;
        private System.Windows.Forms.TextBox textBoxReaderPhone;
        private System.Windows.Forms.TextBox textBoxReaderAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Panel panelSex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.RadioButton radioButtonActive;
        private System.Windows.Forms.RadioButton radioButtonUnActive;
        private System.Windows.Forms.DateTimePicker dateTimePickerReaderBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDay;
        private System.Windows.Forms.Button buttonDeleteReader;
        private System.Windows.Forms.Button buttonSaveReader;
        private System.Windows.Forms.Button buttonReaderEdit;
        private System.Windows.Forms.Button buttonAddReader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearchCancel;
        private System.Windows.Forms.Button buttonSearchReader;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label12;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource iSBNBindingSource;
        private QLTVDataSetTableAdapters.ISBNTableAdapter iSBNTableAdapter;
        private System.Windows.Forms.Button buttonCancel;
    }
}