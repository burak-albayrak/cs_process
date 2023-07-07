using System;

namespace _1_Variables
{
    class Program
    {
        static void Main(String[] args)
        {
            // Value Types
            int number1 = 1013123;                                          // Up to 2147483647
            Console.WriteLine("number1 is: {0}", number1);
            
            long number2 = 234723948234;                                    // Up to 9223372036854775807
            Console.WriteLine("wow! that's a huge number: {0}",number2);
            
            short number3 = 223;                                            // Up to 32767
            Console.WriteLine("little thing :( :{0}", number3);
            
            byte number4 = 21;                                              // Up to 255
            Console.WriteLine("Poor you :(((: {0}",number4);
            
            bool condition = true;
            Console.WriteLine("Is it true? {0}",condition);
            
            char character = 'A';
            Console.WriteLine("Character is: {0}",character);
            
            double number5 = 123.5;
            Console.WriteLine("That's a float!!!!: {0}", number5);
            
            decimal number6 = 123.5m;
            Console.WriteLine("WTF is m?: {0}", number6);

            string day = "monday";
            Console.WriteLine("Today is: {0}", day);

            var number7 = 10;
            number7 = 'A';
            Console.WriteLine(number7);
            
            Console.WriteLine(Days.Thursday);
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}

