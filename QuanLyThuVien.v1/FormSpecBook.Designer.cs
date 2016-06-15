namespace QuanLyThuVien.v1
{
    partial class FormSpecBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.textBoxBookcaseId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.radioButtonOld = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonRentted = new System.Windows.Forms.RadioButton();
            this.radioButtonNotRent = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLTVDataSet = new QuanLyThuVien.v1.QLTVDataSet();
            this.qLTVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNTableAdapter = new QuanLyThuVien.v1.QLTVDataSetTableAdapters.ISBNTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDeleteReader = new System.Windows.Forms.Button();
            this.buttonSaveReader = new System.Windows.Forms.Button();
            this.buttonReaderEdit = new System.Windows.Forms.Button();
            this.buttonAddReader = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đầu sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cho mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã ngăn tủ";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(129, 22);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(273, 20);
            this.textBoxISBN.TabIndex = 5;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(129, 54);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(273, 20);
            this.textBoxBookID.TabIndex = 7;
            // 
            // textBoxBookcaseId
            // 
            this.textBoxBookcaseId.Location = new System.Drawing.Point(519, 54);
            this.textBoxBookcaseId.Name = "textBoxBookcaseId";
            this.textBoxBookcaseId.Size = new System.Drawing.Size(273, 20);
            this.textBoxBookcaseId.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNew);
            this.panel1.Controls.Add(this.radioButtonOld);
            this.panel1.Location = new System.Drawing.Point(129, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 24);
            this.panel1.TabIndex = 35;
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Location = new System.Drawing.Point(14, 5);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(42, 17);
            this.radioButtonNew.TabIndex = 32;
            this.radioButtonNew.TabStop = true;
            this.radioButtonNew.Text = "Mới";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            // 
            // radioButtonOld
            // 
            this.radioButtonOld.AutoSize = true;
            this.radioButtonOld.Location = new System.Drawing.Point(94, 5);
            this.radioButtonOld.Name = "radioButtonOld";
            this.radioButtonOld.Size = new System.Drawing.Size(38, 17);
            this.radioButtonOld.TabIndex = 33;
            this.radioButtonOld.TabStop = true;
            this.radioButtonOld.Text = "Cũ";
            this.radioButtonOld.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonRentted);
            this.panel2.Controls.Add(this.radioButtonNotRent);
            this.panel2.Location = new System.Drawing.Point(519, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 24);
            this.panel2.TabIndex = 36;
            // 
            // radioButtonRentted
            // 
            this.radioButtonRentted.AutoSize = true;
            this.radioButtonRentted.Location = new System.Drawing.Point(14, 5);
            this.radioButtonRentted.Name = "radioButtonRentted";
            this.radioButtonRentted.Size = new System.Drawing.Size(68, 17);
            this.radioButtonRentted.TabIndex = 32;
            this.radioButtonRentted.TabStop = true;
            this.radioButtonRentted.Text = "Đã mượn";
            this.radioButtonRentted.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotRent
            // 
            this.radioButtonNotRent.AutoSize = true;
            this.radioButtonNotRent.Location = new System.Drawing.Point(94, 5);
            this.radioButtonNotRent.Name = "radioButtonNotRent";
            this.radioButtonNotRent.Size = new System.Drawing.Size(50, 17);
            this.radioButtonNotRent.TabIndex = 33;
            this.radioButtonNotRent.TabStop = true;
            this.radioButtonNotRent.Text = "Chưa";
            this.radioButtonNotRent.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 181);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTVDataSetBindingSource
            // 
            this.qLTVDataSetBindingSource.DataSource = this.qLTVDataSet;
            this.qLTVDataSetBindingSource.Position = 0;
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
            this.buttonCancel.Location = new System.Drawing.Point(697, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchBook.Image")));
            this.buttonSearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchBook.Location = new System.Drawing.Point(606, 180);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchBook.TabIndex = 41;
            this.buttonSearchBook.Text = "  Tìm kiếm";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách"});
            this.comboBox1.Location = new System.Drawing.Point(466, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 20);
            this.textBox2.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Tìm kiếm";
            // 
            // buttonDeleteReader
            // 
            this.buttonDeleteReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteReader.Image")));
            this.buttonDeleteReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteReader.Location = new System.Drawing.Point(678, 128);
            this.buttonDeleteReader.Name = "buttonDeleteReader";
            this.buttonDeleteReader.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteReader.TabIndex = 46;
            this.buttonDeleteReader.Text = "Xóa";
            this.buttonDeleteReader.UseVisualStyleBackColor = true;
            // 
            // buttonSaveReader
            // 
            this.buttonSaveReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveReader.Image")));
            this.buttonSaveReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveReader.Location = new System.Drawing.Point(355, 128);
            this.buttonSaveReader.Name = "buttonSaveReader";
            this.buttonSaveReader.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveReader.TabIndex = 45;
            this.buttonSaveReader.Text = "Lưu";
            this.buttonSaveReader.UseVisualStyleBackColor = true;
            // 
            // buttonReaderEdit
            // 
            this.buttonReaderEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonReaderEdit.Image")));
            this.buttonReaderEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReaderEdit.Location = new System.Drawing.Point(223, 128);
            this.buttonReaderEdit.Name = "buttonReaderEdit";
            this.buttonReaderEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonReaderEdit.TabIndex = 44;
            this.buttonReaderEdit.Text = "Sửa";
            this.buttonReaderEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAddReader
            // 
            this.buttonAddReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddReader.Image")));
            this.buttonAddReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddReader.Location = new System.Drawing.Point(97, 128);
            this.buttonAddReader.Name = "buttonAddReader";
            this.buttonAddReader.Size = new System.Drawing.Size(75, 23);
            this.buttonAddReader.TabIndex = 43;
            this.buttonAddReader.Text = "   Thêm";
            this.buttonAddReader.UseVisualStyleBackColor = true;
            // 
            // FormSpecBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 410);
            this.Controls.Add(this.buttonDeleteReader);
            this.Controls.Add(this.buttonSaveReader);
            this.Controls.Add(this.buttonReaderEdit);
            this.Controls.Add(this.buttonAddReader);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxBookcaseId);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSpecBook";
            this.Text = "FormSpecBook";
            this.Load += new System.EventHandler(this.FormSpecBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.TextBox textBoxBookcaseId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.RadioButton radioButtonOld;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonRentted;
        private System.Windows.Forms.RadioButton radioButtonNotRent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLTVDataSetBindingSource;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource iSBNBindingSource;
        private QLTVDataSetTableAdapters.ISBNTableAdapter iSBNTableAdapter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDeleteReader;
        private System.Windows.Forms.Button buttonSaveReader;
        private System.Windows.Forms.Button buttonReaderEdit;
        private System.Windows.Forms.Button buttonAddReader;
    }
}