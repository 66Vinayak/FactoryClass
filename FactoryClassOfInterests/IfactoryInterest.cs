/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// The 'Interest' interface
/// </summary>
namespace FactoryClassOfInterests
{
    public interface IfactoryInterest
    {
        double Interest(double amount, int years, float roi, int annualCompound=0 );
    }
}
