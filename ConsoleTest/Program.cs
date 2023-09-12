using HelperLibrary.Calculations;
using HelperLibrary.Extentions;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(2, 4));
            Console.WriteLine(Calculator.Sub(2, 4));
            Console.WriteLine(Calculator.Mul(2, 4));
            Console.WriteLine(Calculator.Div(2, 4));

            var numbers = new List<int> { 2, 5, 10, 3, 6, 19, 1 };

            Console.WriteLine(String.Join(' ', numbers.SortList().ToArray()));
            Console.WriteLine(numbers.GetElementCount());
            Console.WriteLine(numbers.GetElementByIndex(3));
            Console.WriteLine(numbers.GetSum());
            Console.WriteLine(numbers.GetMin());
            Console.WriteLine(numbers.GetMax());
        }
    }
}