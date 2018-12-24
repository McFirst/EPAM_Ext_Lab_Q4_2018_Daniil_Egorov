using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class SortLength
    {
        #region DelegateBlock
        //////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>
        /// Тип делегата
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        public delegate bool Strcompare(string str1, string str2);

        /// <summary>
        /// Переcwменная типа делегата
        /// </summary>
        private Strcompare listcomp;

        /// <summary>
        /// Метод для регистрации обработного вызова (для инкапсуляции)
        /// </summary>
        /// <param name="methodToCall"></param>
        public void RegisterComp(Strcompare methodToCall)
        {
            listcomp = methodToCall;
        }

        /// <summary>
        /// Метод для отвязки
        /// </summary>
        /// <param name="methodToCall"></param>
        public void UnRegisteComp(Strcompare methodToCall)
        {
            listcomp -= methodToCall;
        }

        //////////////////////////////////////////////////////////////////////////////////
        #endregion

        private string[] lines;

        public string[] StringSort(string[] input)
        {
            lines = input;
            string str = null;
            for (int i = 0; i < lines.Length - 1; i++)
            {
                for (int j = i + 1; j < lines.Length; j++)
                {
                    if (listcomp(lines[i], lines[j]))
                    {
                        str = lines[i];
                        lines[i] = lines[j];
                        lines[j] = str;
                    }
                }
            }
            return lines;
        }
    }
}
