using System;

namespace Day_13_Usecases_Generics
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UseCase 1 Find Max Int  Number");

            int intOutput = MaxNumberCheck.MaxNumbermethod_Int(11, 22, 33);
            Console.Write(intOutput);

        }
    }
}
