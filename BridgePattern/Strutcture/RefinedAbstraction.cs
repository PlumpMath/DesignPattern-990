namespace BridgePattern.Strutcture
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    internal class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            _Implementor.Operation();
        }
    }
}