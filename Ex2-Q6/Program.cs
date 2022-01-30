using System;

namespace Ex2_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
          double length = 0, width = 0, fee = 0;
          bool loop = false;

          Console.WriteLine("======================= Dorset College Lawn-Mowing Fee Calculator =======================\n");

          do {
            try {
              Console.Write("Input lawn length in feet: ");
              if ((length = double.Parse(Console.ReadLine())) > 0) {
                loop = false;
              } else {
                Console.WriteLine("\nValue has to be greater than zero! Please, try again.\n");
                loop = true;
              }
            } catch (System.FormatException) {
              Console.WriteLine("\nNumeric values only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          do {
            try {
              Console.Write("Input lawn width in feet: ");
              if ((width = double.Parse(Console.ReadLine())) > 0) {
                loop = false;
              } else {
                Console.WriteLine("\nValue has to be greater than zero! Please, try again.\n");
                loop = true;
              }
            } catch (System.FormatException) {
              Console.WriteLine("\nNumeric values only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          double area = length*width;

          if (area < 400) {
            fee = 25;
          } else if (area < 600) {
            fee = 35;
          } else {
            fee = 50;
          }

          Console.WriteLine("\n=========================================================================================\n");
          Console.WriteLine("{0,13} {1,13} {2,13} {3,17} {4,25}", "Length (ft)", "Width (ft)", "Area (ft²)", "Weekly Fee (\u20ac)", "20-Week Season Fee (\u20ac)");
          Console.WriteLine("{0,13:N2} {1,13:N2} {2,13:N2} {3,17:N2} {4,25:N2}", length, width, area, fee, fee*20);

          Console.WriteLine("\n======================= Dorset College Lawn-Mowing Fee Calculator =======================");
        }
    }
}
