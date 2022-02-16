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
using System.Linq;
using System.Text.RegularExpressions;

namespace Ex4_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] validZipCodes = {
            "A1B2C3",
            "D4E5F6",
            "G7H8I9",
            "J1K2L3",
            "M4N5O6",
            "P7Q8R9",
            "S1T2U3",
            "V4X5Z6",
            "A7B8C9",
            "D1E2F3"
          };
          string userZipCode;

          Console.WriteLine("=========== Dorset College Delivery By Zip Code ===========\n");

          Console.Write($"Enter your zip code: ");
          userZipCode = Console.ReadLine().ToUpper();

          while (!Regex.IsMatch(userZipCode, @"^([A-Z][1-9]){3}$")) {
            Console.WriteLine($"\nThe format of the provided zip code is not supported!\nPlease, follow the standard LNLNLN (where L is a letter from A to Z and N is a number from 1 to 9) and try again.\n");
            Console.Write($"Enter your zip code: ");
            userZipCode = Console.ReadLine().ToUpper();
          }

          if (validZipCodes.Contains(userZipCode)) {
            Console.WriteLine("\nYour zip code is within our delivery area!\nWe'll be happy to bring your package to you!");
          } else {
            Console.WriteLine("\nYour zip code is outside our delivery area!\nUnfortunately, we won't be able to bring your package to you!");
          }

          Console.WriteLine("\n=========== Dorset College Delivery By Zip Code ===========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }
    }
}
