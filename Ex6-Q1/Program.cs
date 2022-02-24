using System;

namespace Ex6_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[10];
            for (int i=1; i<=squares.Length; i++) {
                squares[i-1] = new Square(i);
                System.Console.WriteLine(squares[i-1].SideLength);
                System.Console.WriteLine(squares[i-1].Area);
            }
        }
    }

    class Square
    {
        private double area, sideLength;

        public Square(double sideLength) {
            this.sideLength = sideLength;
            computeArea(sideLength);
        }

        private void computeArea(double sideLength) {
            this.area = sideLength * sideLength;
        }

        public double Area {
            get {
                return area;
            }
        }
        public double SideLength {
            get {
                return sideLength;
            }
        }
    }
}
