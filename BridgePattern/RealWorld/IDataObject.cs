namespace BridgePattern.RealWorld
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    interface IDataObject
    {
        void NextRecord();
        void PriorRecord();
        void AddRecord(string name);
        void DeleteRecord(string name);
        void ShowRecord();
        void ShowAllRecords();
    }
}