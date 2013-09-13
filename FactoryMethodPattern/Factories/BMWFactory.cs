using DesignPattern.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factories
{
    public class BMWFactory : IAutoFactory
    {
        //See here there is no need of calling the method SetName as the object mandates a name to be passed.
        public DesignPattern.IAuto CreateAutomobile()
        {
            return new BMW335Xi("Sachin BMW");
        }
    }
}
