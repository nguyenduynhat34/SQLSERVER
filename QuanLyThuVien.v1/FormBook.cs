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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet1.ISBN' table. You can move, or remove it, as needed.
            this.iSBNTableAdapter.Fill(this.qLTVDataSet1.ISBN);
            // TODO: This line of code loads data into the 'qLTVDataSet.ISBN' table. You can move, or remove it, as needed.
            this.iSBNTableAdapter.Fill(this.qLTVDataSet.ISBN);

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
