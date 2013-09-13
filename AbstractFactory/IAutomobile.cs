using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public interface IAutomobile
    {
        string Name { get; }
        void SetName(string name);
        void TurnOn();
        void TurnOff();
    }
}
