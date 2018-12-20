using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class Material
    {
        public string Caption;
        public string Autor;
        public string Type;
        public DateTime Date;
        public float Rating;
        public List<string> Tag;
        private string Path;

        public Tags TagClass
        {
            get => default(Tags);
            set
            {
            }
        }

        public Ratings RatingClass
        {
            get => default(Ratings);
            set
            {
            }
        }

        public MaterialFilter MaterialFilter
        {
            get => default(MaterialFilter);
            set
            {
            }
        }

        public MaterialService MaterialService
        {
            get => default(MaterialService);
            set
            {
            }
        }
    }
}