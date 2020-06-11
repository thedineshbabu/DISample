using System;
using Microsoft.Extensions.DependencyInjection;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddScoped<IDataAccess, DataAccess>();
            collection.AddScoped<IBusiness, Business>();
            // collection.AddScoped<IUserInterface, UserInterface>();

            var provider = collection.BuildServiceProvider();

            // IDataAccess dal = provider.GetService<IDataAccess>();
            IBusiness bal = provider.GetService<IBusiness>();

            var ui = new UserInterface(bal);
            ui.GetData();

            Console.WriteLine("Hello World!");
        }
    }
}
