using System;

namespace PrototypePattern
{
    public class ComplicatedUnstableObject : ICloneable
    {

        // Internal constructors are used so that only inside the current API these constructors are exposed 
        // but when the API is released thees constructor are not accessible to the client 
        internal ComplicatedUnstableObject(string a, int b, char c, string d)
        {
            
        }

        internal ComplicatedUnstableObject(int a, int b, int c)
        {
            
        }

        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}