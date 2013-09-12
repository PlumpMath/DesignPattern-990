using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DesignPattern
{
    public class Autofactory
    {

        Dictionary<string, Type> autos;

        public Autofactory()
        {
            LoadTypesICanReturn();
        }

        public IAuto CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);

            if (t == null)
                return new NullAuto();

            return Activator.CreateInstance(t) as IAuto;
            
        }

        private Type GetTypeToCreate(string carName)
        {
            foreach (var auto in autos)
            {
                if (auto.Key.Contains(carName))
                    return autos[auto.Key];
            }
            return null;            
        }

        private void LoadTypesICanReturn()
        {
            autos = new Dictionary<string, Type>();
            var types  = Assembly.GetExecutingAssembly().GetTypes().ToList();
            types.ForEach(AddMatchedInterfaceToDictionary);
        }

        private void AddMatchedInterfaceToDictionary(Type anyTypeInAssembly)
        {
            if (anyTypeInAssembly.GetInterface(typeof(IAuto).ToString()) != null)
                autos.Add(anyTypeInAssembly.Name.ToLower(), anyTypeInAssembly);
        }
    }
}
