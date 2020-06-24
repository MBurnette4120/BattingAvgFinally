using System;

namespace BattingAvgFinally
{
    class Program
    {
        public static double Bavg(double num1, double num2)
        {
            var answer = (num1 / num2);
            return answer;

        }

        static void Main(string[] args)
        {

            {
                Console.WriteLine("Enter the number of hits.");
                var hits = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter the number of at bats.");
                var abs = int.Parse(Console.ReadLine());


                double batAvg = Bavg(hits, abs);
                Console.WriteLine($"Your batting average is {batAvg}");



            }
        }
    }

}
