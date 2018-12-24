namespace Task_4.Materials
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Material
    {
        public int ID { get; set; }
        public string Caption { get; set; }
        public string Autor { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public float Rating { get; set; }
        public string Tag { get; set; }
        public string Path { get; set; }

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