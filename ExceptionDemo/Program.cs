using System;

namespace ExceptionDemo
{
    class Program
    {
        public void NullRefException()
        {
            try
            {
                string name = null;
                int len = name.Length;
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+"Name having empty");
            }

        }


        public void Arithmeticexception()
        {
            try
            {
                int a = 10;
                int b = 0;
                int res = a / b;
            }

            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message+ "Its Divide by zero exception");

            }

            catch (Exception ae)
            {
                Console.WriteLine(ae.Message+ "Its other than divide by zero exception");

            }
        }






        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program pg = new Program();

            pg.NullRefException();
            pg.Arithmeticexception();

       }
    }
}
