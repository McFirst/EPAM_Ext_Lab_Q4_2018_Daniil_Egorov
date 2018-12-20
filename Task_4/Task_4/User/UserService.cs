using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class UserService : IBaseService<User>
    {
        private List<User> use = new List<User>(3);

        public bool Delete(int id)
        {
            if (use.Count >= id)
            {
                use.RemoveAt(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public User Get(int id)
        {
            if (use.Count >= id)
            {
                return use[id];
            }
            else
            {
                return null;
            }
        }

        public List<User> GetAll()
        {
            return use;
        }

        public bool Save(User entity)
        {
            if (use.Exists(x => x == entity))
            {
                use.Add(entity);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}