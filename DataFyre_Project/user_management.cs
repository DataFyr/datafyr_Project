using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datascience_project
{
    public partial class user_management : Form
    {
        int user_id;
        public user_management()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void showInformation()
        {
        }
        public void clearFields()
        {
            textbox_username.Clear();
            textboxpassword.Clear();
            textboxfullname.Clear();
            combobox_role.SelectedIndex = -1;
        }

        private void user_management_Load(object sender, EventArgs e)
        {
            showInformation();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            fillCategoryGridUser();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text != "" || textboxpassword.Text != "" || combobox_role.Text != "" || textboxfullname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into users values (@username,@password,@role,@fullname)", con);
                    cmd.Parameters.AddWithValue("@username", textbox_username.Text);
                    cmd.Parameters.AddWithValue("@password", textboxpassword.Text);
                    cmd.Parameters.AddWithValue("@role", combobox_role.Text);
                    cmd.Parameters.AddWithValue("@fullname", textboxfullname.Text);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("user information added successfully.");
                    showInformation();
                    clearFields();
                    fillCategoryGridUser();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void datagridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            DataGridViewRow row = datagridUsers.Rows[e.RowIndex];
            if (row != null)
            {
                user_id = int.Parse(row.Cells[0].Value.ToString());
                textbox_username.Text = row.Cells[1].Value.ToString();
                textboxfullname.Text = row.Cells[3].Value.ToString();
                combobox_role.Text  = row.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text != "" || textboxpassword.Text != "" || combobox_role.Text != "" || textboxfullname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update users set username = @username, password=@password,role=@role,fullname=@fullname where userid=@userid", con);
                    cmd.Parameters.AddWithValue("@username", textbox_username.Text);
                    cmd.Parameters.AddWithValue("@password", textboxpassword.Text);
                    cmd.Parameters.AddWithValue("@role", combobox_role.Text);
                    cmd.Parameters.AddWithValue("@fullname", textboxfullname.Text);
                    cmd.Parameters.AddWithValue("@userid", user_id);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("user information update successfully.");
                    showInformation();
                    clearFields();
                    fillCategoryGridUser();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text != "" || textboxpassword.Text != "" || combobox_role.Text != "" || textboxfullname.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from users where userid=@userid", con);
                    cmd.Parameters.AddWithValue("@userid", user_id);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    MessageBox.Show("user information deleted successfully.");
                    showInformation();
                    clearFields();
                    fillCategoryGridUser();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginPage.role != "Admin")
            {
                MessageBox.Show("you don't have permission to access this section");
            }
            else
            {
                this.Hide();
                new user_management().ShowDialog();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to logout";
            new logoutpopup(msg).Show();
        }
        public void fillCategoryGridUser()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from users", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datagridUsers.DataSource = dt;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new import().ShowDialog();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
