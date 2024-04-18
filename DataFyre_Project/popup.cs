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

namespace datascience_project
{
    public partial class popup : Form
    {
        SqlCommand command = null;
        public popup(String text, SqlCommand cmd)
        {
            InitializeComponent();
            txtMessage.Text = text;
            command = cmd;
        }

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
        }

    }
}
