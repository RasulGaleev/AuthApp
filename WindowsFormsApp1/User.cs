using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string Birth { get; set; }
        public string Created { get; set; }



        public User()
        { }
        public User(string Login, string Password, string Email, string Phone, string Name, string LastName, string Role, string Birth, string Created)
        {
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
            this.Birth = Birth;
            this.Role = Role;
            this.Name = Name;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Created = Created;
        }

    }
}