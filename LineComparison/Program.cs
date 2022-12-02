using static LineComparison.LineCompare;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Problem Statement");
            LineCompare lineCompare = new LineCompare(2, 4, 6, 8);
            lineCompare.CalculateLength();
        }
    }
}