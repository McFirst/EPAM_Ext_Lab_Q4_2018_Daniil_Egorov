namespace Task_4.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Passw { get; set; }
        public string Date { get; set; }
        public string Role { get; set; }

        public User()
        {
            this.ID = -1;
            this.Login = null;
            this.Name = null;
            this.Surname = null;
            this.Passw = null;
            this.Email = null;
            this.Date = null;
            this.Role = null;
        }

        public User(int id, string login, string nameUser, string surnameUser, string emailUser, string password, string dateUser, string role)
        {
            this.ID = id;
            this.Login = login;
            this.Name = nameUser;
            this.Surname = surnameUser;
            this.Passw = password;
            this.Email = emailUser;
            this.Date = dateUser;
            this.Role = role;
        }

        public UserService UserService
        {
            get => default(UserService);
            set
            {
            }
        }
    }
}