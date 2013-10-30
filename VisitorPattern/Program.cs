using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.Assets.Add(new BankAccount {Amount = 1000, MonthlyInterest = 0.01});
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            var netWorthVisitor = new NetWorthVisitor();
            person.Accept(netWorthVisitor);

            Console.WriteLine(netWorthVisitor.Total);
            Console.ReadKey();
        }
    }


    public interface IVisitor
    {
        void Visit(RealEstate realEstate);
        void Visit(BankAccount bankAccount);
        void Visit(Loan loan);
    }

    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }


    public class MonthlyIncomeVisitor : IVisitor
    {
        public double Amount;

        #region IVisitor Members

        public void Visit(RealEstate realEstate)
        {
            throw new NotImplementedException();
        }

        public void Visit(BankAccount bankAccount)
        {
            throw new NotImplementedException();
        }

        public void Visit(Loan loan)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class NetWorthVisitor : IVisitor
    {
        public int Total { get; set; }

        #region IVisitor Members

        public void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        public void Visit(Loan loan)
        {
            Total -= loan.Owed;
        }

        #endregion
    }


}
