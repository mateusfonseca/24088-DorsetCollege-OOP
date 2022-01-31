/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:		        24088
Student Email:		        24088@student.dorset-college.ie
*/

﻿using System;

namespace Ex1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
          double minutes = 0;
          bool loop = false;

          Console.WriteLine("======== Dorset College Minutes-to-HH:MM Converter ========\n");

          do {
            try {
              Console.Write("Input total amount of time in minutes only: ");
              if ((minutes = double.Parse(Console.ReadLine())) >= 0) {
                loop = false;
              } else {
                Console.WriteLine("\nValue has to be positive! Please, try again.\n");
                loop = true;
              }
            } catch (System.FormatException) {
              Console.WriteLine("\nNumeric values only! Please, try again.\n");
              loop = true;
            }
          } while (loop);

          int hh = (int)minutes/60;
          int mm = (int)minutes-(hh*60);
          // alternative with DateTime can only display hours from 0 to 24
          // DateTime time = new(1,1,1,hh,mm,0);

          Console.WriteLine("\n===========================================================\n");
          Console.WriteLine("{0,13} {1,13} {2,13}", "Minutes", ">>>", "HH:MM");
          Console.WriteLine("{0,13:N2} {1,13} {2,13}", minutes, ">>>", $"{hh.ToString("D2")}:{mm.ToString("D2")}");
          // alternative with DateTime can only display hours from 0 to 24
          // Console.WriteLine("{0,13:N2} {1,13} {2,13}", minutes, ">>>", time.ToString("HH:mm"));

          Console.WriteLine("\n======== Dorset College Minutes-to-HH:MM Converter ========");

          Console.Write("\nPress any key to end... ");
          Console.ReadLine();
        }
    }
}
