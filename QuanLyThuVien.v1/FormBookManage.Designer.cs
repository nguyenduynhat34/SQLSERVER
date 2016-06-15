using System.Windows.Forms;

namespace QuanLyThuVien.v1
{
    partial class FormBookManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookManage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxBookSize = new System.Windows.Forms.TextBox();
            this.textBoxBookContent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerBookPublish = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPublishTime = new System.Windows.Forms.TextBox();
            this.textBoxBookPages = new System.Windows.Forms.TextBox();
            this.textBoxBookCost = new System.Windows.Forms.TextBox();
            this.textBoxPublishHouse = new System.Windows.Forms.TextBox();
            this.textBoxLangID = new System.Windows.Forms.TextBox();
            this.textBoxBookTypeID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.buttonBookEdit = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.pictureBoxBookCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đầu sách ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khổ sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nội dung";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(295, 20);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(170, 20);
            this.textBoxBookID.TabIndex = 5;
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(295, 51);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(170, 20);
            this.textBoxBookName.TabIndex = 6;
            // 
            // textBoxBookSize
            // 
            this.textBoxBookSize.Location = new System.Drawing.Point(295, 86);
            this.textBoxBookSize.Name = "textBoxBookSize";
            this.textBoxBookSize.Size = new System.Drawing.Size(170, 20);
            this.textBoxBookSize.TabIndex = 7;
            // 
            // textBoxBookContent
            // 
            this.textBoxBookContent.Location = new System.Drawing.Point(295, 115);
            this.textBoxBookContent.Multiline = true;
            this.textBoxBookContent.Name = "textBoxBookContent";
            this.textBoxBookContent.Size = new System.Drawing.Size(170, 38);
            this.textBoxBookContent.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày xuất bản";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePickerBookPublish
            // 
            this.dateTimePickerBookPublish.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBookPublish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBookPublish.Location = new System.Drawing.Point(295, 192);
            this.dateTimePickerBookPublish.Name = "dateTimePickerBookPublish";
            this.dateTimePickerBookPublish.Size = new System.Drawing.Size(170, 20);
            this.dateTimePickerBookPublish.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lần xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số trang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "NXB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mã ngôn ngữ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mã thể loại";
            // 
            // textBoxPublishTime
            // 
            this.textBoxPublishTime.Location = new System.Drawing.Point(654, 25);
            this.textBoxPublishTime.Name = "textBoxPublishTime";
            this.textBoxPublishTime.Size = new System.Drawing.Size(146, 20);
            this.textBoxPublishTime.TabIndex = 17;
            // 
            // textBoxBookPages
            // 
            this.textBoxBookPages.Location = new System.Drawing.Point(654, 55);
            this.textBoxBookPages.Name = "textBoxBookPages";
            this.textBoxBookPages.Size = new System.Drawing.Size(146, 20);
            this.textBoxBookPages.TabIndex = 18;
            // 
            // textBoxBookCost
            // 
            this.textBoxBookCost.Location = new System.Drawing.Point(654, 83);
            this.textBoxBookCost.Name = "textBoxBookCost";
            this.textBoxBookCost.Size = new System.Drawing.Size(146, 20);
            this.textBoxBookCost.TabIndex = 19;
            // 
            // textBoxPublishHouse
            // 
            this.textBoxPublishHouse.Location = new System.Drawing.Point(654, 112);
            this.textBoxPublishHouse.Name = "textBoxPublishHouse";
            this.textBoxPublishHouse.Size = new System.Drawing.Size(146, 20);
            this.textBoxPublishHouse.TabIndex = 20;
            // 
            // textBoxLangID
            // 
            this.textBoxLangID.Location = new System.Drawing.Point(654, 143);
            this.textBoxLangID.Name = "textBoxLangID";
            this.textBoxLangID.Size = new System.Drawing.Size(146, 20);
            this.textBoxLangID.TabIndex = 21;
            // 
            // textBoxBookTypeID
            // 
            this.textBoxBookTypeID.Location = new System.Drawing.Point(654, 175);
            this.textBoxBookTypeID.Name = "textBoxBookTypeID";
            this.textBoxBookTypeID.Size = new System.Drawing.Size(146, 20);
            this.textBoxBookTypeID.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 189);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 20);
            this.textBox1.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách"});
            this.comboBox1.Location = new System.Drawing.Point(494, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(725, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Mã tác giả";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 34;
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteBook.Image")));
            this.buttonDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteBook.Location = new System.Drawing.Point(759, 232);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBook.TabIndex = 32;
            this.buttonDeleteBook.Text = "Xóa";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveBook.Image")));
            this.buttonSaveBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveBook.Location = new System.Drawing.Point(436, 232);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveBook.TabIndex = 31;
            this.buttonSaveBook.Text = "Lưu";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            // 
            // buttonBookEdit
            // 
            this.buttonBookEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonBookEdit.Image")));
            this.buttonBookEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBookEdit.Location = new System.Drawing.Point(304, 232);
            this.buttonBookEdit.Name = "buttonBookEdit";
            this.buttonBookEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonBookEdit.TabIndex = 30;
            this.buttonBookEdit.Text = "Sửa";
            this.buttonBookEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddBook.Image")));
            this.buttonAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddBook.Location = new System.Drawing.Point(178, 232);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 29;
            this.buttonAddBook.Text = "   Thêm";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchBook.Image")));
            this.buttonSearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchBook.Location = new System.Drawing.Point(634, 280);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchBook.TabIndex = 27;
            this.buttonSearchBook.Text = "  Tìm kiếm";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBookCover
            // 
            this.pictureBoxBookCover.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxBookCover.Location = new System.Drawing.Point(22, 13);
            this.pictureBoxBookCover.Name = "pictureBoxBookCover";
            this.pictureBoxBookCover.Size = new System.Drawing.Size(134, 162);
            this.pictureBoxBookCover.TabIndex = 1;
            this.pictureBoxBookCover.TabStop = false;
            this.pictureBoxBookCover.DoubleClick += new System.EventHandler(this.pictureBoxBookCover_DoubleClick);
            this.pictureBoxBookCover.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // FormBookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 528);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonSaveBook);
            this.Controls.Add(this.buttonBookEdit);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxBookTypeID);
            this.Controls.Add(this.textBoxLangID);
            this.Controls.Add(this.textBoxPublishHouse);
            this.Controls.Add(this.textBoxBookCost);
            this.Controls.Add(this.textBoxBookPages);
            this.Controls.Add(this.textBoxPublishTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerBookPublish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBookContent);
            this.Controls.Add(this.textBoxBookSize);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxBookCover);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookManage";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.FormBookManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBookCover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxBookSize;
        private System.Windows.Forms.TextBox textBoxBookContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookPublish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPublishTime;
        private System.Windows.Forms.TextBox textBoxBookPages;
        private System.Windows.Forms.TextBox textBoxBookCost;
        private System.Windows.Forms.TextBox textBoxPublishHouse;
        private System.Windows.Forms.TextBox textBoxLangID;
        private System.Windows.Forms.TextBox textBoxBookTypeID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonBookEdit;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
    }
}