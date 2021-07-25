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
            System.Console.WriteLine($"The result1 is = {result}");
            IntegerTransformer myInteger2 = new IntegerTransformer(2);
            double result2 = myInteger2.Litres();
            System.Console.WriteLine($"The result2 is = {result2}");
            IntegerTransformer myInteger3 = new IntegerTransformer(30, 7);
            int result3 = myInteger3.TwiceAsOld();
            System.Console.WriteLine($"The result3 is = {result3}");
            LogicHandler myString = new LogicHandler("Daniel", "Daniel");
            string result4 = myString.Greet();
            System.Console.WriteLine($"The result4 is = {result4}");
            LogicHandler myLetter = new LogicHandler(4, 4);
            int result5 = myLetter.AreaOfPerimeter();
            System.Console.WriteLine($"The result5 is = {result5}");
            LogicHandler myYear = new LogicHandler();
            int[] result6 = myYear.humanYearsCatYearsDogYears(1);
            foreach (var item in result6)
            {
                System.Console.WriteLine(item);
            }


        }
    }
}
