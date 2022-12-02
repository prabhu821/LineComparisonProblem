using static LineComparison.LineCompare;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Problem Statement");
            LineCompare lineCompare = new LineCompare(2, 4, 3, 4);
            lineCompare.CalculateLength();
       


            LineCompare lineCompare1 = new LineCompare(1, 2, 3, 4);
            double lenght1 = lineCompare1.Calculate();
            LineCompare lineCompare2 = new LineCompare(1, 3, 3, 4);
            double lenght2 = lineCompare2.Calculate();

            if (lenght1.Equals(lenght2))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both Lines are not equal");



            LineCompare lineCompare3 = new LineCompare(1, 3, 2, 4);
            double lenght3 = lineCompare3.Calculate();
            LineCompare lineCompare4 = new LineCompare(1, 3, 2, 4);
            double lenght4 = lineCompare4.Calculate();

            if (lenght3.Equals(lenght4))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both Lines are not equal");
            if (lenght3.CompareTo(lenght4) == 0)
            {
                Console.WriteLine("Line 1 and Line 2 both are equal");
                return;
            }
            if (lenght3.CompareTo(lenght4) > 0)
                Console.WriteLine("Line 1 is greate than Line 2");
            else
                Console.WriteLine("Line 2 is greater than Line 1");
        }
    }
}