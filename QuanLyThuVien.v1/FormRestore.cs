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
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        private void FormRestore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.ISBN' table. You can move, or remove it, as needed.
            try
            {

                String file;
                String sql = "use msdb select physical_device_name from backupmediafamily where logical_device_name = 'DIV_BACKUP'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Program.connstr;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    file = dataReader.GetString(0);

                }
                else file = "C:\\Program Files\\Microsoft SQL Server\\MSSQL10.SQLSERVER\\MSSQL\\Backup\\DIV_BACKUP.bak";
                SqlConnection conn = Program.conn;
                String connectionString = Program.connstr;
                
                String selectCommand = "restore headeronly from disk = '" + file + "'" ;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);


                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);


                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBackupName.Text = dataGridView1.CurrentRow.Cells["BackupName"].Value.ToString();

            dateTimePicker.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["DatabaseCreationDate"].Value.ToString());
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            String filePos = dataGridView1.CurrentRow.Cells["Position"].Value.ToString();
            try
            {
                String sql = "use msbd alter database QLTV set single_user with rollback immediate";
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Program.connstr;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                sql = "restore database [QLTV] file = N'QLTV' from [DIV_BACKUP] with replace, file = " + filePos + ", nounload, replace, stats = 10";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                sql = "alter database QLTV set multi_user with rollback immediate ";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Restore thành công");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
