using PrestigeHost.Host;
using PrestigeHost.Models;
using System;
using System.Data.Entity;
using System.ServiceModel;

namespace PrestigeHost
{
    class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                using (PrestigeModels context = new PrestigeModels())
                {
                    Database.SetInitializer(new PrestigeInitialize());
                    context.Database.Initialize(true);
                    Console.WriteLine("Database created!");
                }
                PrestigeServices prestigeServices = new PrestigeServices();

                foreach (var item in prestigeServices.GetPosts())
                {
                    Console.WriteLine(item.Login +" "+ item.Password);
                }
                ServiceHost service = new ServiceHost(typeof(PrestigeServices));
                service.Open();
                Console.WriteLine("Service started!");
                Console.ReadKey();
                service.Close();
                Console.WriteLine("Service closed!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
