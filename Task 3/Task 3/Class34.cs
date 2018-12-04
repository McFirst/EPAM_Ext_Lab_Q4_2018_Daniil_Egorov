namespace Task_3
{
    /// <summary>
    /// задание 4
    /// </summary>
    public class Class34 : Class33
    {
        public void Еriangle(double countta)
        {
            for (int i = 1; i < countta; i++)
            {
                this.Pipyramid(i, countta - i);
            }
        }
    }
}
