using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarian
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logo.Location = new Point(this.Width/2- logo.Width/2, logo.Location.Y);
            login.Location = new Point(this.Width / 2 - login.Width / 2, login.Location.Y);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsLoginEmpty())
            {
                MessageBox.Show("Please fill out all fields");
                return;
            }
            Viewer viewer = new Viewer();
            if (!viewer.CreateConnection(txt_ip.Text, txt_port.Text, txt_id.Text, txt_password.Text, txt_dbname.Text))
            {
                MessageBox.Show("Unable to connect to Database server\nCheck credentials or server is offline?");
                viewer.Dispose();
                return;
            }
            viewer.Show(this);
            this.Hide();
        }

        private bool IsLoginEmpty()
        {
            foreach(TextBox txt in login.Controls.OfType<TextBox>())
            {
                if (txt.Text.Length == 0){
                    return true;
                }
            }
            foreach (MaskedTextBox txt in login.Controls.OfType<MaskedTextBox>())
            {
                if (txt.Text.Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was created by:\nMaria Traga, mppl19058, mariatr25li@gmail.com\nDimitris Malliaris, mppl19034, dimitris.mlr@outlook.com");
        }
    }
}
