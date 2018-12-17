using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class Admin : User
    {
        public MaterialClass MaterialClass
        {
            get => default(MaterialClass);
            set
            {
            }
        }

        public void AddUser()
        {
            throw new System.NotImplementedException();
        }

        public void AddMaterial()
        {
            throw new System.NotImplementedException();
        }
    }
}