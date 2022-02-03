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

namespace Ex3_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
          Random randomGenerator = new Random();
          int randomNumber = 0, guess = 0, wins = 0, losses = 0, min = 1, max = 10, chances = 5;
          bool loop = false;

          Console.WriteLine("=========== Dorset College Random Number Guessing Game 2.0 ===========");

          do {
            randomNumber = randomGenerator.Next(min,max+1);

            Console.WriteLine();
            for (int i=0; i<chances; i++) {
              do {
                try {
                  Console.Write($"Enter your guess ({min} to {max}): ");
                  guess = int.Parse(Console.ReadLine());
                  if (guess >= min && guess <= max) {
                    loop = false;
                  } else {
                    Console.WriteLine($"\nThe minimum value is {min} and the maximum is {max}! Please, try again.\n");
                    loop = true;
                  }
                } catch (System.FormatException) {
                  Console.WriteLine("\nIntegers only! Please, try again.\n");
                  loop = true;
                }
              } while (loop);

              if (guess > randomNumber) {
                Console.WriteLine("\nYour guess was too high! Try again.\n");
              } else if (guess < randomNumber) {
                Console.WriteLine("\nYour guess was too low! Try again.\n");
              } else {
                Console.WriteLine();
                foreach (char ch in "SPOT ON!!!") {
                  try {
                    Console.ForegroundColor = (ConsoleColor)randomNumber++;
                  } catch (System.ArgumentException) {
                    randomNumber = 0;
                    Console.ForegroundColor = (ConsoleColor)randomNumber++;
                  }
                  Console.Write(ch);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nCongratulations, you have guessed it rigth!\n");
                wins++;
                break;
              }

              if (i == chances-1) {
                Console.WriteLine("It looks like you have run out of guesses. Better luck next time!\n");
                losses++;
              }
            }

            int score = wins-losses;
            Console.WriteLine("========================== Score Sheet ===============================\n");
            Console.WriteLine("{0,13} {1,13} {2,13} {3,17}", "Attempts", "Wins", "Losses", "Final Score");
            Console.Write("{0,13} {1,13} {2,13}", wins+losses, wins, losses);
            if (score < 0) Console.ForegroundColor = ConsoleColor.Red;
            else if (score > 0) Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0,18}",wins-losses);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nPlay again? (0 to leave/Any other input to keep playing): ");
            loop = Console.ReadLine() == "0" ? false : true;
          } while (loop);

          Console.WriteLine("\nThanks for playing. Bye!");

          Console.WriteLine("\n=========== Dorset College Random Number Guessing Game 2.0 ===========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }
    }
}
