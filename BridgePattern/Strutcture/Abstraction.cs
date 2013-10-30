namespace BridgePattern.Strutcture
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    internal class Abstraction
    {
        protected Implementor _Implementor;

        // Property
        public Implementor Implementor
        {
            set { _Implementor = value; }
        }

        public virtual void Operation()
        {
            _Implementor.Operation();
        }
    }
}