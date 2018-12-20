using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class MaterialService : IBaseService<Material>
    {
        private List<Material> mat = new List<Material>(3);

        public bool Delete(int id)
        {
            if(mat.Count >= id)
            {
                mat.RemoveAt(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Material Get(int id)
        {
            if (mat.Count >= id)
            {
                return mat[id];
            }
            else
            {
                return null;
            }
        }

        public List<Material> GetAll()
        {
            return mat;
        }

        public bool Save(Material entity)
        {
            if (mat.Exists(x => x == entity))
            {
                mat.Add(entity);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}