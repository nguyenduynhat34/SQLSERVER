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
    public partial class FormBookReturn : Form
    {
        String readerID;
        DateTime toDay;
        String bookID1;
        String bookID2;
        String bookID3;
        int currentTicketID;
        public FormBookReturn()
        {
            InitializeComponent();
            disableTextBox(true);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void FormBookReturn_Load(object sender, EventArgs e)
        {
            String connectionString = Program.connstr;
            String selectCommand = "Select * from PHIEUMUON";

            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand. These are used to
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;


        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            readerID = textBoxSsearchReaderID.Text;
            String connectionString = Program.connstr;
            String selectCommand = "Select * from PHIEUMUON WHERE MADG = '" + readerID + "'";

            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            
            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand. These are used to
            // update the database.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            // Populate a new data table and bind it to the BindingSource.
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;

                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearAllTextBook();   
            DataSet dtSet;

            currentTicketID = Int32.Parse(dataGridView1.CurrentRow.Cells["MAPHIEU"].Value.ToString());
            String sql = "SELECT MAPHIEU, CT_PHIEUMUON.MASACH, TENSACH, TRA FROM CT_PHIEUMUON, SACH, ISBN WHERE SACH.ISBN = ISBN.ISBN AND CT_PHIEUMUON.MASACH = SACH.MASACH AND MAPHIEU = " + currentTicketID;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.connstr;
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            dtSet = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(dtSet, "BorrowBook");
            adapter.Dispose();
            conn.Close();
            cmd.Dispose();
            DataTable dt = dtSet.Tables["BorrowBook"];

            if (dt.Rows.Count == 1)
            {
                textBoxBookID1.Text = dt.Rows[0][1].ToString();
                textBoxBookName1.Text = dt.Rows[0][2].ToString();
                String state = dt.Rows[0][3].ToString();
                if (state == "True")
                {
                    radioButtonReturned1.Checked = true;
                }
                else
                {
                    radioButtonNotReturn1.Checked = true;
                }




            }
            else if (dt.Rows.Count == 2)
            {
                textBoxBookID1.Text = dt.Rows[0][1].ToString();
                textBoxBookName1.Text = dt.Rows[0][2].ToString();
                String state = dt.Rows[0][3].ToString();
                if (state == "True")
                {
                    radioButtonReturned1.Checked = true;
                }
                else
                {
                    radioButtonNotReturn1.Checked = true;
                }

                textBoxBookID2.Text = dt.Rows[1][1].ToString();
                textBoxBookName2.Text = dt.Rows[1][2].ToString();
                state = dt.Rows[1][3].ToString();
                if (state == "True")
                {
                    radioButtonReturned2.Checked = true;
                }
                else
                {
                    radioButtonNotReturn2.Checked = true;
                }
            }
            else if (dt.Rows.Count == 3)
            {
                textBoxBookID1.Text = dt.Rows[0][1].ToString();
                textBoxBookName1.Text = dt.Rows[0][2].ToString();
                String state = dt.Rows[0][3].ToString();
                if (state == "True")
                {
                    radioButtonReturned1.Checked = true;
                }
                else
                {
                    radioButtonNotReturn1.Checked = true;
                }

                textBoxBookID2.Text = dt.Rows[1][1].ToString();
                textBoxBookName2.Text = dt.Rows[1][2].ToString();
                state = dt.Rows[2][3].ToString();
                if (state == "True")
                {
                    radioButtonReturned2.Checked = true;
                }
                else
                {
                    radioButtonNotReturn2.Checked = true;
                }

                textBoxBookID3.Text = dt.Rows[2][1].ToString();
                textBoxBookName3.Text = dt.Rows[2][2].ToString();
                state = dt.Rows[2][3].ToString();
                if (state == "True")
                {
                    radioButtonReturned3.Checked = true;
                }
                else
                {
                    radioButtonNotReturn3.Checked = true;
                }
            }
            else
            {
                textBoxBookID1.Text = "";
                textBoxBookID2.Text = "";
                textBoxBookID2.Text = "";
                textBoxBookName1.Text = "";
                textBoxBookName2.Text = "";
                textBoxBookName3.Text = "";
                radioButtonNotReturn1.Checked = false;
                radioButtonNotReturn2.Checked = false;
                radioButtonNotReturn3.Checked = false;
                radioButtonReturned1.Checked = false;
                radioButtonReturned2.Checked = false;
                radioButtonReturned3.Checked = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bookID1 = textBoxBookID1.Text;
            bookID2 = textBoxBookID2.Text;
            bookID3 = textBoxBookID3.Text;
            int error = 0;
            if(bookID1 != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_TRASACH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_PHIEU", currentTicketID);
                    cmd.Parameters.AddWithValue("@MA_SACH_1", bookID1);
                    cmd.Parameters.Add("@NGAY_TRA", SqlDbType.DateTime).Value = DateTime.Today;
                    cmd.ExecuteNonQuery();
                } catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show(ex.Message);
                }
            }
            if (bookID2 != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_TRASACH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_PHIEU", currentTicketID);
                    cmd.Parameters.AddWithValue("@MA_SACH_1", bookID2);
                    cmd.Parameters.Add("@NGAY_TRA", SqlDbType.DateTime).Value = DateTime.Today;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show(ex.Message);
                }
            }
            if (bookID3 != "")
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_TRASACH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_PHIEU", currentTicketID);
                    cmd.Parameters.AddWithValue("@MA_SACH_1", bookID3);
                    cmd.Parameters.Add("@NGAY_TRA", SqlDbType.DateTime).Value = DateTime.Today;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    error = 1;
                    MessageBox.Show(ex.Message);
                }

            }

            if(error == 0)
            {
                MessageBox.Show("Lưu thành công");
            }
        }

        void clearAllTextBook()
        {
            textBoxSsearchReaderID.Text = "";
            textBoxBookID1.Text = "";
            textBoxBookID2.Text = "";
            textBoxBookID3.Text = "";
            textBoxBookName1.Text = "";
            textBoxBookName2.Text = "";
            textBoxBookName3.Text = "";
            radioButtonNotReturn1.Checked = false;
            radioButtonNotReturn2.Checked = false;
            radioButtonNotReturn3.Checked = false;
            radioButtonReturned1.Checked = false;
            radioButtonReturned2.Checked = false;
            radioButtonReturned3.Checked = false;
        }

        void disableTextBox(bool bl)
        {
            textBoxBookID1.ReadOnly = true;
            textBoxBookID2.ReadOnly = true;
            textBoxBookID3.ReadOnly = true;
            textBoxBookName1.ReadOnly = true;
            textBoxBookName2.ReadOnly = true;
            textBoxBookName3.ReadOnly = true;
        }


    }
}
