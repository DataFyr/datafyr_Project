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
//using Excel = Microsoft.Office.Interop.Excel;

namespace datascience_project
{
    public partial class Form2 : Form
    {
        int link_id;
        public Form2()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void showInformation()
        {
            fillLinkGrid();
            fillCategoryCombo();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillLinkGrid();
            fillCategoryCombo();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "              Saved Successfully";
            if (ddl_sub_category_name.Text != "" || ddll_link_type.Text != "" || textbox_link_text.Text != "" || textbox_sub_link_text.Text != "" || textbox_link_content.Text !="")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO link VALUES (@link_text,@sub_link_text,@link_content,@link_type,@sub_category_id,@user_fullname,@date,@author,@published_date)", con);
                    cmd.Parameters.AddWithValue("@link_text", textbox_link_text.Text);
                    cmd.Parameters.AddWithValue("@sub_link_text", textbox_sub_link_text.Text);
                    cmd.Parameters.AddWithValue("@link_content", textbox_link_content.Text);
                    cmd.Parameters.AddWithValue("@link_type", ddll_link_type.Text);
                    cmd.Parameters.AddWithValue("@sub_category_id", ddl_sub_category_name.SelectedValue);
                    cmd.Parameters.AddWithValue("@user_fullname", LoginPage.fullname);
                    cmd.Parameters.AddWithValue("@date", datetime.Value);
                    cmd.Parameters.AddWithValue("@author", textbox_link_author.Text);
                    cmd.Parameters.AddWithValue("@published_date", textbox_link_published_date.Text);
                    cmd.ExecuteNonQuery();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    new popup(msg).ShowDialog();
                    showInformation();
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

        public void clearFields()
        {
            textbox_link_content.Clear();
            textbox_link_text.Clear();
            textbox_sub_link_text.Clear();
            ddl_sub_category_name.SelectedIndex = 0;
            ddll_link_type.SelectedIndex = 0;
            textbox_link_author.Clear();
            textbox_link_published_date.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;


            if (e.RowIndex > 0)
            {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row != null) {
                    
                textbox_link_text.Text = row.Cells[2].Value.ToString();
                textbox_sub_link_text.Text = row.Cells[3].Value.ToString();
                textbox_link_content.Text = row.Cells[4].Value.ToString();
                ddll_link_type.Text = row.Cells[5].Value.ToString();
                ddl_sub_category_name.SelectedText = row.Cells[6].Value.ToString();
                link_id = int.Parse(row.Cells[1].Value.ToString());
                    textbox_link_author.Text = row.Cells[8].Value.ToString();
                    textbox_link_published_date.Text = row.Cells[9].Value.ToString();
                    if (DateTime.TryParse(row.Cells[5].Value?.ToString(), out DateTime linkDate))
                    {
                        datetime.Value = linkDate;
                    }
                    if (link_id < 0 || link_id == 0)
                    {
                        String msg = "Empty Cell";
                        new popup(msg).ShowDialog();
                    }

                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Content")
                {


                    if (MessageBox.Show("Are you sure want to see the contents of this link ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        View_Link_Content viewLinkContentForm = new View_Link_Content();
                        viewLinkContentForm.view_content_textbox.Text = row.Cells[4].Value.ToString();
                        viewLinkContentForm.ShowDialog();

                    }
                    else
                    {
                        this.Hide();
                        new Form2().ShowDialog();
                       
                    }
                }
              
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ddl_sub_category_name.Text != "" || ddll_link_type.Text != "" || textbox_link_text.Text != "" || textbox_sub_link_text.Text != "" || textbox_link_content.Text != "")
            {
                var popup = "Are You Sure You Want To Update";
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update link set link_text = @link_text,sub_link_text = @sub_link_text,link_content = @link_content,link_type = @link_type,sub_category_id = @sub_category_id,user_fullname=@user_fullname,date=@date,author=@author,published_date = @published_date where link_id = @link_id", con);
                    cmd.Parameters.AddWithValue("@link_text", textbox_link_text.Text);
                    cmd.Parameters.AddWithValue("@sub_link_text", textbox_sub_link_text.Text);
                    cmd.Parameters.AddWithValue("@link_content", textbox_link_content.Text);
                    cmd.Parameters.AddWithValue("@link_type", ddll_link_type.Text);
                    cmd.Parameters.AddWithValue("@sub_category_id", ddl_sub_category_name.SelectedValue);
                    cmd.Parameters.AddWithValue("@link_id", link_id);
                    cmd.Parameters.AddWithValue("@user_fullname", LoginPage.fullname);
                    cmd.Parameters.AddWithValue("@date", datetime.Value);

                    cmd.Parameters.AddWithValue("@author", textbox_link_author.Text);
                    cmd.Parameters.AddWithValue("@published_date", textbox_link_published_date.Text);
                    new popup(popup, cmd,"update").ShowDialog();
                    
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    showInformation();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
                try
                {
                var popup = "Are You Sure You Want To Delete";
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                    SqlCommand cmd = new SqlCommand("delete link where link_id = @link_id ", con);
                    cmd.Parameters.AddWithValue("@link_id", link_id);
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    new popup(popup, cmd,"delete").ShowDialog();
                    showInformation();

                    clearFields();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void subCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SubCategoryInformation().Show();
        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1 == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false; // Set to true if you want to see Excel in action
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

            // Export headers
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Export data
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    object cellValue = dataGridView1.Rows[i].Cells[j].Value;
                    worksheet.Cells[i + 2, j + 1] = cellValue != null ? cellValue.ToString() : "";
                }
            }

            workbook.SaveAs("Downloads");
            workbook.Close();
            excelApp.Quit();

            // Clean up Excel objects
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Data exported successfully!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void ddl_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillSubCategory();
        }
        public void fillSubCategory()
        {
            try
            {
                string category_name = ddl_category.Text;
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select subcategory.subcategory_name,subcategory.subcategory_id from category inner join subcategory on subcategory.category_id = category.categoryid where category.category_name = '" + category_name + "'", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                ddl_sub_category_name.DataSource = dt;
                ddl_sub_category_name.ValueMember = "subcategory_id";
                ddl_sub_category_name.DisplayMember = "subcategory_name";
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new view().Show();
        }

        public void fillLinkGrid()
        {
            try
            {
                string category_name = ddl_category.Text;
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from link", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        public void fillCategoryCombo()
        {
            try
            {
                string category_name = ddl_category.Text;
                SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter("select * from category", con);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                ddl_category.DataSource = dt;
                ddl_category.ValueMember = "categoryid";
                ddl_category.DisplayMember = "category_name";
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            
            new View_Link_Content().Show();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
