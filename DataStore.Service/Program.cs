using DataStore.Resolver;
using System;

namespace DataStore.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            DataResolver.RegisterResolver();

            var operations = DataResolver.GetInstance<Operations>(); 

            operations.Write("Welcome to Resolver");

            Console.Read();
        }
    }
}
