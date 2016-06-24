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
    public partial class FormAuthor : Form
    {
        String AuthorID;
        String AuthorName;
        String AuthorAddr;
        String AuthorPhone;
        int value;
        public FormAuthor()
        {
            InitializeComponent();
            buttonSaveAuthor.Visible = false;
            buttonCancel.Visible = false;
            textBoxAuthorID.ReadOnly = true;
            disableTextbox(true);
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

        private void FormAuthor_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = Program.connstr;
                String selectCommand = "Select * from TACGIA";

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
            catch (SqlException)
            {
                MessageBox.Show("Error!");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAuthorID.Text = dataGridView1.CurrentRow.Cells["MATACGIA"].Value.ToString();
            textBoxAuthorName.Text = dataGridView1.CurrentRow.Cells["HOTENTG"].Value.ToString();
            textBoxAuthorAddress.Text = dataGridView1.CurrentRow.Cells["DIACHITG"].Value.ToString();
            textBoxAuthorPhone.Text = dataGridView1.CurrentRow.Cells["DIENTHOAITG"].Value.ToString();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            disableTextbox(false);
            buttonAuthorEdit.Visible = false;
            buttonSaveAuthor.Visible = true;
            buttonCancel.Visible = true;
            clearAllTextbox();
            value = 1;
        }

        private void buttonAuthorEdit_Click(object sender, EventArgs e)
        {
            disableTextbox(false);
            buttonAddAuthor.Visible = false;
            buttonAuthorEdit.Visible = false;
            buttonSaveAuthor.Visible = true;
            buttonCancel.Visible = true;
            value = 2;
        }

        private void buttonSaveAuthor_Click(object sender, EventArgs e)
        {
            AuthorID = textBoxAuthorID.Text;
            AuthorName = textBoxAuthorName.Text;
            AuthorAddr = textBoxAuthorAddress.Text;
            AuthorPhone = textBoxAuthorPhone.Text;

            
            
            if(value == 1)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_THEMTACGIA", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@HO_TEN", AuthorName);
                    cmd.Parameters.AddWithValue("@DIA_CHI", AuthorAddr);
                    cmd.Parameters.AddWithValue("@DIEN_THOAI", AuthorPhone);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    
                    buttonAddAuthor.Visible = true;
                    buttonAuthorEdit.Visible = true;
                    buttonSaveAuthor.Visible = false;
                    buttonCancel.Visible = false;
                    disableTextbox(true);
                }
            } else if(value == 2)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_SUATACGIA", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_TG", Int32.Parse(AuthorID));
                    cmd.Parameters.AddWithValue("@HO_TEN", AuthorName);
                    cmd.Parameters.AddWithValue("@DIA_CHI", AuthorAddr);
                    cmd.Parameters.AddWithValue("@DIEN_THOAI", AuthorPhone);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    
                    buttonAddAuthor.Visible = true;
                    buttonAuthorEdit.Visible = true;
                    buttonSaveAuthor.Visible = false;
                    buttonCancel.Visible = false;
                    disableTextbox(true);
                }
            }
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            AuthorID = textBoxAuthorID.Text;
            AuthorName = textBoxAuthorName.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa: \" " + AuthorName + "\"", "Xóa đầu sách", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);

            if (AuthorID == "")
            {
            }
            else
            {
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = Program.connstr;
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("SP_XOATACGIA", conn);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MA_TG", AuthorID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception exeption3)
                    {
                        MessageBox.Show(exeption3.Message);
                    }
                }

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearAllTextbox();
            disableTextbox(true);

            buttonSaveAuthor.Visible = false;
            buttonCancel.Visible = false;
        }

        private void disableTextbox(bool bl) 
        {

            textBoxAuthorName.ReadOnly = bl;
            textBoxAuthorAddress.ReadOnly = bl;
            textBoxAuthorPhone.ReadOnly = bl;
        }

        private void clearAllTextbox()
        {
            textBoxAuthorID.Text = "";
            textBoxAuthorName.Text = "";
            textBoxAuthorAddress.Text = "";
            textBoxAuthorPhone.Text = "";
        }


    }
}
