using DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    public interface IAutoFactory
    {
        IAuto CreateAutomobile();
    }
}
