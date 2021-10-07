using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class SurnameAttribute:Attribute
    {

        public void  ReturnSurname()
        {
            Console.WriteLine("EKINAY");
        }
    }
}
