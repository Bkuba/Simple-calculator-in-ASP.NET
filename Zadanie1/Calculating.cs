using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadanie1
{
    public class Calculating
    {
        public int Num1;
        public int Num2;
        public int Num3;

        public int Addition(int a, int b)
        {
            this.Num1 = a;
            this.Num2 = b;
            return a + b;
        }
        public int AdditionPlus(int a, int b, int c)
        {
            this.Num1 = a;
            this.Num2 = b;
            this.Num3 = c;
            int wynik = a + b + c;
            return wynik;
        }
        public int Subtraction(int a, int b)
        {
            this.Num1 = a;
            this.Num2 = b;
            int wynik = a - b;
            return wynik;
        }
        public int SubtractionPlus(int a, int b, int c)
        {
            this.Num1 = a;
            this.Num2 = b;
            this.Num3 = c;
            int wynik = a - b - c;
            return wynik;
        }
        public int Multiplication(int a, int b)
        {
            this.Num1 = a;
            this.Num2 = b;
            int wynik = a * b;
            return wynik;
        }
        public int MultiplicationPlus(int a, int b, int c)
        {
            this.Num1 = a;
            this.Num2 = b;
            this.Num3 = c;
            int wynik = a * b * c;
            return wynik;
        }
        public int Division(int a, int b)
        {
            this.Num1 = a;
            this.Num2 = b;
            int wynik = a / b;
            return wynik;
        }
        public int DivisionPlus(int a, int b, int c)
        {
            this.Num1 = a;
            this.Num2 = b;
            this.Num3 = c;
            int wynik = (a / b) / c;
            return wynik;
        }


    }
}