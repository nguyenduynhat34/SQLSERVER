using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.v1
{
    public partial class BorrowBook : Form
    {
        String ticketID;
        String readerID;
        bool borrowWay;
        String empID;
        String bookID1;
        String bookID2;
        String bookID3;
        String bookName1;
        String bookName2;
        String bookName3;

        DateTime borrowDate;

        bool readInLib;
        bool bookNew1;
        bool bookNew2;
        bool bookNew3;

        SqlDataReader reader;
        DataSet dtSet;
        int value;
        public BorrowBook()
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
            buttonSave.Visible = false;
            buttonCancel.Visible = false;

            dateTimePickerBorrowDay.Value = DateTime.Today;
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            // Specify a connection string. Replace the given value with a 
            // valid connection string for a Northwind SQL Server sample
            // database accessible to your system.
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


        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
            buttonAddTicket.Visible = false;
            buttonEditTicket.Visible = false;

            disableTextBox(false);
            textBoxTicketID.ReadOnly = true;

            value = 1;

            String sql = "SELECT TOP 1 MAPHIEU FROM PHIEUMUON ORDER BY MAPHIEU DESC";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.connstr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataReader dbreader = cmd.ExecuteReader();
            if (dbreader.HasRows)
            {
                dbreader.Read();

                var tckID = dbreader.GetSqlValue(0);
                //String lastTicketID = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["MAPHIEU"].Value.ToString();
                //int TckID = Int32.Parse(lastTicketID) + 1;
                tckID = Int32.Parse(tckID.ToString());
                tckID = (int)tckID + 1;
                textBoxTicketID.Text = tckID.ToString();
            }
        }

        private void buttonEditTicket_Click(object sender, EventArgs e)
        {
            buttonSave.Visible = true;
            buttonCancel.Visible = true;
            buttonAddTicket.Visible = false;
            buttonEditTicket.Visible = false;
            value = 2;
        }

        private void buttonDeleteTicket_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ticketID = textBoxTicketID.Text;
            readerID = textBoxReaderID.Text;
            borrowWay = radioButtonBorrow.Checked;
            borrowDate = dateTimePickerBorrowDay.Value;
            empID = textBoxEmpID.Text;

            bookID1 = textBoxBookID1.Text;
            bookID2 = textBoxBookID2.Text;
            bookID3 = textBoxBookID3.Text;
            bookNew1 = radioButtonNewBook1.Checked;
            bookNew2 = radioButtonNewBook2.Checked;
            bookNew3 = radioButtonNewBook3.Checked;

            if (value == 1)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Program.connstr;
                conn.Open();
                SqlTransaction Mytransaction;
                Mytransaction = conn.BeginTransaction();
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_THEMPHIEUMUON", conn, Mytransaction);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_PHIEU", ticketID);
                    cmd.Parameters.AddWithValue("@MA_DOC_GIA", readerID);
                    cmd.Parameters.AddWithValue("@HINH_THUC", borrowWay);
                    cmd.Parameters.Add("@NGAY_MUON", SqlDbType.DateTime).Value = borrowDate;
                    cmd.Parameters.AddWithValue("@MA_NV", empID);

                    cmd.ExecuteNonQuery();




                    if (bookID1 != "")
                    {
                        cmd.Dispose();
                        cmd = new SqlCommand("SP_THEMCTPHIEUMUON", conn, Mytransaction);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MA_PHIEU", ticketID);
                        cmd.Parameters.AddWithValue("@MA_SACH", bookID1);
                        cmd.Parameters.AddWithValue("@NGAY_TRA", DBNull.Value);
                        cmd.Parameters.AddWithValue("@TINH_TRANG_MUON", bookNew1);
                        cmd.Parameters.AddWithValue("@TRA", 0);
                        cmd.Parameters.AddWithValue("MA_NVNS", DBNull.Value);

                        cmd.ExecuteNonQuery(); ;
                    }
                    if (bookID2 != "")
                    {
                        cmd.Dispose();
                        cmd = new SqlCommand("SP_THEMCTPHIEUMUON", conn, Mytransaction);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MA_PHIEU", ticketID);
                        cmd.Parameters.AddWithValue("@MA_SACH", bookID2);
                        cmd.Parameters.AddWithValue("@NGAY_TRA", DBNull.Value);
                        cmd.Parameters.AddWithValue("@TINH_TRANG_MUON", bookNew2);
                        cmd.Parameters.AddWithValue("@TRA", 0);
                        cmd.Parameters.AddWithValue("MA_NVNS", DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                    if (bookID3 != "")
                    {
                        cmd.Dispose();
                        cmd = new SqlCommand("SP_THEMCTPHIEUMUON", conn, Mytransaction);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MA_PHIEU", ticketID);
                        cmd.Parameters.AddWithValue("@MA_SACH", bookID3);
                        cmd.Parameters.AddWithValue("@NGAY_TRA", DBNull.Value);
                        cmd.Parameters.AddWithValue("@TINH_TRANG_MUON", bookNew3);
                        cmd.Parameters.AddWithValue("@TRA", 0);
                        cmd.Parameters.AddWithValue("MA_NVNS", DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                    Mytransaction.Commit();
                    conn.Close();

                    buttonAddTicket.Visible = true;
                    buttonEditTicket.Visible = true;
                    buttonSave.Visible = false;
                    buttonCancel.Visible = false;
                }
                catch (Exception ex)
                {
                    Mytransaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
            else if (value == 2)
            {

            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            disableTextBox(true);
            clearAllTextBox();
            buttonAddTicket.Visible = true;
            buttonEditTicket.Visible = true;
            buttonSave.Visible = false;
            buttonCancel.Visible = false;
        }



        void disableTextBox(bool bl)
        {
            textBoxTicketID.ReadOnly = bl;
            textBoxReaderID.ReadOnly = bl;
            textBoxEmpID.ReadOnly = bl;

            textBoxBookID1.ReadOnly = bl;
            textBoxBookID2.ReadOnly = bl;
            textBoxBookID3.ReadOnly = bl;
            textBoxBookName1.ReadOnly = bl;
            textBoxBookName2.ReadOnly = bl;
            textBoxBookName3.ReadOnly = bl;

            dateTimePickerBorrowDay.Enabled = !bl;
            panel1.Enabled = !bl;
            panelCon1.Enabled = !bl;
            panelcon2.Enabled = !bl;
            panelcon3.Enabled = !bl;
        }

        void clearAllTextBox()
        {
            textBoxTicketID.Text = "";
            textBoxReaderID.Text = "";
            textBoxEmpID.Text = "";

            textBoxBookID1.Text = "";
            textBoxBookID2.Text = "";
            textBoxBookID3.Text = "";
            textBoxBookName1.Text = "";
            textBoxBookName2.Text = "";
            textBoxBookName3.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearAllTextBox();
            textBoxTicketID.Text = dataGridView1.CurrentRow.Cells["MAPHIEU"].Value.ToString();
            textBoxReaderID.Text = dataGridView1.CurrentRow.Cells["MADG"].Value.ToString();
            textBoxEmpID.Text = dataGridView1.CurrentRow.Cells["MANV"].Value.ToString();
            int currentTicketID = Int32.Parse(dataGridView1.CurrentRow.Cells["MAPHIEU"].Value.ToString());
            String sql = "SELECT MAPHIEU, CT_PHIEUMUON.MASACH, TENSACH, TINHTRANG FROM CT_PHIEUMUON, SACH, ISBN WHERE SACH.ISBN = ISBN.ISBN AND CT_PHIEUMUON.MASACH = SACH.MASACH AND MAPHIEU = " + currentTicketID;
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
                    radioButtonNewBook1.Checked = true;
                }
                else
                {
                    radioButtonOldBook1.Checked = true;
                }




            } else if (dt.Rows.Count == 2)
            {
                textBoxBookID1.Text = dt.Rows[0][1].ToString();
                textBoxBookName1.Text = dt.Rows[0][2].ToString();
                String state = dt.Rows[0][3].ToString();
                if (state == "True")
                {
                    radioButtonNewBook1.Checked = true;
                }
                else
                {
                    radioButtonOldBook1.Checked = true;
                }

                textBoxBookID2.Text = dt.Rows[1][1].ToString();
                textBoxBookName2.Text = dt.Rows[1][2].ToString();
                 state = dt.Rows[1][3].ToString();
                if (state == "True")
                {
                    radioButtonNewBook2.Checked = true;
                }
                else
                {
                    radioButtonOldBook2.Checked = true;
                }
            } else if(dt.Rows.Count == 3)
            {
                textBoxBookID1.Text = dt.Rows[0][1].ToString();
                textBoxBookName1.Text = dt.Rows[0][2].ToString();
                String state = dt.Rows[0][3].ToString();
                if (state == "True")
                {
                    radioButtonNewBook1.Checked = true;
                }
                else
                {
                    radioButtonOldBook1.Checked = true;
                }

                textBoxBookID2.Text = dt.Rows[1][1].ToString();
                textBoxBookName2.Text = dt.Rows[1][2].ToString();
                 state = dt.Rows[2][3].ToString();
                if (state == "True")
                {
                    radioButtonNewBook2.Checked = true;
                }
                else
                {
                    radioButtonOldBook2.Checked = true;
                }

                textBoxBookID3.Text = dt.Rows[2][1].ToString();
                textBoxBookName3.Text = dt.Rows[2][2].ToString();
                 state = dt.Rows[2][3].ToString();
                if (state == "True")
                {
                    radioButtonNewBook3.Checked = true;
                }
                else
                {
                    radioButtonOldBook3.Checked = true;
                }
            } else 
            {
                textBoxBookID1.Text = "";
                textBoxBookID2.Text = "";
                textBoxBookID2.Text = "";
                textBoxBookName1.Text = "";
                textBoxBookName2.Text = "";
                textBoxBookName3.Text = "";
                radioButtonNewBook1.Checked = false;
                radioButtonNewBook2.Checked = false;
                radioButtonNewBook3.Checked = false;
                radioButtonOldBook1.Checked = false;
                radioButtonOldBook2.Checked = false;
                radioButtonOldBook3.Checked = false;
            }             
        }
    }
}
