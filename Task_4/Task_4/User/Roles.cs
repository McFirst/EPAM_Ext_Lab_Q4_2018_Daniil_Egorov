using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class Roles
    {
        private string Role;

        public Guest UserView
        {
            get => default(Guest);
            set
            {
            }
        }

        public Admin UserAdmin
        {
            get => default(Admin);
            set
            {
            }
        }
    }
}