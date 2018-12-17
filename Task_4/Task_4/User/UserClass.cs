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
        private string Email;
        private string Passw;
        public DateTime Date;
        private List Role;

        public RoleClass RoleClass
        {
            get => default(RoleClass);
            set
            {
            }
        }
    }
}