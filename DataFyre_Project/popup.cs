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
    public partial class popup : Form
    {
        SqlCommand command = null;
        String SendType = null;
        public popup(String text, SqlCommand cmd, String sendType)
        {
            InitializeComponent();
            txtMessage.Text = text;
            command = cmd;
            btnOk.Visible = false;
            pictureBox1.Visible = false;
            SendType = sendType;
        }
        public popup(String txt)
        {
            InitializeComponent();
            txtMessage.Text = txt;
            NoBtn.Visible = false;
            yesBtn.Visible = false;
            btnOk.Visible = true;
            pictureBox1.Visible = true;
        }
        public popup()
        {
            InitializeComponent();
            NoBtn.Visible = false;
            yesBtn.Visible = false;
            btnOk.Visible = true;
            pictureBox1.Visible = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
        void yesBtn_Click(object sender, EventArgs e)
        {
            command.ExecuteNonQuery();
            this.Hide();
            if (SendType == "delete")
            {
                new popup("             Deleted Successfully").ShowDialog();
                pictureBox1.Visible = true;
                this.Hide();
            }
            if (SendType == "update")
            {
                new popup("             Updated Successfully").ShowDialog();
                pictureBox1.Visible = true;
                this.Hide();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
