using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLgn_Click(object sender, EventArgs e)
        {
            if (UserBox.Text == "Hamlet" && PassBox.Text == "123")
            {
                this.Hide();
                string user = UserBox.Text;
                Dashboard obj = new Dashboard(char.ToUpper(user[0]) + user.Substring(1));
                obj.Show();
                MessageBox.Show("Login Successfull");
            }
            else
            {
                MessageBox.Show("Given data is incorrect");
            }
        }
    }
}
