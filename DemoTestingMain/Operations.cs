using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTestingMain
{
   public class Operations
    {
        int a, b, result;

        //Addition
        public int add(int a, int b)
        {
            return  a + b;
        }

        //Substraction
        public int sub(int a, int b)
        {
            return a - b;
        }

        //Multiplication
        public int mul(int a, int b)
        {
            return a * b;
        }

        //Division
        public int div(int a, int b)
        {
            return a / b;
        }

        //Modulo
        public int mod(int a, int b)
        {
            return a % b;
        }
    }
}
