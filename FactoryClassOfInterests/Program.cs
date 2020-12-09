/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;

namespace FactoryClassOfInterests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Choose which Intrest to Calculate----");
            Console.WriteLine("i)SimpleIntrest-->1");
            Console.WriteLine("ii)CompoundIntrest-->2");
            
            ConcreteIntrestFactory CalculateSi = new ConcreteIntrestFactory();

            var selection = int.Parse(Console.ReadLine());
            if (selection == 1) 
            {
                int years;
                float rateOfIntrest;
                double amount;

                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                rateOfIntrest = float.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                IfactoryInterest SimpleIntrest = CalculateSi.GetIntrest("SimpleIntrest");
                var Result = SimpleIntrest.Interest(amount, years,rateOfIntrest);
                Console.Write("Simple Intrest is "+Result);
            }
           else if(selection == 2)
            {
                int years;
                int annualCompound;

                float rateOfIntrest;
                double amount;

                Console.WriteLine("Enter principal Amount:");
                amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the rate of interest : ");
                rateOfIntrest = float.Parse(Console.ReadLine()) / 100;

                Console.Write("Enter the total number of years : ");
                years = int.Parse(Console.ReadLine());

                Console.Write("Compounding frequency quarterly or monthly : ");
                annualCompound = int.Parse(Console.ReadLine());

                IfactoryInterest CalculateCi= CalculateSi.GetIntrest("CompoundIntrest");
            var Result = CalculateCi.Interest(amount, years, rateOfIntrest, annualCompound);
                Console.Write("After " + years + " years there will be a " + Result + " in the Account");

            }
            Console.ReadKey();
        }
    }
}
