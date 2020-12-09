/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// A 'SimpleInterest' class
/// </summary>
namespace FactoryClassOfInterests
{
    class SimpleInterest:IfactoryInterest
    {
        public double Interest(double amount, int years, float roi, int annualCompound = 0) 
        {
            double result = 0;
            result = amount * roi * years;
            return result;
        }
    }
}
