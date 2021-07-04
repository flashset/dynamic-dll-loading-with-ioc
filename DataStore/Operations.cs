using Unity;

namespace DataStore
{
    public class Operations: IOperations
    {
        private IOperations _operations;
        public Operations(IOperations operations)
        {
            _operations = operations;
        }

        public void Register(IUnityContainer container)
        {
            container.RegisterType<IOperations, Operations>();
        }

        public bool Write(string data)
        {
            return _operations.Write(data);
        }

        public string Read()
        {
            return _operations.Read();
        }
        public bool Delete()
        {
            return _operations.Delete();
        } 
    }
}
