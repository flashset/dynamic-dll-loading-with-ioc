using DataStore;
using System;
using System.Composition;
using Unity;

namespace FileStore
{
    [Export(typeof(IOperations))]
    public class FileOperations : IOperations
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IOperations, FileOperations>();
        }

        public bool Write(string data)
        {
            Console.WriteLine("FileOperations:Write:" + data);
            return true;
        } 
        public string Read()
        {
            Console.WriteLine("FileOperations:Read");
            return string.Empty;
        }
        public bool Delete()
        {
            Console.WriteLine("FileOperations:Delete");
            return true;
        }
    }
}
