namespace Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortLength
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
            this.listcomp = methodToCall;
        }

        /// <summary>
        /// Метод для отвязки
        /// </summary>
        /// <param name="methodToCall"></param>
        public void UnRegisteComp(Strcompare methodToCall)
        {
            this.listcomp -= methodToCall;
        }
        //////////////////////////////////////////////////////////////////////////////////
        #endregion

        /// <summary>
        /// внетренний массив строк
        /// </summary>
        private string[] lines;

        /// <summary>
        /// сортировка массива
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string[] StringSort(string[] input)
        {
            this.lines = input;
            string str = null;
            for (int i = 0; i < this.lines.Length - 1; i++)
            {
                for (int j = i + 1; j < this.lines.Length; j++)
                {
                    if (this.listcomp != null)
                    {
                        if (this.listcomp(this.lines[i], this.lines[j]))
                        {
                            str = this.lines[i];
                            this.lines[i] = this.lines[j];
                            this.lines[j] = str;
                        }
                    }
                }
            }

            return this.lines;
        }
    }
}
