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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
            ComboBoxLinkType.Items.Add("Website");
            ComboBoxLinkType.Items.Add("Youtube");
            ComboBoxLinkType.Items.Add("Google");
            ComboBoxLinkType.Items.Add("LinkedIn");
        }
                                
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void view_Load(object sender, EventArgs e)
        {
            fillCategory();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }

        private void BtnSubCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SubCategoryInformation().ShowDialog(); 
        }

        private void BtnLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view().ShowDialog();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
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

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillSubCategory();
        }
        public void fillSubCategory()
        {
            try
            {
                string category_name = ComboBoxCategory.Text;
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select subcategory.subcategory_name,subcategory.subcategory_id from category inner join subcategory on subcategory.category_id = category.categoryid where category.category_name = '" + category_name + "'", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                ComboBoxSubCategory.DataSource = dt;
                ComboBoxSubCategory.ValueMember = "subcategory_id";
                ComboBoxSubCategory.DisplayMember = "subcategory_name";
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        public void fillCategory()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from category", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                ComboBoxCategory.DataSource = dt;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void btmShowData_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                string subcategory = ComboBoxSubCategory.SelectedValue.ToString();
                string linktype = ComboBoxLinkType.Text.ToString();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from link where sub_category_id = '"+int.Parse(subcategory) + "' and link_type = '"+linktype+"'", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Available");
                }
                
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SubCategoryInformation().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new user_management().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Link_Content().ShowDialog();
        }
    }
}

