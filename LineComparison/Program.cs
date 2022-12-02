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
       

            LineCompare calculateLength1 = new LineCompare(1, 2, 3, 4);
            double lenght1 = calculateLength1.Calculate();
            LineCompare calculateLength2 = new LineCompare(1, 3, 3, 4);
            double lenght2 = calculateLength2.Calculate();

            if (lenght1.Equals(lenght2))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both Lines are not equal");
        }
    }
}