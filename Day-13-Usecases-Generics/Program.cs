using System;

namespace Day_13_Usecases_Generics
{
    internal class Day_13_uc_Generics
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UseCase 3 Find Max String  Number");

            string stringOutput = MxNumbercheck_String.MaxNumbermethod_String("11","22","44");
            Console.Write(stringOutput);

        }
    }
}
