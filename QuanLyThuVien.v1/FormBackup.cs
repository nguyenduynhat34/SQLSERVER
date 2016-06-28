using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace QuanLyThuVien.v1
{
    public partial class FormBackup : Form
    {
        private SqlDataReader reader;
        private String connStr;
        private String sql = "";
        private SqlCommand cm;
        private SqlConnection conn;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        public FormBackup()
        {
            InitializeComponent();
            txtDataSource.Text = @"WAVESILVER\SQLSERVER";
            txtUserID.Text = Program.mlogin;
            txtPassword.Text = Program.password;
            txtLocationBackup.Text = "C:\\Program Files\\Microsoft SQL Server\\MSSQL10.SQLSERVER\\MSSQL\\Backup\\DIV_BACKUP.bak";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connStr = Program.connstr;
            conn = new SqlConnection(connStr);
            conn.Open();
            sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
            cm = new SqlCommand(sql, conn);
            reader = cm.ExecuteReader();
            cbDatabase.Items.Clear();
            while (reader.Read())
            {
                cbDatabase.Items.Add(reader[0].ToString());
            }

            conn.Close();
            conn.Dispose();

            txtDataSource.Enabled = false;
            txtPassword.Enabled = false;
            txtUserID.Enabled = false;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;

            btnBackup.Enabled = true;
            btnRestore.Enabled = true;

            cbDatabase.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            txtDataSource.Enabled = true;
            txtUserID.Enabled = true;
            txtPassword.Enabled = true;
            cbDatabase.Enabled = false;
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
        }

        private void FormBackup_Load(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;
            cbDatabase.Enabled = false;
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDatabase.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please select a Database.");
                    return;
                }
                conn = new SqlConnection(Program.connstr);
                conn.Open();
                //BACKUP DATABASE [QLTV] TO  [DEV_BACKUP] WITH NOFORMAT, NOINIT,  NAME = N'QLTV-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
                sql = "BACKUP DATABASE [" + cbDatabase.Text + "] TO [DIV_BACKUP]" + "WITH NOFORMAT, NOINIT,  NAME = N'+" + cbDatabase.Text + "-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Successfully Database Backup Completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocationBackup.Text = dlg.SelectedPath;
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocationRestore.Text = dlg.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDatabase.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please select a Database.");
                    return;
                }
                conn = new SqlConnection(txtDataSource.Text);
                conn.Open();
                sql = "ALTER DATABASE " + cbDatabase.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE";

                sql += "Restore Database " + cbDatabase.Text + " FROM Disk = '" + txtLocationRestore.Text + "' WITH REPLACE";
                cm = new SqlCommand(sql, Program.conn);
                cm.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Successfully  Restore Database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
