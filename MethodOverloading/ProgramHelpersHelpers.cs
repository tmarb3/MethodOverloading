namespace MethodOverloading
{
    internal static class ProgramHelpersHelpers
    {

        public static string Add(int x, int y, bool check)
        {
            var sum = x + y;

            if (check)
            {
                if (sum == 1)
                { return ($"1 dollar"); }
                else return ($"{sum} dollars");

            }
        }
    }
}