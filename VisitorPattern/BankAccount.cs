using System;

namespace VisitorPattern
{
    public class BankAccount :  IAsset
    {
        public int Amount { get; set; }
        public double MonthlyInterest { get; set; }

        #region IAsset Members

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion
    }
}