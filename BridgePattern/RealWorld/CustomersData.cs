using System;
using System.Collections.Generic;

namespace BridgePattern.RealWorld
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    class CustomersData : IDataObject
    {
        private readonly List<string> _customers = new List<string>();
        private int _current = 0;

        public CustomersData()
        {
            // Loaded from a database
            _customers.Add("Jim Jones");
            _customers.Add("Samual Jackson");
            _customers.Add("Allen Good");
            _customers.Add("Ann Stills");
            _customers.Add("Lisa Giolani");
        }

        public void NextRecord()
        {
            if (_current <= _customers.Count - 1)
            {
                _current++;
            }
        }

        public void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        public void AddRecord(string customer)
        {
            _customers.Add(customer);
        }

        public void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }

        public void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }

        public void ShowAllRecords()
        {
            foreach (string customer in _customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }
}