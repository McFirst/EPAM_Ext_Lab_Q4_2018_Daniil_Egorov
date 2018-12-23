namespace Task_4.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Roles
    {
        public string Role;

        public Guest Guest
        {
            get => default(Guest);
            set
            {
            }
        }

        public Admin Admin
        {
            get => default(Admin);
            set
            {
            }
        }
    }
}