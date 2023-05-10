using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        public LoginForm login_form;
        public void Login(string login, string lastname, string name, string phone, string email,
            string birth, string role, string created)
        {
            textBox1.Text = login;
            textBox2.Text = lastname;
            textBox3.Text = name;
            textBox4.Text = phone;
            textBox5.Text = email;
            textBox6.Text = birth;
            textBox7.Text = role;
            textBox8.Text = created;
        }


        private void close_button_Click(object sender, EventArgs e)
        {
            login_form.Visible = true;
            this.Close();
        }
    }
}
