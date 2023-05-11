using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class PasswordForm : Form
    {
        public LoginForm login_form;
        private string pass;
        private Random random = new Random();
        private string simbols = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
        public PasswordForm()
        {
            InitializeComponent();
        }
        private string Pass()
        {
            for (int i = 0; i < 8; i++)
            {
                pass += simbols[random.Next(62)];
            }
            return login_form.GetHashString(pass);
        }

        private void password_button_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("i_ivan_ivanov99@mail.ru", "Ivan");
            MailAddress to = new MailAddress(emailBox.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Пароль для входа в аккаунт";
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (emailBox.Text == user.Email)
                    {
                        user.Password = Pass();
                        m.Body = "<h1>Новый пароль: " + pass + "</h1>";
                    }
                }
                db.SaveChanges();

            }
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("i_ivan_ivanov99@mail.ru", "eD0rygASvGsRcmMLmjN8");
            smtp.EnableSsl = true;
            smtp.Send(m);
            login_form.Visible = true;
            this.Close();

        }
    }
}
