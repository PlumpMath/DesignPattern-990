using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public class Person: IAsset
    {
        public List<IAsset> Assets = new List<IAsset>();

       
        #region IAsset Members

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in Assets)
            {
                asset.Accept(visitor);
            }
        }

        #endregion
    }
}
