using System;

namespace MethodOverloading
{
    internal class Program
    {

        public static int Add(int x, int y)
        { return x + y; }

        public static decimal Add(decimal a, decimal b)
        { return a + b; }

        public static string Add(int x, int y, bool isCheck)
        {
            var sum = x + y;

            if (isCheck == true )
            {
                if (sum == 1)
                { return ($"{sum} dollar"); }
                else { return ($"{sum} dollars"); }
            }
            else { return sum.ToString(); }
        }
        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);

        }





    }
}
    

