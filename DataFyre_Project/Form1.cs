﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace datascience_project
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=192.168.1.102;Initial Catalog=datasience_db;User ID=sa;Password=Allah@786;Encrypt=False");

        int category_id;
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void clearFields()
        {
            textbox_categoryname.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCategoryGrid();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            if (e.RowIndex > 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row != null)
                {
                    textbox_categoryname.Text = row.Cells[1].Value.ToString();
                    category_id = int.Parse(row.Cells[0].Value.ToString());


                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String msg = "              Saved Successfully";
            if (textbox_categoryname.Text != "")
            {   
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into category values (@category_name)", con);
                    cmd.Parameters.AddWithValue("@category_name", textbox_categoryname.Text);
                    cmd.ExecuteNonQuery();
                    new popup(msg).ShowDialog();
                    con.Close();
                    fillCategoryGrid();
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

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox_categoryname.Text != "")
            {
                String msg = "Are You Sure You Want To Update";
                try
                {
                    if (con.State != System.Data.ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("update category set category_name = @category_name where categoryid = @categoryid", con);
                    cmd.Parameters.AddWithValue("@category_name", textbox_categoryname.Text);
                    cmd.Parameters.AddWithValue("@categoryid", category_id);
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    new popup(msg,cmd,"update").ShowDialog();
                    con.Close();
                    fillCategoryGrid();
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

        private void button2_Click(object sender, EventArgs e)
        {
            String msg = "Are You Sure You Want To Delete";
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("delete from category where categoryid = @categoryid", con);
                cmd.Parameters.AddWithValue("@categoryid", category_id);
                cmd.ExecuteNonQuery();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                new popup(msg,cmd,"delete").ShowDialog();
                con.Close();
                fillCategoryGrid();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            new view().Show();
        }

        private void panel5_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        public void fillCategoryGrid()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from category", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
           new View_Link_Content().ShowDialog();


        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            new import().Show();
        }
    }
}
