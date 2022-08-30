using System;
using System.ComponentModel;

namespace MethodsEX3foriteration_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //1. Done
            PrintThousand();
            //2.Done
            PrintThreeTillNineNineNine();
            //3.Done
            Console.WriteLine("give me 2 numbers and see if they are equal or not");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            EqualOrNot(a,b);
            Console.WriteLine(EqualOrNot(a,b));
            //4.Done
            Console.WriteLine("give me a number to tell you if it's even or odd");
            var number = int.Parse(Console.ReadLine());
            EvenOrOdd(number);
            //5.Done
            Console.WriteLine("give me a number and ill tell you if its pos or neg");
            var num1 = int.Parse(Console.ReadLine());
            PosOrNeg(num1);

            //6.Done
            Console.WriteLine("are you of voting age?");
            var num2 = int.Parse(Console.ReadLine());
            AgeOfCandidate(num2);

            // heating up

            //1 Done
            Console.WriteLine("give me a number and i will tell you if its " +
                "in a -10 to 10 range");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(NegTenOrPosTen(num3));


            //2.
            Console.WriteLine("12 times table");
            MultiTable();
            //is this what was wanted?
                







        }
        /*Write a method that will print to
        the console all numbers 1000 through -1000.*/
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)   
            {
                Console.WriteLine(i);
            }
        }
        /*Write a method that will print to the console numbers
            3 through 999 by 3 each time.*/
        public static void PrintThreeTillNineNineNine()
        {
            for (int x = 3; x <=999; x +=3)
            {
                Console.WriteLine(x);
            }


        }
        /*Write a method to accept two integers as parameters
            and check whether they are equal or not*/
        public static bool EqualOrNot (int a, int b)
        {
            

            if (a == b)
            {
               return true;
            }
            else
            {
                return false;
            }


        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd (int number)
        {
            if (number % 2==0)
            {

                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }


        }
        //Write a method to check whether a given number is positive or negative.
        public static void PosOrNeg (int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine("pos");
            }

            else 
            {
                Console.WriteLine("Neg");

            }




        }
        /*Write a method to read the age of a candidate and determine whether they can vote. 
            Hint: use Parse()... or the safer TryParse() for an extra challenge!!*/
        public static void AgeOfCandidate(int num2)
        {
            if (num2 < 18)
            {
                Console.WriteLine("sorry you are not of voting age kid");
            }

            if (num2 > 18)
            {
                Console.WriteLine("you can vote!");
            }






        }
        /*heating up
        Write a method to check if an integer 
        (from the user) is in the range -10 to 10.*/
        public static bool NegTenOrPosTen(int num3)
        {
            if (num3 <= 10 && num3 >= -10)
            {
                return true;

            }
            
            
                return false ;
            
        }

        /*Write a method to display a given integer's 
        * multiplication table(from 1 to 12).*/

        public static void MultiTable()
        {
            for (int q = 12; q <= 144; q+=12)
            {
                Console.WriteLine(q);
            }
        }
        
    }









        
}
