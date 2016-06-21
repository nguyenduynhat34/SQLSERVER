using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.v1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelStatus.Text = "Welcome " + Program.mHoten + "  Role: " + Program.mGroup;
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormBook))
                {
                    f.Activate();
                    return;
                }
            }
            FormBook formBook = new FormBook();
            formBook.MdiParent = this;
            formBook.Show();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormBookManage))
                {
                    f.Activate();
                    return;
                }
            }
            FormBookManage form = new FormBookManage();
            form.MdiParent = this;
            form.Show();
        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormAuthor))
                {
                    f.Activate();
                    return;
                }
            }
            FormAuthor formAuthor = new FormAuthor();
            formAuthor.MdiParent = this;
            formAuthor.Show();
        }

        private void buttonReader_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormReader))
                {
                    f.Activate();
                    return;
                }
            }
            FormReader formReader = new FormReader();
            formReader.MdiParent = this;
            formReader.Show();
        }

        private void buttonSingleBook_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormSpecBook))
                {
                    f.Activate();
                    return;
                }
            }
            FormSpecBook formSpecBook = new FormSpecBook();
            formSpecBook.MdiParent = this;
            formSpecBook.Show();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(BorrowBook))
                {
                    f.Activate();
                    return;
                }
            }
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.MdiParent = this;
            borrowBook.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FormBookReturn))
                {
                    f.Activate();
                    return;
                }
            }
            FormBookReturn form = new FormBookReturn();
            form.MdiParent = this;
            form.Show();
        }
    }
 }

