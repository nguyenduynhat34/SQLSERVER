using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.mlogin = textBoxUsername.Text;
            Program.password = textBoxPassword.Text;
            if (Program.KetNoi() == 1)
            {
                SqlDataReader reader;
                String spDangNhap = "SP_DANGNHAP";
                SqlCommand cmd = new SqlCommand(
                spDangNhap, Program.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TENLOGIN", Program.mlogin);
                reader = cmd.ExecuteReader();
                reader.Read();
                Program.mHoten = reader.GetString(1);
                Program.mGroup = reader.GetString(2);

                Form2 form = new Form2();
                form.Show();
            };
        }
    }
}
