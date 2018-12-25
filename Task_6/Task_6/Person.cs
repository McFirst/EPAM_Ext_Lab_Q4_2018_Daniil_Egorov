namespace Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string[] hi = new string[] { "Good morning, ", "Good apternoon, ", "Good evneng, " };

        /// <summary>
        /// имя сотрудника
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Приветствие сотрудника
        /// </summary>
        /// <param name="user"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public void Hi(Person user, int time)
        {
            string result = null;
            /*
             * 00:00 - 12:00 [Good morning!]
             * 12:00 - 17:00 [Good apternoon!]
             * 17:00 - 00:00 [Good evneng!]
            */
            if(time<12)
            {
                result = hi[0];
            }

            if (time >= 12 & time<17)
            {
                result = hi[1];
            }

            if (time >= 17)
            {
                result = hi[2];
            }

            Console.WriteLine(result + user.Name + "!, - say " + this.Name);
        }

        /// <summary>
        /// проважание сотрудника
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void Bye(Person user)
        {
            string result = null;
            result = "Goodbye, " + user.Name + "!, - say " + this.Name;
            Console.WriteLine(result);
        }

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
