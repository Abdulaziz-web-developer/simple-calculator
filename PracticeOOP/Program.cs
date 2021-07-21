using System;
using PracticeOOP.Classes;

namespace PracticeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerTransformer myInteger = new IntegerTransformer(15, -5, 3);
            bool result = myInteger.IsDivideBy();
            System.Console.WriteLine(result);
            IntegerTransformer myInteger2 = new IntegerTransformer(2);
            double result2 = myInteger2.Litres();
            System.Console.WriteLine(result2);
            IntegerTransformer myInteger3 = new IntegerTransformer(30, 7);
            int result3 = myInteger3.TwiceAsOld();
            System.Console.WriteLine(result3);


        }
    }
}
