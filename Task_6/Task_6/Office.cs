using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Office
    {
        #region DelegateBlock
        //////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// тип делегат прихода
        /// </summary>
        /// <param name="user">сотрудник</param>
        /// <param name="time">время прихода</param>
        public delegate void Comein(Person user, int time);

        /// <summary>
        /// тип делегат ухода
        /// </summary>
        /// <param name="user"></param>
        public delegate void Comeout(Person user);

        /// <summary>
        /// переменная делегата прихода
        /// </summary>
        public event  Comein Income;

        /// <summary>
        /// переменная делегата прихода
        /// </summary>
        public event Comeout Outcom;

        //////////////////////////////////////////////////////////////////////////////////
        #endregion

        ///
    }
}
