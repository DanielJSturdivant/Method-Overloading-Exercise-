using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        

        public static int Add(int y, int x)
        {
            return y + x;
        }

        public static decimal Add(decimal y, decimal x)
        {
            return y + x;
        }

        public static string Add(int y, int x, bool w)
        {
            int sum = y + x;

            if (w == true && sum == 1)
            {
                return sum.ToString() + " dollar";
            }
            else if (w == true && sum != 1)
            {
                return sum.ToString() + " dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.2m, 2.5m));
            Console.WriteLine(Add(1, 2, true));
        }
    }
}
