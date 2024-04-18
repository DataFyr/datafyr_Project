using Microsoft.Office.Interop.Excel;
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
    public partial class SubCategoryInformation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
        int sub_category_id;
        public SubCategoryInformation()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public void clearFields()
        {
            textbox_sub_categoryname.Text = string.Empty;
            ddl_category_name.SelectedIndex = 0;
        }
       
        public void showSubcategoryInformation()
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("select * from subcategory", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textbox_sub_categoryname.Text != "" || ddl_category_name.Text !="")
            {
                String msg = "              Saved Successfully";
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into subcategory values (@subcategoryname,@category_id)", con);
                    cmd.Parameters.AddWithValue("@subcategoryname", textbox_sub_categoryname.Text);
                    cmd.Parameters.AddWithValue("@category_id", int.Parse(ddl_category_name.SelectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    new popup(msg).ShowDialog();
                    showSubcategoryInformation();
                    clearFields();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all field");
            }
        }

        private void SubCategoryInformation_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            button1.Enabled = false;
            fillCategoryCombo();
            fillSubCategoryGrid();
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String msg = "Are You Sure You Want To Update";
            if (textbox_sub_categoryname.Text != "" || ddl_category_name.Text != "")
            {
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("update subcategory set subcategory_name = @subcategory_name,category_id= @category_id where subcategory_id = @subcategory_id", con);
                    cmd.Parameters.AddWithValue("@subcategory_name", textbox_sub_categoryname.Text);
                    cmd.Parameters.AddWithValue("@category_id", ddl_category_name.SelectedValue);
                    cmd.Parameters.AddWithValue("@subcategory_id", sub_category_id);
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    new popup(msg,cmd,"update").ShowDialog();
                    showSubcategoryInformation();
                    clearFields();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            if (e.RowIndex > 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row != null)
                {
                    textbox_sub_categoryname.Text = row.Cells[1].Value.ToString();
                    ddl_category_name.SelectedValue = int.Parse(row.Cells[2].Value.ToString());
                    sub_category_id = int.Parse(row.Cells[0].Value.ToString());
                }
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String msg = "Are You Sure You Want To Delete";
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("delete from subcategory where subcategory_id = @subcategory_id", con);
                cmd.Parameters.AddWithValue("@subcategory_id", sub_category_id);
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                new popup(msg, cmd, "delete").ShowDialog();
                showSubcategoryInformation();
                clearFields();
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginPage.role != "Admin")
            {
                MessageBox.Show("you don't have permission to access this section");
            }
            else
            {
                new user_management().Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginPage().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new view().Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
        public void fillCategoryCombo()
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("select * from category", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                ddl_category_name.DataSource = dt;
                ddl_category_name.ValueMember = "categoryid";
                ddl_category_name.DisplayMember = "category_name";
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        public void fillSubCategoryGrid()
        {
            try
            {
                if(con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter sda = new SqlDataAdapter("select * from subcategory", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            new SubCategoryInformation().Show();
        }
    }
}
