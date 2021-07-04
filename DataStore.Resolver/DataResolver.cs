using System;
using System.Collections.Generic;
using System.Composition;
using System.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using Unity;

namespace DataStore.Resolver
{
    public  class DataResolver
    {    
        static IUnityContainer container;
        public static void RegisterResolver()
        {
            // container instance
            container = new UnityContainer(); 
             
            var path = @"E:\Personal\SparkyFlash\github\public\dynamic-dll-loading-with-ioc\dynamic-code";

            //var path = @"E:\Examples\SparkyFlash\dynamic-dll-loading-with-ioc\dynamic-code";

            var assemblies = Directory
                         .GetFiles(path, "*.dll")
                         .Select(Assembly.LoadFrom)
                         .ToList();

            var configuration = new ContainerConfiguration().WithAssemblies(assemblies); 

            using (var c = configuration.CreateContainer())
            {
                IEnumerable<IOperations> Operations = c.GetExports<IOperations>();

                if (Operations != null && Operations.Any())
                {
                    foreach (var r in Operations)
                    {
                        r.Register(container);
                    }
                }
                else
                {
                    Console.WriteLine("Assembiles are not exported as IOperations");
                }
            }            
        }

        public static T GetInstance<T>()
        {
            return container.Resolve<T>();
        }
    }
}
