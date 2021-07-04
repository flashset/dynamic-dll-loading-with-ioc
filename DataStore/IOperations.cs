using Unity;

namespace DataStore
{
    public interface IOperations
    {
        void Register(IUnityContainer container);

        bool Write(string data);

        string Read();

        bool Delete(); 

    }
}
