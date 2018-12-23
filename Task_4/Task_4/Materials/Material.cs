namespace Task_4.Materials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Material
    {
        public int ID;
        public string Caption;
        public string Autor;
        public string Type;
        public string Date;
        public float Rating;
        public string Tag;
        public string Path;

        public Material()
        {
            this.ID = -1;
            this.Caption = null;
            this.Autor = null;
            this.Type = null;
            this.Date = null;
            this.Rating = 0;
            this.Tag = null;
            this.Path = null;
        }

        public Material(int id, string caption, string autor, string type, string date, float rating, string tag, string path)
        {
            this.ID = id;
            this.Caption = caption;
            this.Autor = autor;
            this.Type = type;
            this.Date = date;
            this.Rating = rating;
            this.Tag = tag;
            this.Path = path;
        }

        public MaterialService MaterialService
        {
            get => default(MaterialService);
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

        public Ratings Ratings
        {
            get => default(Ratings);
            set
            {
            }
        }

        public Tags Tags
        {
            get => default(Tags);
            set
            {
            }
        }
    }
}