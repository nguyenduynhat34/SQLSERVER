namespace QuanLyThuVien.v1
{
    partial class BorrowBook
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
            this.textBoxTicketID = new System.Windows.Forms.TextBox();
            this.textBoxReaderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonReadInLib = new System.Windows.Forms.RadioButton();
            this.radioButtonBorrow = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBorrowDay = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLTVDataSet = new QuanLyThuVien.v1.QLTVDataSet();
            this.iSBNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNTableAdapter = new QuanLyThuVien.v1.QLTVDataSetTableAdapters.ISBNTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBookID1 = new System.Windows.Forms.TextBox();
            this.textBoxBookName1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxBookName2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBookID2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBookName3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBookID3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonNewBook1 = new System.Windows.Forms.RadioButton();
            this.radioButtonOldBook1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButtonNewBook2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOldBook2 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonNewBook3 = new System.Windows.Forms.RadioButton();
            this.radioButtonOldBook3 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu";
            // 
            // textBoxTicketID
            // 
            this.textBoxTicketID.Location = new System.Drawing.Point(151, 26);
            this.textBoxTicketID.Name = "textBoxTicketID";
            this.textBoxTicketID.Size = new System.Drawing.Size(200, 20);
            this.textBoxTicketID.TabIndex = 1;
            // 
            // textBoxReaderID
            // 
            this.textBoxReaderID.Location = new System.Drawing.Point(151, 65);
            this.textBoxReaderID.Name = "textBoxReaderID";
            this.textBoxReaderID.Size = new System.Drawing.Size(200, 20);
            this.textBoxReaderID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hình thức";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày mượn";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(151, 170);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmpID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonReadInLib);
            this.panel1.Controls.Add(this.radioButtonBorrow);
            this.panel1.Location = new System.Drawing.Point(151, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 24);
            this.panel1.TabIndex = 36;
            // 
            // radioButtonReadInLib
            // 
            this.radioButtonReadInLib.AutoSize = true;
            this.radioButtonReadInLib.Location = new System.Drawing.Point(14, 5);
            this.radioButtonReadInLib.Name = "radioButtonReadInLib";
            this.radioButtonReadInLib.Size = new System.Drawing.Size(45, 17);
            this.radioButtonReadInLib.TabIndex = 32;
            this.radioButtonReadInLib.TabStop = true;
            this.radioButtonReadInLib.Text = "Đọc";
            this.radioButtonReadInLib.UseVisualStyleBackColor = true;
            // 
            // radioButtonBorrow
            // 
            this.radioButtonBorrow.AutoSize = true;
            this.radioButtonBorrow.Location = new System.Drawing.Point(94, 5);
            this.radioButtonBorrow.Name = "radioButtonBorrow";
            this.radioButtonBorrow.Size = new System.Drawing.Size(52, 17);
            this.radioButtonBorrow.TabIndex = 33;
            this.radioButtonBorrow.TabStop = true;
            this.radioButtonBorrow.Text = "Mượn";
            this.radioButtonBorrow.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBorrowDay
            // 
            this.dateTimePickerBorrowDay.CustomFormat = "đ/MM/yyyy";
            this.dateTimePickerBorrowDay.Location = new System.Drawing.Point(151, 135);
            this.dateTimePickerBorrowDay.Name = "dateTimePickerBorrowDay";
            this.dateTimePickerBorrowDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBorrowDay.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textBoxBookName3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBoxBookID3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxBookName2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxBookID2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.textBoxBookName1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxBookID1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(565, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 457);
            this.panel2.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 184);
            this.dataGridView1.TabIndex = 39;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Sách ";
            // 
            // textBoxBookID1
            // 
            this.textBoxBookID1.Location = new System.Drawing.Point(115, 34);
            this.textBoxBookID1.Name = "textBoxBookID1";
            this.textBoxBookID1.Size = new System.Drawing.Size(209, 20);
            this.textBoxBookID1.TabIndex = 1;
            // 
            // textBoxBookName1
            // 
            this.textBoxBookName1.Location = new System.Drawing.Point(115, 66);
            this.textBoxBookName1.Name = "textBoxBookName1";
            this.textBoxBookName1.Size = new System.Drawing.Size(209, 20);
            this.textBoxBookName1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên sách";
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::QuanLyThuVien.v1.Properties.Resources.save16;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(104, 407);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(215, 407);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxBookName2
            // 
            this.textBoxBookName2.Location = new System.Drawing.Point(115, 196);
            this.textBoxBookName2.Name = "textBoxBookName2";
            this.textBoxBookName2.Size = new System.Drawing.Size(209, 20);
            this.textBoxBookName2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tên sách";
            // 
            // textBoxBookID2
            // 
            this.textBoxBookID2.Location = new System.Drawing.Point(115, 164);
            this.textBoxBookID2.Name = "textBoxBookID2";
            this.textBoxBookID2.Size = new System.Drawing.Size(209, 20);
            this.textBoxBookID2.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã Sách ";
            // 
            // textBoxBookName3
            // 
            this.textBoxBookName3.Location = new System.Drawing.Point(110, 317);
            this.textBoxBookName3.Name = "textBoxBookName3";
            this.textBoxBookName3.Size = new System.Drawing.Size(209, 20);
            this.textBoxBookName3.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tên sách";
            // 
            // textBoxBookID3
            // 
            this.textBoxBookID3.Location = new System.Drawing.Point(110, 285);
            this.textBoxBookID3.Name = "textBoxBookID3";
            this.textBoxBookID3.Size = new System.Drawing.Size(209, 20);
            this.textBoxBookID3.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mã Sách ";
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyThuVien.v1.Properties.Resources.edit16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(196, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyThuVien.v1.Properties.Resources.Delete_icon16;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(339, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tìm kiếm";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(85, 258);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(280, 20);
            this.textBoxSearch.TabIndex = 44;
            // 
            // button4
            // 
            this.button4.Image = global::QuanLyThuVien.v1.Properties.Resources.find16;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(383, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Tìm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyThuVien.v1.Properties.Resources.add_2_icon16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(48, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "  Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tình trạng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonNewBook1);
            this.panel3.Controls.Add(this.radioButtonOldBook1);
            this.panel3.Location = new System.Drawing.Point(115, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 24);
            this.panel3.TabIndex = 37;
            // 
            // radioButtonNewBook1
            // 
            this.radioButtonNewBook1.AutoSize = true;
            this.radioButtonNewBook1.Location = new System.Drawing.Point(14, 5);
            this.radioButtonNewBook1.Name = "radioButtonNewBook1";
            this.radioButtonNewBook1.Size = new System.Drawing.Size(42, 17);
            this.radioButtonNewBook1.TabIndex = 32;
            this.radioButtonNewBook1.TabStop = true;
            this.radioButtonNewBook1.Text = "Mới";
            this.radioButtonNewBook1.UseVisualStyleBackColor = true;
            // 
            // radioButtonOldBook1
            // 
            this.radioButtonOldBook1.AutoSize = true;
            this.radioButtonOldBook1.Location = new System.Drawing.Point(94, 5);
            this.radioButtonOldBook1.Name = "radioButtonOldBook1";
            this.radioButtonOldBook1.Size = new System.Drawing.Size(38, 17);
            this.radioButtonOldBook1.TabIndex = 33;
            this.radioButtonOldBook1.TabStop = true;
            this.radioButtonOldBook1.Text = "Cũ";
            this.radioButtonOldBook1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButtonNewBook2);
            this.panel4.Controls.Add(this.radioButtonOldBook2);
            this.panel4.Location = new System.Drawing.Point(115, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 24);
            this.panel4.TabIndex = 39;
            // 
            // radioButtonNewBook2
            // 
            this.radioButtonNewBook2.AutoSize = true;
            this.radioButtonNewBook2.Location = new System.Drawing.Point(14, 5);
            this.radioButtonNewBook2.Name = "radioButtonNewBook2";
            this.radioButtonNewBook2.Size = new System.Drawing.Size(42, 17);
            this.radioButtonNewBook2.TabIndex = 32;
            this.radioButtonNewBook2.TabStop = true;
            this.radioButtonNewBook2.Text = "Mới";
            this.radioButtonNewBook2.UseVisualStyleBackColor = true;
            // 
            // radioButtonOldBook2
            // 
            this.radioButtonOldBook2.AutoSize = true;
            this.radioButtonOldBook2.Location = new System.Drawing.Point(94, 5);
            this.radioButtonOldBook2.Name = "radioButtonOldBook2";
            this.radioButtonOldBook2.Size = new System.Drawing.Size(38, 17);
            this.radioButtonOldBook2.TabIndex = 33;
            this.radioButtonOldBook2.TabStop = true;
            this.radioButtonOldBook2.Text = "Cũ";
            this.radioButtonOldBook2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tình trạng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButtonNewBook3);
            this.panel5.Controls.Add(this.radioButtonOldBook3);
            this.panel5.Location = new System.Drawing.Point(110, 350);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 24);
            this.panel5.TabIndex = 41;
            // 
            // radioButtonNewBook3
            // 
            this.radioButtonNewBook3.AutoSize = true;
            this.radioButtonNewBook3.Location = new System.Drawing.Point(14, 5);
            this.radioButtonNewBook3.Name = "radioButtonNewBook3";
            this.radioButtonNewBook3.Size = new System.Drawing.Size(42, 17);
            this.radioButtonNewBook3.TabIndex = 32;
            this.radioButtonNewBook3.TabStop = true;
            this.radioButtonNewBook3.Text = "Mới";
            this.radioButtonNewBook3.UseVisualStyleBackColor = true;
            // 
            // radioButtonOldBook3
            // 
            this.radioButtonOldBook3.AutoSize = true;
            this.radioButtonOldBook3.Location = new System.Drawing.Point(94, 5);
            this.radioButtonOldBook3.Name = "radioButtonOldBook3";
            this.radioButtonOldBook3.Size = new System.Drawing.Size(38, 17);
            this.radioButtonOldBook3.TabIndex = 33;
            this.radioButtonOldBook3.TabStop = true;
            this.radioButtonOldBook3.Text = "Cũ";
            this.radioButtonOldBook3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Tình trạng";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(464, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 501);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePickerBorrowDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxEmpID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxReaderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTicketID);
            this.Controls.Add(this.label1);
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTicketID;
        private System.Windows.Forms.TextBox textBoxReaderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonReadInLib;
        private System.Windows.Forms.RadioButton radioButtonBorrow;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource iSBNBindingSource;
        private QLTVDataSetTableAdapters.ISBNTableAdapter iSBNTableAdapter;
        private System.Windows.Forms.TextBox textBoxBookName3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBookID3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBookName2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBookID2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxBookName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBookID1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonNewBook3;
        private System.Windows.Forms.RadioButton radioButtonOldBook3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButtonNewBook2;
        private System.Windows.Forms.RadioButton radioButtonOldBook2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonNewBook1;
        private System.Windows.Forms.RadioButton radioButtonOldBook1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
    }
}