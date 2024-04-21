using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datascience_project
{
    public partial class logoutpopup : Form
    {
        public logoutpopup(String msg)
        {
            InitializeComponent();
            txtMessage.Text = msg;
            btnOk.Visible = false;
            pictureBox1.Visible = false;
        }

        public logoutpopup(string msg, string sendType) {
            if(sendType == "OK")
            {
                InitializeComponent();
                txtMessage.Text = msg;
                yesBtn.Visible = false;
                NoBtn.Visible = false;
                btnOk.Visible =true;
                pictureBox1.Visible=true;
            }
        }
        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.Close ();
            string msg = "             Logout Successfully";
            pictureBox1.Visible = true;
            new logoutpopup(msg, "OK").ShowDialog();
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1000); // 20 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                form.Hide();
            }
           
            new LoginPage().Show();
        }

    
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
