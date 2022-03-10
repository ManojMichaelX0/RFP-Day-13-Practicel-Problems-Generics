using System;

namespace Day_13_Usecases_Generics
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("UseCase 1 Find Max Int  Number");

            //int intOutput = MaxNumberCheck.MaxNumbermethod_Int(11, 22, 33);
            //Console.Write(intOutput);

            Console.WriteLine("UseCase 2 Find Max Double  Number");

            double doubleOutput = MaxNumberCheck_Double.MaxNumbermethod_Double(112.3, 22.23, 33.6);
            Console.Write(doubleOutput);

        }
    }
}
