using DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory;

namespace FactoryMethodPattern
{
    public interface IAutoFactory
    {
        IAutomobile CreateSportsCar();
        IAutomobile CreateLuxuryCar();
        IAutomobile CreateEconomyCar();
    }
}
