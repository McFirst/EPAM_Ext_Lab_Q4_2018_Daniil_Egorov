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
        /// конструктор
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            this.Name = name;
        }

        #region DelegateBlock
        //////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// тип делегат прихода
        /// </summary>
        /// <param name="user">сотрудник</param>
        /// <param name="time">время прихода</param>
        public delegate void PersonEvent(string message);

        /// <summary>
        /// переменная делегата прихода
        /// </summary>
        public event PersonEvent Income;

        /// <summary>
        /// переменная делегата прихода
        /// </summary>
        public event PersonEvent Outcome;

        //////////////////////////////////////////////////////////////////////////////////
        #endregion

        /// <summary>
        /// имя сотрудника
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// событие прихода сотрудника
        /// </summary>
        /// <param name="user"></param>
        public void OnCome(Person user)
        {
            if (this.Income != null)
            {
                Console.WriteLine();
                Console.WriteLine(user.Name + " come to office.");
            }
        }

        /// <summary>
        /// событие ухода сотрудника
        /// </summary>
        /// <param name="user"></param>
        public void OnLeave(Person user)
        {
            if (this.Outcome != null)
            {
                Console.WriteLine();
                Console.WriteLine(user.Name + " leave office.");
            }
        }

        /// <summary>
        /// Вывод сообщения
        /// </summary>
        /// <param name="message"></param>
        public void ShowMessege(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// приход в офис
        /// </summary>
        /// <param name="user"></param>
        /// <param name="time"></param>
        /// <param name="office"></param>
        public void ComeInOffice(Person user, int time, List<Person> office)
        {
            user.Income += this.ShowMessege;
            user.OnCome(user);
            user.Hi(user, time, office);
            office.Add(user);
        }

        /// <summary>
        /// покидание офиса
        /// </summary>
        /// <param name="user"></param>
        /// <param name="office"></param>
        public void LeaveOffice(Person user, List<Person> office)
        {
            user.Outcome += this.ShowMessege;
            user.OnLeave(user);
            office.Remove(user);
            user.Bye(user, office);
        }

        /// <summary>
        /// Приветствие сотрудника
        /// </summary>
        /// <param name="user"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public void Hi(Person user, int time, List<Person> office)
        {
            int time1 = 12;
            int time2 = 17;
            string result = null;

            foreach (Person i in office)
            {
                if (time < time1)
                {
                    result = this.hi[0];
                }

                if (time >= time1 & time < time2)
                {
                    result = this.hi[1];
                }

                if (time >= time2)
                {
                    result = this.hi[2];
                }

                this.ShowMessege(result + user.Name + "!, - say " + i.Name);
            }
        }

        /// <summary>
        /// проважание сотрудника
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void Bye(Person user, List<Person> office)
        {
            foreach (Person i in office)
            {
                this.ShowMessege("Goodbye, " + user.Name + "!, - say " + i.Name);
            }
        }
    }
}
