using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9.Users
{
    public class User
    {
        public int UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string BirthDate { get; set; }
        public string RegistrationDate { get; set; }
        public string Password { get; set; }

        public User()
        {
            this.UserID = -1;
            this.LastName = null;
            this.FirstName = null;
            this.Email = null;
            this.Login = null;
            this.BirthDate = null;
            this.RegistrationDate = null;
            this.Password = null;
        }

        public User(int id, string lastname, string firstname, string email, string login, string birthdate, string regdata, string pass)
        {
            this.UserID = id;
            this.LastName = lastname;
            this.FirstName = firstname;
            this.Email = email;
            this.Login = login;
            this.BirthDate = birthdate;
            this.RegistrationDate = regdata;
            this.Password = pass;
        }
    }
}
