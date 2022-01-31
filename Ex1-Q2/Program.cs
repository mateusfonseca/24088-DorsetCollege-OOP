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
﻿using System.Threading;

namespace Ex1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
          double length = 0, width = 0;
          bool loop = false;
          const double euroPerSquareFoot = 5;

          Console.WriteLine("======== Dorset College Carpeting Price Calculator ========\n");

          do {
            try {
              Console.Write("Input room length in feet: ");
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
              Console.Write("Input room width in feet: ");
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

          // Uncomment the section below to make it more fun
          // Console.WriteLine("\nCalculating...\n");
          // for (int i=0; i<width; i++) {
          //   for (int j=0; j<length; j++) {
          //     if (i == 0 || i == width-1) {
          //       Console.Write("\u25a0");
          //       Thread.Sleep(1);
          //     } else {
          //       if (j == 0 || j == length-1) {
          //         Console.Write("\u25a0");
          //         Thread.Sleep(1);
          //       } else {
          //         Console.Write("#");
          //         Thread.Sleep(1);
          //       }
          //     }
          //   }
          //   Console.WriteLine();
          // }

          Console.WriteLine("\n===========================================================\n");
          Console.WriteLine("{0,13} {1,13} {2,13} {3,13}", "Length (ft)", "Width (ft)", "Area (ft²)", "Price (\u20ac)");
          Console.WriteLine("{0,13:N2} {1,13:N2} {2,13:N2} {3,13:N2}", length, width, length*width, length*width*euroPerSquareFoot);

          Console.WriteLine("\n======== Dorset College Carpeting Price Calculator ========");

          Console.Write("\nPress any key to end... ");
          Console.ReadLine();
        }
    }
}
