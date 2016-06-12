namespace QuanLyThuVien.v1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.buttonBook = new System.Windows.Forms.RibbonButton();
            this.buttonAuthor = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.buttonReader = new System.Windows.Forms.RibbonButton();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.buttonBorrow = new System.Windows.Forms.RibbonButton();
            this.buttonReturn = new System.Windows.Forms.RibbonButton();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.buttonListBook = new System.Windows.Forms.RibbonButton();
            this.buttonOverTime = new System.Windows.Forms.RibbonButton();
            this.buttonBorrowReader = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.buttonReport = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.buttonBackup = new System.Windows.Forms.RibbonButton();
            this.buttonRestore = new System.Windows.Forms.RibbonButton();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.menuHome = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.menuInfo = new System.Windows.Forms.RibbonOrbMenuItem();
            this.menuManage = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.menuLogout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.menuExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.AltKey = null;
            this.ribbonSeparator1.CheckedGroup = null;
            this.ribbonSeparator1.Image = null;
            this.ribbonSeparator1.Tag = null;
            this.ribbonSeparator1.Text = null;
            this.ribbonSeparator1.ToolTip = null;
            this.ribbonSeparator1.ToolTipTitle = null;
            this.ribbonSeparator1.Value = null;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "Quản lý";
            this.ribbonTab1.ToolTip = null;
            this.ribbonTab1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab1.ToolTipImage = null;
            this.ribbonTab1.ToolTipTitle = null;
            this.ribbonTab1.Value = null;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.buttonBook);
            this.ribbonPanel1.Items.Add(this.buttonAuthor);
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "Danh mục";
            // 
            // buttonBook
            // 
            this.buttonBook.AltKey = null;
            this.buttonBook.CheckedGroup = null;
            this.buttonBook.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonBook.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonBook.Image")));
            this.buttonBook.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonBook.SmallImage")));
            this.buttonBook.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonBook.Tag = null;
            this.buttonBook.Text = "Sách";
            this.buttonBook.ToolTip = null;
            this.buttonBook.ToolTipTitle = null;
            this.buttonBook.Value = null;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.AltKey = null;
            this.buttonAuthor.CheckedGroup = null;
            this.buttonAuthor.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonAuthor.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonAuthor.Image = ((System.Drawing.Image)(resources.GetObject("buttonAuthor.Image")));
            this.buttonAuthor.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonAuthor.SmallImage")));
            this.buttonAuthor.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonAuthor.Tag = null;
            this.buttonAuthor.Text = "Tác giả";
            this.buttonAuthor.ToolTip = null;
            this.buttonAuthor.ToolTipTitle = null;
            this.buttonAuthor.Value = null;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.buttonReader);
            this.ribbonPanel2.Tag = null;
            this.ribbonPanel2.Text = "Độc giả";
            // 
            // buttonReader
            // 
            this.buttonReader.AltKey = null;
            this.buttonReader.CheckedGroup = null;
            this.buttonReader.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonReader.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonReader.Image")));
            this.buttonReader.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonReader.SmallImage")));
            this.buttonReader.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonReader.Tag = null;
            this.buttonReader.Text = "Độc giả";
            this.buttonReader.ToolTip = null;
            this.buttonReader.ToolTipTitle = null;
            this.buttonReader.Value = null;
            this.buttonReader.Click += new System.EventHandler(this.buttonReader_Click);
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Tag = null;
            this.ribbonTab2.Text = "Nghiệp vụ";
            this.ribbonTab2.ToolTip = null;
            this.ribbonTab2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab2.ToolTipImage = null;
            this.ribbonTab2.ToolTipTitle = null;
            this.ribbonTab2.Value = null;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.buttonBorrow);
            this.ribbonPanel3.Items.Add(this.buttonReturn);
            this.ribbonPanel3.Tag = null;
            this.ribbonPanel3.Text = "Mượn, trả sách";
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.AltKey = null;
            this.buttonBorrow.CheckedGroup = null;
            this.buttonBorrow.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonBorrow.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonBorrow.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrow.Image")));
            this.buttonBorrow.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonBorrow.SmallImage")));
            this.buttonBorrow.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonBorrow.Tag = null;
            this.buttonBorrow.Text = "Mượn sách";
            this.buttonBorrow.ToolTip = null;
            this.buttonBorrow.ToolTipTitle = null;
            this.buttonBorrow.Value = null;
            // 
            // buttonReturn
            // 
            this.buttonReturn.AltKey = null;
            this.buttonReturn.CheckedGroup = null;
            this.buttonReturn.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonReturn.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonReturn.Image = ((System.Drawing.Image)(resources.GetObject("buttonReturn.Image")));
            this.buttonReturn.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonReturn.SmallImage")));
            this.buttonReturn.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonReturn.Tag = null;
            this.buttonReturn.Text = "Trả sách";
            this.buttonReturn.ToolTip = null;
            this.buttonReturn.ToolTipTitle = null;
            this.buttonReturn.Value = null;
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Panels.Add(this.ribbonPanel5);
            this.ribbonTab3.Panels.Add(this.ribbonPanel6);
            this.ribbonTab3.Tag = null;
            this.ribbonTab3.Text = "Thống kê, Báo cáo";
            this.ribbonTab3.ToolTip = null;
            this.ribbonTab3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab3.ToolTipImage = null;
            this.ribbonTab3.ToolTipTitle = null;
            this.ribbonTab3.Value = null;
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.buttonListBook);
            this.ribbonPanel5.Items.Add(this.buttonOverTime);
            this.ribbonPanel5.Items.Add(this.buttonBorrowReader);
            this.ribbonPanel5.Tag = null;
            this.ribbonPanel5.Text = "Thống kê";
            // 
            // buttonListBook
            // 
            this.buttonListBook.AltKey = null;
            this.buttonListBook.CheckedGroup = null;
            this.buttonListBook.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonListBook.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonListBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonListBook.Image")));
            this.buttonListBook.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.buttonListBook.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonListBook.SmallImage")));
            this.buttonListBook.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonListBook.Tag = null;
            this.buttonListBook.Text = "Sách mượn ";
            this.buttonListBook.ToolTip = null;
            this.buttonListBook.ToolTipTitle = null;
            this.buttonListBook.Value = null;
            // 
            // buttonOverTime
            // 
            this.buttonOverTime.AltKey = null;
            this.buttonOverTime.CheckedGroup = null;
            this.buttonOverTime.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonOverTime.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonOverTime.Image = ((System.Drawing.Image)(resources.GetObject("buttonOverTime.Image")));
            this.buttonOverTime.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonOverTime.SmallImage")));
            this.buttonOverTime.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonOverTime.Tag = null;
            this.buttonOverTime.Text = "Quá hạn";
            this.buttonOverTime.ToolTip = null;
            this.buttonOverTime.ToolTipTitle = null;
            this.buttonOverTime.Value = null;
            // 
            // buttonBorrowReader
            // 
            this.buttonBorrowReader.AltKey = null;
            this.buttonBorrowReader.CheckedGroup = null;
            this.buttonBorrowReader.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonBorrowReader.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonBorrowReader.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrowReader.Image")));
            this.buttonBorrowReader.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonBorrowReader.SmallImage")));
            this.buttonBorrowReader.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonBorrowReader.Tag = null;
            this.buttonBorrowReader.Text = "Người mượn";
            this.buttonBorrowReader.ToolTip = null;
            this.buttonBorrowReader.ToolTipTitle = null;
            this.buttonBorrowReader.Value = null;
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.buttonReport);
            this.ribbonPanel6.Tag = null;
            this.ribbonPanel6.Text = "Báo cáo";
            // 
            // buttonReport
            // 
            this.buttonReport.AltKey = null;
            this.buttonReport.CheckedGroup = null;
            this.buttonReport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonReport.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonReport.Image")));
            this.buttonReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonReport.SmallImage")));
            this.buttonReport.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonReport.Tag = null;
            this.buttonReport.Text = "Báo cáo";
            this.buttonReport.ToolTip = null;
            this.buttonReport.ToolTipTitle = null;
            this.buttonReport.Value = null;
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Panels.Add(this.ribbonPanel4);
            this.ribbonTab4.Tag = null;
            this.ribbonTab4.Text = "Sao lưu và khôi phục";
            this.ribbonTab4.ToolTip = null;
            this.ribbonTab4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab4.ToolTipImage = null;
            this.ribbonTab4.ToolTipTitle = null;
            this.ribbonTab4.Value = null;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.buttonBackup);
            this.ribbonPanel4.Items.Add(this.buttonRestore);
            this.ribbonPanel4.Tag = null;
            this.ribbonPanel4.Text = "Sao lưu và khôi phục";
            // 
            // buttonBackup
            // 
            this.buttonBackup.AltKey = null;
            this.buttonBackup.CheckedGroup = null;
            this.buttonBackup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonBackup.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonBackup.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackup.Image")));
            this.buttonBackup.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonBackup.SmallImage")));
            this.buttonBackup.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonBackup.Tag = null;
            this.buttonBackup.Text = "Sao lưu";
            this.buttonBackup.ToolTip = null;
            this.buttonBackup.ToolTipTitle = null;
            this.buttonBackup.Value = null;
            // 
            // buttonRestore
            // 
            this.buttonRestore.AltKey = null;
            this.buttonRestore.CheckedGroup = null;
            this.buttonRestore.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.buttonRestore.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.buttonRestore.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestore.Image")));
            this.buttonRestore.SmallImage = ((System.Drawing.Image)(resources.GetObject("buttonRestore.SmallImage")));
            this.buttonRestore.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.buttonRestore.Tag = null;
            this.buttonRestore.Text = "Khôi phục";
            this.buttonRestore.ToolTip = null;
            this.buttonRestore.ToolTipTitle = null;
            this.buttonRestore.Value = null;
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator1);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.menuHome);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator2);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.menuInfo);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.menuManage);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator3);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.menuLogout);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.menuExit);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItemsCaption = null;
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 301);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "Hệ thống";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.CheckedGroup = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.QuickAcessToolbar.Value = null;
            this.ribbon1.Size = new System.Drawing.Size(797, 155);
            this.ribbon1.TabIndex = 2;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.TabSpacing = 6;
            this.ribbon1.Text = "ribbon1";
            // 
            // menuHome
            // 
            this.menuHome.AltKey = null;
            this.menuHome.CheckedGroup = null;
            this.menuHome.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.menuHome.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.menuHome.Image = ((System.Drawing.Image)(resources.GetObject("menuHome.Image")));
            this.menuHome.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuHome.SmallImage")));
            this.menuHome.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.menuHome.Tag = null;
            this.menuHome.Text = "Trang chính";
            this.menuHome.ToolTip = null;
            this.menuHome.ToolTipTitle = null;
            this.menuHome.Value = null;
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.AltKey = null;
            this.ribbonSeparator2.CheckedGroup = null;
            this.ribbonSeparator2.Image = null;
            this.ribbonSeparator2.Tag = null;
            this.ribbonSeparator2.Text = null;
            this.ribbonSeparator2.ToolTip = null;
            this.ribbonSeparator2.ToolTipTitle = null;
            this.ribbonSeparator2.Value = null;
            // 
            // menuInfo
            // 
            this.menuInfo.AltKey = null;
            this.menuInfo.CheckedGroup = null;
            this.menuInfo.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.menuInfo.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.menuInfo.Image = ((System.Drawing.Image)(resources.GetObject("menuInfo.Image")));
            this.menuInfo.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuInfo.SmallImage")));
            this.menuInfo.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.menuInfo.Tag = null;
            this.menuInfo.Text = "Thông tin cá nhân";
            this.menuInfo.ToolTip = null;
            this.menuInfo.ToolTipTitle = null;
            this.menuInfo.Value = null;
            // 
            // menuManage
            // 
            this.menuManage.AltKey = null;
            this.menuManage.CheckedGroup = null;
            this.menuManage.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.menuManage.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.menuManage.Image = ((System.Drawing.Image)(resources.GetObject("menuManage.Image")));
            this.menuManage.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuManage.SmallImage")));
            this.menuManage.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.menuManage.Tag = null;
            this.menuManage.Text = "Quản lý nhân viên";
            this.menuManage.ToolTip = null;
            this.menuManage.ToolTipTitle = null;
            this.menuManage.Value = null;
            // 
            // ribbonSeparator3
            // 
            this.ribbonSeparator3.AltKey = null;
            this.ribbonSeparator3.CheckedGroup = null;
            this.ribbonSeparator3.Image = null;
            this.ribbonSeparator3.Tag = null;
            this.ribbonSeparator3.Text = null;
            this.ribbonSeparator3.ToolTip = null;
            this.ribbonSeparator3.ToolTipTitle = null;
            this.ribbonSeparator3.Value = null;
            // 
            // menuLogout
            // 
            this.menuLogout.AltKey = null;
            this.menuLogout.CheckedGroup = null;
            this.menuLogout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.menuLogout.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.menuLogout.Image = ((System.Drawing.Image)(resources.GetObject("menuLogout.Image")));
            this.menuLogout.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuLogout.SmallImage")));
            this.menuLogout.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.menuLogout.Tag = null;
            this.menuLogout.Text = "Đăng xuất";
            this.menuLogout.ToolTip = null;
            this.menuLogout.ToolTipTitle = null;
            this.menuLogout.Value = null;
            // 
            // menuExit
            // 
            this.menuExit.AltKey = null;
            this.menuExit.CheckedGroup = null;
            this.menuExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.menuExit.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("menuExit.SmallImage")));
            this.menuExit.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.menuExit.Tag = null;
            this.menuExit.Text = "Thoát";
            this.menuExit.ToolTip = null;
            this.menuExit.ToolTipTitle = null;
            this.menuExit.Value = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Text = "Quản lý thư viện v.1 ";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonButton buttonBook;
        private System.Windows.Forms.RibbonButton buttonAuthor;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton buttonReader;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton buttonBorrow;
        private System.Windows.Forms.RibbonButton buttonReturn;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton buttonBackup;
        private System.Windows.Forms.RibbonButton buttonRestore;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton buttonListBook;
        private System.Windows.Forms.RibbonButton buttonOverTime;
        private System.Windows.Forms.RibbonButton buttonBorrowReader;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton buttonReport;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonOrbMenuItem menuHome;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonOrbMenuItem menuInfo;
        private System.Windows.Forms.RibbonOrbMenuItem menuManage;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator3;
        private System.Windows.Forms.RibbonOrbMenuItem menuLogout;
        private System.Windows.Forms.RibbonOrbMenuItem menuExit;
    }
}