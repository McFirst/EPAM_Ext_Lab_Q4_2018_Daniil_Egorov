namespace Task_9.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class User
    {
        public User()
        {
            this.UserID = -1;
            this.LastName = null;
            this.FirstName = null;
            this.Email = null;
            this.Login = null;
            this.BirthDate = default(DateTime);
            this.RegistrationDate = default(DateTime);
            this.Password = null;
        }

        public User(int id, string lastname, string firstname, string email, string login, DateTime birthdate, DateTime regdata, string pass)
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

        public int UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Password { get; set; }
    }
}
