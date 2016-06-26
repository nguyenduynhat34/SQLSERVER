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
    public partial class FormReader : Form
    {
        String readerID;
        String readerLastname;
        String readerFirstname;
        String readerEmail;
        String readerNumberID;
        String readerAddr;
        String readerPhone;
        bool readerSex;
        bool activeState;

        DateTime readerBirth;
        DateTime startDate;
        DateTime endDate;

        int value;

        public FormReader()
        {
            InitializeComponent();
            textBoxReaderID.ReadOnly = true;
            disableTextbox(true);

            buttonSaveReader.Visible = false;
            buttonCancel.Visible = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormReader_Load(object sender, EventArgs e)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = Program.connstr;
                String selectCommand = "Select * from DOCGIA";

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
            
            textBoxReaderID.Text = dataGridView1.CurrentRow.Cells["MADG"].Value.ToString();
            textBoxReaderFirstname.Text = dataGridView1.CurrentRow.Cells["HODG"].Value.ToString();
            textBoxReaderLastname.Text = dataGridView1.CurrentRow.Cells["TENDG"].Value.ToString();
            textBoxReaderEmail.Text = dataGridView1.CurrentRow.Cells["EMAILDG"].Value.ToString();
            textBoxReaderNumberID.Text = dataGridView1.CurrentRow.Cells["SOCMND"].Value.ToString();
            textBoxReaderAddress.Text = dataGridView1.CurrentRow.Cells["DIACHI"].Value.ToString();
            textBoxReaderPhone.Text = dataGridView1.CurrentRow.Cells["DIENTHOAI"].Value.ToString();
            dateTimePickerReaderBirth.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NGAYSINH"].Value.ToString());
            dateTimePickerBeginDay.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NGAYLAMTHE"].Value.ToString());
            dateTimePickerEndDay.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NGAYHETHAN"].Value.ToString());

            String gender = dataGridView1.CurrentRow.Cells["GIOITINH"].Value.ToString();
            if(gender == "True")
            {
                radioButtonMale.Checked = true;
            } else
            {
                radioButtonFemale.Checked = true;
            }
            String isActive = dataGridView1.CurrentRow.Cells["HOATDONG"].Value.ToString();
            if (isActive == "True")
            {
                radioButtonActive.Checked = true;
            } else
            {
                radioButtonUnActive.Checked = true;
            }
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            disableTextbox(false);
            buttonAddReader.Visible = false;
            buttonReaderEdit.Visible = false;
            buttonSaveReader.Visible = true;
            buttonCancel.Visible = true;
            value = 1;
        }

        private void buttonReaderEdit_Click(object sender, EventArgs e)
        {
            disableTextbox(false);
            buttonAddReader.Visible = false;
            buttonReaderEdit.Visible = false;
            buttonSaveReader.Visible = true;
            buttonCancel.Visible = true;
            value = 2;
        }

        private void buttonSaveReader_Click(object sender, EventArgs e)
        {
            readerID = textBoxReaderID.Text;
            readerFirstname = textBoxReaderFirstname.Text;
            readerLastname = textBoxReaderLastname.Text;
            readerEmail = textBoxReaderEmail.Text;
            readerNumberID = textBoxReaderNumberID.Text;
            readerAddr = textBoxReaderAddress.Text;
            readerPhone = textBoxReaderPhone.Text;
            readerBirth = dateTimePickerReaderBirth.Value;
            startDate = dateTimePickerBeginDay.Value;
            endDate = dateTimePickerEndDay.Value;
            readerSex = radioButtonMale.Checked;
            activeState = radioButtonActive.Checked;

            if(value ==1)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_THEMDOCGIA", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@HO", readerFirstname);
                    cmd.Parameters.AddWithValue("@TEN", readerLastname);
                    cmd.Parameters.AddWithValue("@EMAIL", readerEmail);
                    cmd.Parameters.AddWithValue("@SOCM", readerNumberID);
                    cmd.Parameters.AddWithValue("GIOI_TINH", readerSex);
                    cmd.Parameters.Add("@NGAY_SINH", SqlDbType.DateTime).Value = readerBirth;
                    cmd.Parameters.AddWithValue("@DIA_CHI", readerAddr);
                    cmd.Parameters.AddWithValue("@DIEN_THOAI", readerPhone);
                    cmd.Parameters.Add("@NGAY_LAM_THE", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@NGAY_HET_HAN", SqlDbType.DateTime).Value = endDate;
                    cmd.Parameters.AddWithValue("@HOAT_DONG", activeState);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else if(value == 2)
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Program.connstr;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_SUADOCGIA", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MADG", readerID);
                    cmd.Parameters.AddWithValue("@HO", readerFirstname);
                    cmd.Parameters.AddWithValue("@TEN", readerLastname);
                    cmd.Parameters.AddWithValue("@EMAIL", readerEmail);
                    cmd.Parameters.AddWithValue("@SOCM", readerNumberID);
                    cmd.Parameters.AddWithValue("GIOI_TINH", readerSex);
                    cmd.Parameters.Add("@NGAY_SINH", SqlDbType.DateTime).Value = readerBirth;
                    cmd.Parameters.AddWithValue("@DIA_CHI", readerAddr);
                    cmd.Parameters.AddWithValue("@DIEN_THOAI", readerPhone);
                    cmd.Parameters.Add("@NGAY_LAM_THE", SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@NGAY_HET_HAN", SqlDbType.DateTime).Value = endDate;
                    cmd.Parameters.AddWithValue("@HOAT_DONG", activeState);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            buttonAddReader.Visible = true;
            buttonReaderEdit.Visible = true;
            buttonSaveReader.Visible = false;
            buttonCancel.Visible = false;
            disableTextbox(true);
        }

        private void buttonDeleteReader_Click(object sender, EventArgs e)
        {
            readerID = textBoxReaderID.Text;
            readerLastname = textBoxReaderLastname.Text;
            if(readerID != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa " + readerLastname, "Xóa độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = Program.connstr;
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("SP_XOADOCGIA", conn);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MA_DOC_GIA", readerID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonAddReader.Visible = true;
            buttonReaderEdit.Visible = true;
            buttonSaveReader.Visible = false;
            buttonCancel.Visible = false;


            disableTextbox(true);
            clearAlltextBox();
        }

        void disableTextbox(bool bl)
        {
            textBoxReaderFirstname.ReadOnly = bl; ;
            textBoxReaderLastname.ReadOnly = bl;
            textBoxReaderEmail.ReadOnly = bl;
            textBoxReaderNumberID.ReadOnly = bl;
            textBoxReaderAddress.ReadOnly = bl;
            textBoxReaderPhone.ReadOnly = bl;

            dateTimePickerReaderBirth.Enabled = !bl;
            dateTimePickerBeginDay.Enabled = !bl;
            dateTimePickerEndDay.Enabled = !bl;

            panelSex.Enabled = !bl;
            panelActive.Enabled = !bl;
        }

        void clearAlltextBox()
        {
            textBoxReaderFirstname.Text = "";
            textBoxReaderLastname.Text = "";
            textBoxReaderEmail.Text = "";
            textBoxReaderNumberID.Text = "";
            textBoxReaderAddress.Text = "";
            textBoxReaderPhone.Text = "";

        }


    }
}
