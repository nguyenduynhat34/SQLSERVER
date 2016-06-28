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
    public partial class FormBookManage : Form
    {
        String ISBN = null;
        String bookName = null;
        String bookSize = null;
        String content = null;
        String path = null;
        DateTime publishDate;
        String publishTime = null;
        String pages = null;
        String cost = null;
        String publishHouse = null;
        String langID = null;
        String bookTypeID = null;
        String authorID = null;
        //value = 1 -> Add book
        //value = 2 -> Edit book
        int value; 


        public FormBookManage()
        {
            InitializeComponent();
            buttonSaveBook.Visible = false;
            buttonCancel.Visible = false;
            disableTexbox(true);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }   

        private void FormBookManage_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = Program.conn;
                String connectionString = Program.connstr;
                String selectCommand = "SELECT ISBN.ISBN, TENSACH, KHOSACH, NOIDUNG, HINHANHPATH, NGAYXUATBAN, LANXUATBAN, SOTRANG, GIA, NHAXB, MANGONNGU, MATL, MATACGIA FROM[QLTV].[dbo].[ISBN], [QLTV].[dbo].[TACGIA_SACH] WHERE ISBN.ISBN = TACGIA_SACH.ISBN";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);


                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disableTexbox(true);
            textBoxBookID.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            textBoxBookName.Text = dataGridView1.CurrentRow.Cells["TENSACH"].Value.ToString();
            textBoxBookSize.Text = dataGridView1.CurrentRow.Cells["KHOSACH"].Value.ToString();
            textBoxBookContent.Text = dataGridView1.CurrentRow.Cells["NOIDUNG"].Value.ToString();
            textBoxPublishTime.Text = dataGridView1.CurrentRow.Cells["LANXUATBAN"].Value.ToString();
            textBoxBookPages.Text = dataGridView1.CurrentRow.Cells["SOTRANG"].Value.ToString();
            textBoxBookCost.Text = dataGridView1.CurrentRow.Cells["GIA"].Value.ToString();
            textBoxPublishHouse.Text = dataGridView1.CurrentRow.Cells["NHAXB"].Value.ToString();
            textBoxLangID.Text = dataGridView1.CurrentRow.Cells["MANGONNGU"].Value.ToString();
            textBoxBookTypeID.Text = dataGridView1.CurrentRow.Cells["MATL"].Value.ToString();
            textBoxAuthorID.Text = dataGridView1.CurrentRow.Cells["MATACGIA"].Value.ToString();
            dateTimePickerBookPublish.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["NGAYXUATBAN"].Value.ToString());
        }

        private void pictureBoxBookCover_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "image files (*.png; *.jpeg; *.jpg)|*.png; *.jpeg; *.jpg|All files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select a image file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                //richTextBox1.Text = System.IO.File.ReadAllText(fname);
                //MessageBox.Show(fname);
                //Image image = Image.FromFile(fname);
               
                pictureBoxBookCover.Image = Image.FromFile(fname);
                path = fname;
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            disableTexbox(false);
            clearAllTextBox();

            value = 1;

            buttonAddBook.Visible = false;
            buttonBookEdit.Visible = false;
            buttonSaveBook.Visible = true;
            
        }

        private void buttonBookEdit_Click(object sender, EventArgs e)
        {
            disableTexbox(false);

            value = 2;

            buttonBookEdit.Visible = false;
            buttonAddBook.Visible = false;
            buttonSaveBook.Visible = true;

        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {

            ISBN = textBoxBookID.Text;
            bookName = textBoxBookName.Text;
            bookSize = textBoxBookSize.Text;
            content = textBoxBookContent.Text;
            publishTime = textBoxPublishTime.Text;
            pages = textBoxBookPages.Text;
            cost = textBoxBookCost.Text;
            publishHouse = textBoxPublishHouse.Text;
            langID = textBoxLangID.Text;
            bookTypeID = textBoxBookTypeID.Text;
            authorID = textBoxAuthorID.Text;
            publishDate = dateTimePickerBookPublish.Value;

            SqlConnection conn = Program.conn;

            if (value == 1)
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("SP_THEMDAUSACH", conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MA_DAUSACH", ISBN);
                    cmd.Parameters.AddWithValue("@TEN_SACH", bookName);
                    cmd.Parameters.AddWithValue("@KHO_SACH", bookSize);
                    cmd.Parameters.AddWithValue("@NOI_DUNG", content);
                    if (path == null)
                    {
                        cmd.Parameters.AddWithValue("@PATH", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PATH", path);
                    }


                    cmd.Parameters.AddWithValue("@LAN_XB", publishTime);
                    cmd.Parameters.AddWithValue("@SO_TRANG", pages);
                    cmd.Parameters.AddWithValue("@GIA", cost);
                    cmd.Parameters.AddWithValue("@NHA_XB", publishHouse);
                    cmd.Parameters.AddWithValue("@MA_NN", langID);
                    cmd.Parameters.AddWithValue("@MA_TG", authorID);
                    //cmd.Parameters.AddWithValue("@NGAY_XB", publishDate);
                    cmd.Parameters.Add("@NGAY_XB", SqlDbType.DateTime).Value = publishDate;
                    cmd.Parameters.AddWithValue("@MA_TL", bookTypeID);

                    cmd.ExecuteNonQuery();


                }
                catch (Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
                finally
                {
                    conn.Close();
                }

                buttonAddBook.Visible = true;
                disableTexbox(true);
            } else if(value == 2)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SUADAUSACH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MA_DAUSACH", ISBN);
                    cmd.Parameters.AddWithValue("@TEN_SACH", bookName);
                    cmd.Parameters.AddWithValue("@KHO_SACH", bookSize);
                    cmd.Parameters.AddWithValue("@NOI_DUNG", content);
                    if (path == null)
                    {
                        cmd.Parameters.AddWithValue("@PATH", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PATH", path);
                    }


                    cmd.Parameters.AddWithValue("@LAN_XB", publishTime);
                    cmd.Parameters.AddWithValue("@SO_TRANG", pages);
                    cmd.Parameters.AddWithValue("@GIA", cost);
                    cmd.Parameters.AddWithValue("@NHA_XB", publishHouse);
                    cmd.Parameters.AddWithValue("@MA_NN", langID);
                    cmd.Parameters.AddWithValue("@MA_TG", authorID);
                    //cmd.Parameters.AddWithValue("@NGAY_XB", publishDate);
                    cmd.Parameters.Add("@NGAY_XB", SqlDbType.DateTime).Value = publishDate;
                    cmd.Parameters.AddWithValue("@MA_TL", bookTypeID);

                    cmd.ExecuteNonQuery();
                    
                }catch (Exception exeption)
                {
                    MessageBox.Show(exeption.ToString());
                } finally
                {
                    conn.Close();
                }
                reloadData();
            }

            this.Refresh();
            this.dataGridView1.Update();
            this.dataGridView1.EndEdit();
            this.dataGridView1.Refresh();


            buttonAddBook.Visible = true;
            buttonBookEdit.Visible = true;
            buttonSaveBook.Visible = false;
            buttonCancel.Visible = false;
            disableTexbox(true);
        }



        private void disableTexbox(Boolean bl)
        {
            textBoxBookID.ReadOnly = bl;
            textBoxBookName.ReadOnly = bl;
            textBoxBookSize.ReadOnly = bl;
            textBoxBookContent.ReadOnly = bl;
            textBoxPublishTime.ReadOnly = bl;
            textBoxBookTypeID.ReadOnly = bl;
            textBoxPublishHouse.ReadOnly = bl;
            textBoxBookSize.ReadOnly = bl;
            textBoxLangID.ReadOnly = bl;
            textBoxBookPages.ReadOnly = bl;
            textBoxBookCost.ReadOnly = bl;
            textBoxAuthorID.ReadOnly = bl;
            dateTimePickerBookPublish.Enabled = !bl;
        }

        private void clearAllTextBox()
        {
            textBoxBookID.Text = "";
            textBoxBookName.Text = "";
            textBoxBookSize.Text = "";
            textBoxBookContent.Text = "";
            textBoxPublishTime.Text = "";
            textBoxBookTypeID.Text = "";
            textBoxPublishHouse.Text = "";
            textBoxBookSize.Text = "";
            textBoxLangID.Text = "";
            textBoxBookPages.Text = "";
            textBoxBookCost.Text = "";
            textBoxAuthorID.Text = "";

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearAllTextBox();
            disableTexbox(true);

            buttonAddBook.Visible = true;
            buttonBookEdit.Visible = true;
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            ISBN = textBoxBookID.Text;
            bookName = textBoxBookName.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa: \" " + bookName + "\"", "Xóa đầu sách", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
            
            if (ISBN == "")
            {
            }else 
            {
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = Program.conn;
                        SqlCommand cmd = new SqlCommand("SP_XOADAUSACH", conn);

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MADAUSACH", ISBN);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception exeption3)
                    {
                        MessageBox.Show(exeption3.Message);
                    }
                }
                
            }
            reloadData();

        }

        public void reloadData()
        {
            SqlConnection conn = Program.conn;
            String connectionString = Program.connstr;
            String selectCommand = "SELECT ISBN.ISBN, TENSACH, KHOSACH, NOIDUNG, HINHANHPATH, NGAYXUATBAN, LANXUATBAN, SOTRANG, GIA, NHAXB, MANGONNGU, MATL, MATACGIA FROM[QLTV].[dbo].[ISBN], [QLTV].[dbo].[TACGIA_SACH] WHERE ISBN.ISBN = TACGIA_SACH.ISBN";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);


            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
