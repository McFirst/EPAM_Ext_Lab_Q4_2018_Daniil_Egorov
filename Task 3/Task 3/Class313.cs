namespace Task_3
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

    /// <summary>
    /// задание 13
    /// </summary>
    public class Class313
    {
        public void Сomparison()
        {
            for (int j = 0; j < 1000; j++)//todo pn хардкод
            {
                string str = string.Empty;
                StringBuilder sb = new StringBuilder();
                int n = 250000;
                Stopwatch swstr = new Stopwatch();
                Stopwatch swsb = new Stopwatch();

                swstr.Start();
                for (int i = 0; i < n; i++)
                {
                    str += "*";//todo pn хардкод
                }

                swstr.Stop();

                swsb.Start();
                for (int i = 0; i < n; i++)
                {
                    sb.Append("*");//todo pn хардкод
                }

                swsb.Stop();

                StringBuilder text = new StringBuilder(string.Empty);
                TimeSpan ts = swstr.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                text.Append(j.ToString() + "\n");
                text.Append("RunTime String " + elapsedTime + "\n");

                ts = swsb.Elapsed;
                elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                text.Append("RunTime StringBulder " + elapsedTime + "\n" + "\n");
                Console.Write(text.ToString());

                string path = @"D:\work\epam\labs\Task 3\Task 3\13.txt";
                File.AppendAllText(path, text.ToString());
            }
        }
    }
}
