using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading_Hafsa
{
    internal class MathOperations
    {
        public int Add(int a, int b)
        {
            //this add takes 2 integer parameters and returns their sum as an integer
            return a + b;
        }//int add

        public double Add(double a, double b)
        {
            //this add method takes 2 double parameters and returns their sum as a double
            return a + b;
        }//double add

        public double Add(double a, double b, double c)
        {
            //this add method takes 2 strings parameters and concatenates them
            return a + b + c;
        }//triple double add

        public int Mutliply(int a, int b)
        {
            //this multiply takes 2 integer parameters and returns their sum as an integer
            return a * b;
        }//int multiply

        public double Multiply(double a, double b)
        {
            //this multiply method takes 2 double parameters and returns their sum as a double
            return a * b;
        }//double multiply

        public double Multiply(double a, double b, double c)
        {
            //this multiply method takes 2 strings parameters and multiplies them
            return a * b * c;
        }//triple double multiply

        public int Subtract(int a, int b)
        {
            //this subtract takes 2 integer parameters and returns their sum as an integer
            return a - b;
        }//int subtract

        public double Subtract(double a, double b)
        {
            //this subtract method takes 2 double parameters and returns their sum as a double
            return a - b;
        }//double subtract

        public double Subtract(double a, double b, double c)
        {
            //this subtract method takes 2 strings parameters and subtracts them
            return a - b - c;
        }//triple double subtract

        public int Divide(int a, int b)
        {
            //this divide takes 2 integer parameters and returns their sum as an integer
            return a / b;
        }//int divide

        public double Divide(double a, double b)
        {
            //this divide method takes 2 double parameters and returns their sum as a double
            return a / b;

            if (b != 0)
            {

            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

        }//double divide


    }//class


}//namespace
