using Layers.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Business
{
    public class EntityManager
    {
        [SurnameAttribute]
        public void ReturnName()
        {
            Console.WriteLine("OKTAY");
        }
    }
}
