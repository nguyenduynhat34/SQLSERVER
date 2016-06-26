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
    public partial class FormSpecBook : Form
    {
        String bookISBN;
        String bookSpecID;
        String bookCaseID;

        int value;

        bool condition;
        bool borrowed;
        public FormSpecBook()
        {
            InitializeComponent();
            buttonSaveBook.Visible = false;
            buttonCancel.Visible = false;
            disableTextBox(true);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void FormSpecBook_Load(object sender, EventArgs e)
        {
            // Specify a connection string. Replace the given value with a 
            // valid connection string for a Northwind SQL Server sample
            // database accessible to your system.
            String connectionString = Program.connstr;
            String selectCommand = "Select * from SACH";

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxISBN.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            textBoxBookID.Text = dataGridView1.CurrentRow.Cells["MASACH"].Value.ToString();
            textBoxBookcaseId.Text = dataGridView1.CurrentRow.Cells["MANGANTU"].Value.ToString();
            String condition = dataGridView1.CurrentRow.Cells["TINHTRANG"].Value.ToString();

            if (condition == "True")
            {
                radioButtonNew.Checked = true;
            }
            else
            {
                radioButtonOld.Checked = true;
            }

            String rent = dataGridView1.CurrentRow.Cells["CHOMUON"].Value.ToString();
            if (rent == "True")
            {
                radioButtonRentted.Checked = true;
            }
            else
            {
                radioButtonNotRent.Checked = true;
            }
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
            buttonAddBook.Visible = false;
            buttonBookEdit.Visible = false;
            buttonSaveBook.Visible = true;
            buttonCancel.Visible = true;
            disableTextBox(false);

            value = 1;

        }

        private void buttonReaderEdit_Click(object sender, EventArgs e)
        {
            buttonAddBook.Visible = false;
            buttonBookEdit.Visible = false;
            buttonSaveBook.Visible = true;
            buttonCancel.Visible = true;
            disableTextBox(false);
            textBoxBookID.ReadOnly = true;
            textBoxISBN.ReadOnly = true;
            value = 2;
        }

        private void buttonSaveReader_Click(object sender, EventArgs e)
        {
            bookISBN = textBoxISBN.Text;
            bookSpecID = textBoxBookID.Text;
            bookCaseID = textBoxBookcaseId.Text;
            condition = radioButtonNew.Checked;
            borrowed = radioButtonRentted.Checked;

            if (value == 1)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_THEMSACH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_DAU_SACH", bookISBN);
                    cmd.Parameters.AddWithValue("@MA_SACH", bookSpecID);
                    cmd.Parameters.AddWithValue("@TINH_TRANG", condition);
                    cmd.Parameters.AddWithValue("@CHO_MUON", borrowed);
                    cmd.Parameters.AddWithValue("@MA_NGAN_TU", bookCaseID);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (value == 2)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_SUASACH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_DAU_SACH", bookISBN);
                    cmd.Parameters.AddWithValue("@MA_SACH", bookSpecID);
                    cmd.Parameters.AddWithValue("@TINH_TRANG", condition);
                    cmd.Parameters.AddWithValue("@CHO_MUON", borrowed);
                    cmd.Parameters.AddWithValue("@MA_NGAN_TU", bookCaseID);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            buttonAddBook.Visible = true;
            buttonBookEdit.Visible = true;
            buttonSaveBook.Visible = false;
            buttonCancel.Visible = false;
            disableTextBox(true);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAddBook.Visible = true;
            buttonBookEdit.Visible = true;
            buttonSaveBook.Visible = false;
            buttonCancel.Visible = false;

            clearAllTextBox();
            disableTextBox(true);
        }

        private void buttonDeleteReader_Click(object sender, EventArgs e)
        {
            bookISBN = textBoxISBN.Text;
            bookSpecID = textBoxBookID.Text;

            if (bookISBN != "" && bookSpecID != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa " + bookSpecID, "Xóa sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = Program.connstr;
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("SP_XOASACH", conn);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MA_DAU_SACH", bookISBN);
                        cmd.Parameters.AddWithValue("@MA_SACH", bookSpecID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        void disableTextBox(bool bl)
        {
            textBoxBookID.ReadOnly = bl;
            textBoxISBN.ReadOnly = bl;
            textBoxBookcaseId.ReadOnly = bl;
            panelCondition.Enabled = !bl;
            panelBorrow.Enabled = !bl;
        }

        void clearAllTextBox()
        {
            textBoxBookID.Text = "";
            textBoxISBN.Text = "";
            textBoxBookcaseId.Text = "";

        }
    }
}
