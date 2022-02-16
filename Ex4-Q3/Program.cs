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
using System.Text.RegularExpressions;

namespace Ex4_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] words = {
            "PROGRAMMING",
            "INHERITANCE",
            "POLYMORPHISM",
            "ENCAPSULATION",
            "ABSTRACTION",
            "FRAMEWORK",
            "NAMESPACE",
            "ALGORITHM"
          };
          Random randomGenerator = new Random();
          int randomNumber = randomGenerator.Next(words.Length);
          string answer = words[randomNumber], hidden = new String('*', answer.Length), lettersTried = new String('*', 26);
          int guessed = 0, left = answer.Length, attempts = 3;

          Console.WriteLine("=========== Dorset College Hangman Game ===========");

          // Reveals the answer for debugging
          // Console.WriteLine(answer);

          while (attempts > 0) {
            Console.WriteLine($"\nYour secret is:\n\n{hidden}");
            Console.WriteLine($"\nLetters guessed: {guessed}\nLetters left: {left}\nAttempts left: {attempts}");

            Console.Write("\nEnter a letter (or 0 for an all-or-nothing word guess): ");
            string guess = Console.ReadLine().ToUpper();

            while (!Regex.IsMatch(guess, @"^[A-Za-z0]$")) {
              Console.WriteLine($"\nInput must be only one letter (numbers and special characters are not accepted)! Please, try again.");
              Console.Write("\nEnter a letter (or 0 for an all-or-nothing word guess): ");
              guess = Console.ReadLine().ToUpper();
            }

            if (guess[0] == '0') {
              Console.Write("\nEnter the word: ");
              if (Console.ReadLine().ToUpper() == answer) {
                Console.WriteLine("\nAWESOME!!!");
                Console.WriteLine($"The secret is: {answer}");
                Console.Write($"\nIf you would like to know more about {answer}, visit: ");
                switch (answer) {
                  case "PROGRAMMING":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Computer_programming.");
                    break;
                  case "INHERITANCE":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Inheritance_(object-oriented_programming).");
                    break;
                  case "POLYMORPHISM":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Polymorphism_(computer_science).");
                    break;
                  case "ENCAPSULATION":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Encapsulation_(computer_programming).");
                    break;
                  case "ABSTRACTION":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Abstraction_(computer_science).");
                    break;
                  case "FRAMEWORK":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Software_framework.");
                    break;
                  case "NAMESPACE":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Namespace.");
                    break;
                  case "ALGORITHM":
                    Console.WriteLine("https://en.wikipedia.org/wiki/Algorithm.");
                    break;
                }
              } else {
                Console.WriteLine("\nWRONG!!!");
                Console.WriteLine("It seems that you have guessed it wrong. Better luck next time!");
              }
              Console.WriteLine("\nThanks for playing. Bye!");
              Console.Write("\nPress \"Enter/Return\" to end... ");
              Console.ReadLine();
              return;
            }

            if (lettersTried.Contains(guess)) {
              Console.WriteLine("\nYou have already tried this letter! Try another one.");
            } else {
              lettersTried = lettersTried.Remove((int)guess[0]-65, 1).Insert((int)guess[0]-65, guess.ToString());
              if (answer.Contains(guess)) {
                Console.WriteLine("\nSPOT ON!!!\nYou've found a correct letter.");
                for (int i=0; i<answer.Length; i++) {
                  if (guess[0] == answer[i]) {
                    hidden = hidden.Remove(i, 1).Insert(i, guess.ToString());
                    guessed++;
                    left--;
                    if (left == 0) {
                      Console.WriteLine("\nCONGRATULATIONS!!!");
                      Console.WriteLine($"You have found all the letters. Your revealed secret is: {hidden}");
                      Console.Write($"\nIf you would like to know more about {answer}, visit: ");
                      switch (answer) {
                        case "PROGRAMMING":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Computer_programming.");
                          break;
                        case "INHERITANCE":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Inheritance_(object-oriented_programming).");
                          break;
                        case "POLYMORPHISM":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Polymorphism_(computer_science).");
                          break;
                        case "ENCAPSULATION":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Encapsulation_(computer_programming).");
                          break;
                        case "ABSTRACTION":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Abstraction_(computer_science).");
                          break;
                        case "FRAMEWORK":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Software_framework.");
                          break;
                        case "NAMESPACE":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Namespace.");
                          break;
                        case "ALGORITHM":
                          Console.WriteLine("https://en.wikipedia.org/wiki/Algorithm.");
                          break;
                      }
                      Console.WriteLine("\nThanks for playing. Bye!");
                      Console.Write("\nPress \"Enter/Return\" to end... ");
                      Console.ReadLine();
                      return;
                    }
                  }
                }
              } else {
                Console.WriteLine("\nThe secret does not contain this letter! Try another one.");
                attempts--;
              }
            }
          }

          Console.WriteLine("\nOh no!? It seems that you have run out of attempts. Better luck next time!");
          Console.WriteLine("\nThanks for playing. Bye!");

          Console.WriteLine("\n=========== Dorset College Hangman Game ===========");

          Console.Write("\nPress \"Enter/Return\" to end... ");
          Console.ReadLine();
        }
    }
}
