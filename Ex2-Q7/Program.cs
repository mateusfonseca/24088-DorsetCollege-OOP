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

namespace Ex2_Q7
{
    class Program
    {
        static void Main(string[] args)
        {
          Random randomGenerator = new Random();
          int randomNumber = 0, guess = 0, wins = 0, losses = 0;
          bool loop = false;

          Console.WriteLine("=========== Dorset College Random Number Guessing Game ===========");

          do {
            randomNumber = randomGenerator.Next(1,11);

            Console.WriteLine();
            for (int i=0; i<5; i++) {
              do {
                try {
                  Console.Write("Enter your guess (1 to 10): ");
                  guess = int.Parse(Console.ReadLine());
                  if (guess > 0 && guess < 11) {
                    loop = false;
                  } else {
                    Console.WriteLine("\nThe minimum value is 1 and the maximum is 10! Please, try again.\n");
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
                Console.WriteLine("\nSPOT ON!!!\nCongratulations, you have guessed it rigth!\n");
                wins++;
                break;
              }

              if (i == 4) {
                Console.WriteLine("It looks like you have run out of guesses. Better luck next time!\n");
                losses++;
              }
            }

            Console.WriteLine("========================== Score Sheet ===========================\n");
            Console.WriteLine("{0,13} {1,13} {2,13} {3,17}", "Attempts", "Wins", "Losses", "Final Score");
            Console.WriteLine("{0,13} {1,13} {2,13} {3,17}", wins+losses, wins, losses, wins-losses);
            Console.Write("\nPlay again? (0 to leave/Any other input to keep playing): ");
            loop = Console.ReadLine() == "0" ? false : true;
          } while (loop);

          Console.WriteLine("\nThanks for playing. Bye!");

          Console.WriteLine("\n=========== Dorset College Random Number Guessing Game ===========");

          Console.Write("\nPress any key to end... ");
          Console.ReadLine();
        }
    }
}
