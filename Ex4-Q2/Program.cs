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
﻿using System.Linq;

namespace Ex4_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
          int numOfStudents = 0;
          bool loop = false;

          Console.WriteLine("=========== Dorset College Top & Average Of The Class ===========\n");

          do {
            Console.Write("Enter the total number of students in the class: ");
            try {
              numOfStudents = int.Parse(Console.ReadLine());
            } catch (System.FormatException) {
              Console.WriteLine("\nInput must be a positive whole number! Please, try again.\n");
              loop = true;
              continue;
            }
            if (numOfStudents <= 0) {
              Console.WriteLine("\nInput must be a positive whole number! Please, try again.\n");
              loop = true;
            } else {
              loop = false;
            }
          } while (loop);

          string[] studentsNames = new string[numOfStudents];
          double[] studentsGrades = new double[numOfStudents];

          for (int i=0; i<numOfStudents; i++) {
            Console.Write($"\nEnter Student #{i+1}'s name: ");
            studentsNames[i] = Console.ReadLine();
            do {
              Console.Write($"Enter Student #{i+1}'s final grade: ");
              try {
                studentsGrades[i] = double.Parse(Console.ReadLine());
              } catch (System.FormatException) {
                Console.WriteLine("\nGrade must be a number! Please, try again.\n");
                loop = true;
                continue;
              }
              if (studentsGrades[i] < 0 || studentsGrades[i] > 100) {
                Console.WriteLine("\nGrade must be between 0 and 100! Please, try again.\n");
                loop = true;
              } else {
                loop = false;
              }
            } while (loop);
          }

          double highestGrade = studentsGrades.Max();

          Console.WriteLine($"\nThe average grade of the class is: {studentsGrades.Average()}.");
          Console.WriteLine($"The highest grade achieved is: {highestGrade}.");
          Console.WriteLine("\nThe highest grade was achieved by:\n");
          for (int i=0; i<numOfStudents; i++) {
            if (studentsGrades[i] == highestGrade) {
              Console.WriteLine("{0,10}", studentsNames[i]);
            }
          }

          Console.WriteLine("\n=========== Dorset College Top & Average Of The Class ===========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }
    }
}
