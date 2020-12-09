/* 
 COPY RIGHT @AUGMENTO LABS 2020
Created By Vinayak
*/
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// A 'Abstact Interest and Concrete Interest' class
/// </summary>
namespace FactoryClassOfInterests
{
    public abstract class AbstractIntrest
    {
        public abstract IfactoryInterest GetIntrest(string Intrest);
    }

    public class ConcreteIntrestFactory : AbstractIntrest
    {
        public override IfactoryInterest GetIntrest(string Intrest)
        {
            switch (Intrest)
            {
                case "SimpleIntrest":
                    return new SimpleInterest();
                case "CompoundIntrest":
                    return new CompoundInterest();
                default:
                    throw new ApplicationException(string.Format("Intrest '{0}' cannot be created", Intrest));
            }
        }

    }
}
