using DesignPattern.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factories
{
    public class MiniCooperFactory : IAutoFactory
    {
        public DesignPattern.IAuto CreateAutomobile()
        {
            var miniCooper = new MiniCooper334Xl();
            //The setname call below specifies an operations that needs to be called to setup this class properly 
            //Here the creation is not known by the client who needs the object but is at one place in the factory
            miniCooper.SetName("Mini Cooper S");
            return miniCooper;

        }
    }
}
