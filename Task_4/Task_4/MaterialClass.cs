using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    public class MaterialClass
    {
        public string Caption;
        public string Autor;
        public string Type;
        public date Date;
        private string Path;
        public float Rating;
        public list Tag;

        public TagClass TagClass
        {
            get => default(TagClass);
            set
            {
            }
        }

        public RatingClass RatingClass
        {
            get => default(RatingClass);
            set
            {
            }
        }

        public string Content()
        {
            throw new System.NotImplementedException();
        }
    }
}