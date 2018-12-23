namespace Task_4.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Task_4.Materials;

    public class Admin : User
    {
        public Material Material
        {
            get => default(Material);
            set
            {
            }
        }
    }
}