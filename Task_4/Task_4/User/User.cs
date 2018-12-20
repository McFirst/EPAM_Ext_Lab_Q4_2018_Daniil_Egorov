using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class User
    {
        public string Login;
        public string Name;
        public string Surname;
        public string Email;
        public string Passw;
        public string Date;
        private string Role;

        public Roles RoleClass
        {
            get => default(Roles);
            set
            {
            }
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