using DataStore;
using System;
using System.Composition;
using Unity;

namespace DBStore
{
    [Export(typeof(IOperations))]
    public class DBOperations : IOperations
    {        
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IOperations, DBOperations>();
        }

        public bool Write(string data)
        {
            Console.WriteLine("DBOperations:Write:" + data);
            return true;
        }

        public string Read()
        {
            Console.WriteLine("DBOperations:Read");
            return string.Empty;
        }

        public bool Delete()
        {
            Console.WriteLine("DBOperations:Delete");
            return true;
        }
    }
}
