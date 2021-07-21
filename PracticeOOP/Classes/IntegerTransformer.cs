using System;

namespace PracticeOOP.Classes
{
    public class IntegerTransformer
    {
        private int number;
        private int a;
        private int b;
        private double time;
        private int dadYears;
        private int sonYears;


        //Constructors

        public IntegerTransformer(int num1 , int num2 , int num3)
        {
             number = num1;
             a = num2;
             b = num3;
        }

        /*
        Your task is to create functionisDivideBy (or is_divide_by) to check 
        if an integer number is divisible by each out of two arguments.
        */
         public bool IsDivideBy()
         {
             return number % a == 0 && number % b == 0;
         }

         /*
         Nathan loves cycling.
         Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
         You get given the time in hours and you need to return the number of litres Nathan will drink, rounded to the smallest value.
         For example:
         time = 3 ----> litres = 1
         time = 6.7---> litres = 3
         time = 11.8--> litres = 5
         */
        public IntegerTransformer(int num4)
        {
             time = num4;
        }
          public int Litres()
         {
            return (int)(time/2);
         }
         /*
        Your function takes two arguments:
        1 current father's age (years)
        2 current age of his son (years)
        Сalculate how many years ago the father was twice as old
        as his son (or in how many years he will be twice as old).
         */
        public IntegerTransformer(int num5, int num6)
        {
            dadYears = num5;
            sonYears = num6;
        }
         public int TwiceAsOld()
         {
               return Math.Abs(dadYears - 2 * sonYears);
         }


    }
}