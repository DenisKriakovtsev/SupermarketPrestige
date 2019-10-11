using PrestigeHost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrestigeHost.Host
{
    [ServiceContract]
    public interface IPrestigeServices
    {
        [OperationContract]
        bool Autorizations(string Login, string Password, string type_post);
        [OperationContract]
        List<ProductProxy> ShowAllProduct();
        [OperationContract]
        List<CategoriesProxy> GetCategories(); 
        [OperationContract]
        List<ManufacturersProxy> GetManufacturers();
        [OperationContract]
        List<ChecksProxy> GetChecks();
        [OperationContract]
        List<PostsProxy> GetPosts();
        [OperationContract]
        List<ClientsProxy> GetClients();
        [OperationContract]
        List<CashiersProxy> GetCashiers();
        [OperationContract]
        List<AdminsProxy> GetAdmins();
        [OperationContract]
        List<WarehouseWorkersProxy> GetWarehouseWorkers();       
        [OperationContract]
        string DeleteCashiers(int id_cashiers);
        [OperationContract]
        string DeleteProduct(int id_product);
        [OperationContract] 
        string DeleteWarehouseWork(int id_wareWork);
        [OperationContract]
        string AddCashiers(Posts post, Cashiers cashiers);
        [OperationContract]
        string AddWarehouseWorkers(Posts post, WarehouseWorkers wareWorks);
        [OperationContract]
        void AddClients(Clients clients);
        [OperationContract]
        void AddToChecks(Checks checks);
        [OperationContract]
        string AddProducts(Products products);
    }
}
