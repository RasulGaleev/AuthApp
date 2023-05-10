using lr11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                string Created = DateTime.Now.ToString();
                User user = new User(loginBox.Text, passwordBox.Text, emailBox.Text,
                    phoneBox.Text, nameBox.Text, lastnameBox.Text, roleBox.Text, birthPicker.Text, Created);
                db.Users.Add(user);
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
