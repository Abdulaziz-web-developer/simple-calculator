namespace PracticeOOP.Classes
{
    public class LogicHandler
    {
        private string name;
        private string owner;
        private int humanYears;
        private int catYears;
        private int dogYears;
        private int l;
        private int w;
        private int v;

        public LogicHandler(){}


        /*

Create a function that gives a personalized greeting.
This function takes two parameters: name and owner.
Use conditionals to return the proper message:

case	            return
name equals owner	'Hello boss'
otherwise	        'Hello guest'

*/


        public LogicHandler(string str1, string str2)
        {
            name = str1;
            owner = str2; 
        }
        public string Greet()
        {
            if (name == owner)
            {
                return "Hello boss";
            }
            else
            {
                return "Hello guest";
            }
        }

        /*
        I have a cat and a dog.
        I got them at the same time as kitten/puppy. That was humanYears years ago.
        Return their respective ages now as [humanYears,catYears,dogYears]
        NOTES:
        humanYears >= 1
        humanYears are whole numbers only
        Cat Years
        15 cat years for first year
        +9 cat years for second year
        +4 cat years for each year after that
        Dog Years
        15 dog years for first year
        +9 dog years for second year
        +5 dog years for each year after that
        */

        public int[] humanYearsCatYearsDogYears(int age1)
        {
             humanYears = age1;
            catYears = 15;
            dogYears = 15;
            if(humanYears >= 2)
             {
                catYears += 9 + (humanYears - 2) * 4;
                dogYears += 9 + (humanYears - 2) * 5;

                
            }
            int[] ages = {humanYears, catYears, dogYears};
            return ages;
        } 
        public LogicHandler(int let1, int let2)
        {
            l = let1;
            w = let2;
        }

        public LogicHandler(int v)
        {
            this.v = v;
        }

        public int AreaOfPerimeter()
        {
            if(l==w)
            {
                return l*w;
            }
                return 2*(l+w);
            }
       
    }
}