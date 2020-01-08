using System;
using MathOperations;

namespace Calculator
{
    public class Calc
    {
        //private int result = 0;

        public int Add(int a, int b)
        {

            return Addition.Add(a, b);

            //return result;
        }

        public  int Divide(int a, int b)
        {

            return Division.Div(a, b);

            //return result;
        }

        public  double Multiply(double a, double b)
        {

            return Multiplication.Multi(a, b);

            //return result;
        }

        public  int Subtractions(int a, int b)
        {

            return Subtraction.Sub(a, b);

            //return result;
        }

        public  double SquareRt(double a)
        {

            return SquareRoot.SqrRoot(a);

            //return result;
        }

        public int Sqr(int a)
        {

            return Square.Sqr(a);

            //return result;
        }

        public  int Cbe(int a)
        {

            return Cube.CubeRoot(a);

            //return result;
        }


    }
}
