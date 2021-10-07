using Layers.Business;
using Layers.Core.Attributes;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityManager entityManager = new EntityManager();
            foreach (var method in typeof(EntityManager).GetMethods())
            {
                foreach (var attr in method.GetCustomAttributes(false))
                {
                    if (method.Name=="ReturnName")
                    {
                            SurnameAttribute surnameAttribute=(SurnameAttribute)attr;
                            surnameAttribute.ReturnSurname();//Attribute
                            entityManager.ReturnName();//Methodun kendisi
                    }
                }
            }
        }
    }
}
/*Burada öncelikle ilgili methodun attribute'u çalıştırılmıştır.
 * Devamında methodun kendisi çalıştırılmıştır.*/