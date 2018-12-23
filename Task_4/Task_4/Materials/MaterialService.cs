namespace Task_4.Materials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Task_4.Interface;

    public class MaterialService : IMaterialService
    {
        private List<Material> mat = new List<Material>(3);

        public bool Delete(int id)
        {
            bool del = false;
            foreach (Material i in this.mat)
            {
                if (i.ID == id)
                {
                    this.mat.RemoveAt(id);
                    del = true;
                    break;
                }
            }

            return del;
        }

        public Material Get(int id)
        {
            Material ret = null;
            foreach (Material i in this.mat)
            {
                if (i.ID == id)
                {
                    ret = i;
                }
            }

            return ret;
        }

        public List<Material> GetAll()
        {
            return this.mat;
        }

        public bool Save(Material entity)
        {
            if (this.mat.Exists(x => x == entity))
            {
                return false;
            }
            else
            {
                this.mat.Add(entity);
                return true;
            }
        }

        public bool LoadMaterials()
        {
            Material mat1 = new Material(1, "Material1", "Autor1", "Type1", "01.01.2001", 2, "Tag1", "C:\\mat1");
            Material mat2 = new Material(2, "Material2", "Autor2", "Type2", "02.02.2002", 4, "Tag2", "C:\\mat2");
            this.mat.Add(mat1);
            this.mat.Add(mat2);
            return true;
        }
    }
}