using System;

namespace Ex2_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
          double rate = 0;
          bool loop = false;

          Console.WriteLine("======== Dorset College Hourly Pay Rate Verifier ========\n");

          do {
            try {
              Console.Write("Input hourly pay rate: ");
              rate = double.Parse(Console.ReadLine());
              if (rate < 7.5 || rate > 49) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR! WRONG HOURLY PAY RATE INSERTED!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your hourly pay rate has to be greater than $7.50 and less than $49.00! Please, try again.\n");
                loop = true;
              } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nALL GOOD! YOUR HOURLY PAY RATE HAS BEEN SUCCESSFULLY VERIFIED!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your hourly pay rate is greater than $7.50 and less than $49.00! Nothing to worry about.\n");
                loop = false;
              }
            } catch (System.FormatException) {
              Console.WriteLine("\nNumeric values only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          Console.WriteLine("\n======== Dorset College Hourly Pay Rate Verifier ========");
        }
    }
}
