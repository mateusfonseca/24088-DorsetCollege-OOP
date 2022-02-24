/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

using System;
using System.Text.RegularExpressions;

namespace Ex6_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Dorset College Tax Calculator ===========\n");

            TaxPayer[] taxPayers = new TaxPayer[2];
            bool loop = false;

            for (int i=1; i<=taxPayers.Length; i++) {
                taxPayers[i-1] = new TaxPayer();
                Console.Write($"Tax Payer #{i} Social Security Number: ");
                taxPayers[i-1].SocialSecurityNumber = Console.ReadLine()!.ToUpper();
                while (!Regex.IsMatch(taxPayers[i-1].SocialSecurityNumber!, @"^[A-Z]{3}[0-9]{3}$")) {
                  Console.WriteLine($"\nPlease, follow the format LLLNNN and try again.\n");
                  Console.Write($"Tax Payer #{i} Social Security Number: ");
                  taxPayers[i-1].SocialSecurityNumber = Console.ReadLine()!.ToUpper();
                }
                do {
                  Console.Write($"Tax Payer #{i} Yearly Gross Income: ");
                  try {
                    taxPayers[i-1].YearlyGrossIncome = decimal.Parse(Console.ReadLine()!);
                    loop = false;
                  } catch (System.FormatException) {
                    Console.WriteLine("\nThe input must be a number! Please, try again.\n");
                    loop = true;
                  }
                } while (loop);
                Console.WriteLine();
            }

            Console.WriteLine("\n=================== Tax Payer(s) ====================\n");
            Console.WriteLine("{0,10} {1,15} {2,15}", "SSNo", "Income", "Taxes");
            Console.WriteLine();
            foreach (TaxPayer taxPayer in taxPayers) {
                Console.WriteLine("{0,10} {1,15:C} {2,15:C}", taxPayer.SocialSecurityNumber, taxPayer.YearlyGrossIncome, taxPayer.TaxOwed);
            }

            Console.WriteLine("\n=========== Dorset College Tax Calculator ===========");

            Console.Write("\nPress \"Enter/Return\" to end... ");
            Console.ReadLine();
        }
    }

    class TaxPayer
    {
        private decimal yearlyGrossIncome;

        public string? SocialSecurityNumber { get; set; }
        public decimal TaxOwed { get; private set; }
        public decimal YearlyGrossIncome {
          get { return yearlyGrossIncome; }
          set {
            yearlyGrossIncome = value;
            TaxOwed = yearlyGrossIncome < 30000 ? yearlyGrossIncome*(decimal)0.15 : yearlyGrossIncome*(decimal)0.28;
          }
        }
    }
}
