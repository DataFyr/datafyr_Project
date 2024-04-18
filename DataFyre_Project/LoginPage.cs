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
    public partial class LoginPage : Form
    {
        public static string fullname;
        public static string role;
        public LoginPage()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text != "" || textbox_password.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from users where username='" + textbox_username.Text + "' and password ='" + textbox_password.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        fullname = dt.Rows[0][3].ToString();
                        role = dt.Rows[0][4].ToString();
                        this.Hide();
                        new Form3().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textbox_username_Enter(object sender, EventArgs e)
        {
            if (textbox_username.Text == "Username")
            {
                textbox_username.Text = "";
                textbox_username.ForeColor = Color.Black;
            }
        }

        private void textbox_username_Leave(object sender, EventArgs e)
        {
            if (textbox_username.Text == "")
            {
                textbox_username.Text = "Username";
                textbox_username.ForeColor = Color.Silver;
            }
        }

        private void textbox_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textbox_password_Enter(object sender, EventArgs e)
        {
            if (textbox_password.Text == "Password")
            {
                textbox_password.Text = "";
                textbox_password.ForeColor = Color.Black;
            }
        }

        private void textbox_password_Leave(object sender, EventArgs e)
        {
            if (textbox_password.Text == "")
            {
                textbox_password.Text = "Password";
                textbox_password.ForeColor = Color.Silver;
            }
        }

        private void textbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (textbox_username.Text != "" || textbox_password.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select * from users where username='" + textbox_username.Text + "' and password ='" + textbox_password.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            fullname = dt.Rows[0][3].ToString();
                            role = dt.Rows[0][4].ToString();
                            this.Hide();
                            new success().ShowDialog();
                            new Form3().ShowDialog();
                        }
                        else
                        {
                            new failure().ShowDialog();
                        }
                    }
                    catch (Exception ee)
                    {
                        new failure().ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Please fill all fields");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text != "" || textbox_password.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select * from users where username='" + textbox_username.Text + "' and password ='" + textbox_password.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        fullname = dt.Rows[0][3].ToString();
                        role = dt.Rows[0][4].ToString();
                        this.Hide();
                        new success().ShowDialog();
                        new Form3().ShowDialog();
                    }
                    else
                    {
                        new failure().ShowDialog();
                    }
                }
                catch (Exception ee)
                {

                    new failure().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
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


        private void panelNavBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
