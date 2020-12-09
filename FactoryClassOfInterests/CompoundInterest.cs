/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// A 'CompoundIneterest' class
/// </summary>
namespace FactoryClassOfInterests
{
    class CompoundInterest:IfactoryInterest
    {
        public double Interest(double amount, int years, float roi, int annualCompound)
        {
            double result = 0;
            result = amount * Math.Pow((1 + (roi / annualCompound)), (annualCompound * years));

            return result;
        }
    }
}
