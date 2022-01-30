// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
//
// namespace CompoundExpressions
// {
//     class Program
//     {
//         //Lecture 17: Compound Expressions in If Statements
//         static void Main(string[] args)
//         {
//             //And is only true when both sides are true
//             //T && T = T
//             //T && F = F
//             //F && F = F
//             //F && T = F
//             //Or is only false when both sides are false
//             //T || T = T
//             //T || F = T
//             //F || T = T
//             //F || F = F
//
//             Console.WriteLine("Enter your age");
//             int age = int.Parse(Console.ReadLine());
//             Console.WriteLine("What is the moving rating");
//             char rating = char.Parse(Console.ReadLine());
//             if ((age <= 12 || age >= 65) && rating == 'G')
//             {
//                 Console.WriteLine("Discount applies");
//             }
//
//
//
//         }
//     }
// }
