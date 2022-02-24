/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

﻿﻿using System;

namespace Ex6_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Dorset College Square Area Calculator ===========\n");

            Square[] squares = new Square[10];
            for (int i=1; i<=squares.Length; i++) {
                squares[i-1] = new Square(i);
                Console.WriteLine($"A square of side-length {squares[i-1].SideLength} has an area of {squares[i-1].Area}.");
            }

            Console.WriteLine("\n=========== Dorset College Square Area Calculator ===========");

            Console.Write("\nPress \"Enter/Return\" to end... ");
            Console.ReadLine();
        }
    }

    class Square
    {
        public double Area { get; private set; }
        public double SideLength { get; }

        public Square(double sideLength) {
            SideLength = sideLength;
            computeArea(sideLength);
        }

        private void computeArea(double sideLength) {
            Area = sideLength * sideLength;
        }
    }
}
