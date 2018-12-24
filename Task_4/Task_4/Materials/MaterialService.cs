namespace Task_4.Materials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Task_4.Interface;

    public class MaterialService : IMaterialService
    {
        /// <summary>
        /// приватный список материалов
        /// </summary>
        private List<Material> mat = new List<Material>(3);

        /// <summary>
        /// Удаление материала по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            Material y = null;
            y = this.mat.FirstOrDefault(x => x.ID == id);
            if (y != null)
            {
                this.mat.Remove(y);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// получение материала по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// получение всего списка материалов
        /// </summary>
        /// <returns></returns>
        public List<Material> GetAll()
        {
            return this.mat;
        }

        /// <summary>
        /// добавление нового материала
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Save(Material entity)
        {
            if (this.mat.Exists(x => x.ID == entity.ID))
            {
                return false;
            }
            else
            {
                this.mat.Add(entity);
                return true;
            }
        }

        /// <summary>
        /// первичная загрузка материалов
        /// </summary>
        /// <returns></returns>
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