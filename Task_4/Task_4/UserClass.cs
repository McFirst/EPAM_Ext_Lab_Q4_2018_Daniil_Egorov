using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class UserClass
    {
        public stirng Login;
        public string Name;
        public string Surname;
        private string Email;
        private string Passw;
        public date Date;
        private list Role;

        public RoleClass RoleClass
        {
            get => default(RoleClass);
            set
            {
            }
        }
    }
}