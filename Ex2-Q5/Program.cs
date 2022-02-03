/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

﻿using System;

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
                Console.WriteLine("Your hourly pay rate has to be between $7.50 and $49.00, inclusive! Please, try again.\n");
                loop = true;
              } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nALL GOOD! YOUR HOURLY PAY RATE HAS BEEN SUCCESSFULLY VERIFIED!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your hourly pay rate is between $7.50 and $49.00! Nothing to worry about.");
                loop = false;
              }
            } catch (System.FormatException) {
              Console.WriteLine("\nNumeric values only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          Console.WriteLine("\n======== Dorset College Hourly Pay Rate Verifier ========");

          Console.Write("\nPress any key to end... ");
          Console.ReadLine();
        }
    }
}
