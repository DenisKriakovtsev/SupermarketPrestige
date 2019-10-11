using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PrestigeHost.Models;

namespace PrestigeHost.Host
{
    public class PrestigeServices : IPrestigeServices
    {
        PrestigeModels context = new PrestigeModels();

        public bool Autorizations(string Login, string Password, string type_post)
        {
            foreach (var item in context.Posts)
            {
                if (item.Login == Login && item.Password == Password && item.TypePost == type_post)
                {
                    return true;
                }
            }
            return false;
        }

        public string AddProducts(Products products)
        {
            context.Products.Add(products);
            context.SaveChanges();
            return "Товар добавлен!";
        }

        public string AddCashiers(Posts post, Cashiers cashiers)
        {
            if (!context.Posts.Any(p => p.Login == post.Login))
            {
                context.Posts.Add(post);
                context.SaveChanges();
                cashiers.id_post = context.Posts.ToList().Last().id; //связка табл
                context.Cashiers.Add(cashiers);
                context.SaveChanges();
                return "Кассир добавлен!";
            }
            return "Такой кассир уже существует!";
        }
        public void AddClients(Clients clients)
        {
            context.Clients.Add(clients);
            context.SaveChanges();
        }
        public void AddToChecks(Checks checks)
        {
            checks.id_client = context.Clients.ToList().Last().id;
            context.Checks.Add(checks);
            context.SaveChanges();
        }
        public string AddWarehouseWorkers(Posts post, WarehouseWorkers wareWorks)
        {
            if (!context.Posts.Any(p => p.Login == post.Login))
            {
                context.Posts.Add(post);
                context.SaveChanges();
                wareWorks.id_post = context.Posts.ToList().Last().id; //связка табл
                context.WarehouseWorkers.Add(wareWorks);
                context.SaveChanges();
                return "Кассир добавлен!";
            }
            return "Такой рабтник склада уже существует!";
        }

        public string DeleteCashiers(int id_cashiers)
        {
            if (context.Cashiers.Any(p => p.id == id_cashiers))
            {
                int id_post = context.Cashiers.First(p => p.id == id_cashiers).id_post;

                context.Cashiers.Remove(context.Cashiers.First(p => p.id == id_cashiers));
                context.Posts.Remove(context.Posts.First(p => p.id == id_post));

                foreach (var item in context.Checks.Where(p => p.id_cashier == id_cashiers))
                {
                    context.Checks.Remove(item);
                }
                context.SaveChanges();
                return "Удалено!";
            }
            return "Не найдено кассира!";
        }

        public string DeleteWarehouseWork(int id_wareWork)
        {
            if (context.WarehouseWorkers.Any(p => p.id == id_wareWork))
            {
                int id_post = context.WarehouseWorkers.First(p => p.id == id_wareWork).id_post;

                context.WarehouseWorkers.Remove(context.WarehouseWorkers.First(p => p.id == id_wareWork));
                context.Posts.Remove(context.Posts.First(p => p.id == id_post)); 
                context.SaveChanges();
                return "Удалено!";
            }
            return "Не найдено работника склада!";
        }

        public string DeleteProduct(int id_product)
        {
            if (context.Products.Any(p => p.id == id_product))
            {
                context.Products.Remove(context.Products.First(p => p.id == id_product));
                foreach (var item in context.Checks.Where(p => p.id_product == id_product))
                {
                    context.Checks.Remove(item);
                }              
                context.SaveChanges();
                return "Удалено!";
            }
            return "Не найдено выбранный товар!";
        }
        public List<AdminsProxy> GetAdmins()
        {
            List<AdminsProxy> admins = new List<AdminsProxy>();

            foreach (Admins item in context.Admins)
            {
                admins.Add(new AdminsProxy
                {
                    id = item.id,
                    Surname = item.Surname,
                    Name = item.Name,
                    id_post = item.id_post,
                    Posts = new PostsProxy { id = item.Posts.id, Login = item.Posts.Login, Password = item.Posts.Password, TypePost = item.Posts.TypePost}
                });
            }
            return admins;
        }

        public List<CashiersProxy> GetCashiers()
        {
            List<CashiersProxy> cashiers = new List<CashiersProxy>();

            foreach (Cashiers item in context.Cashiers)
            {
                cashiers.Add(new CashiersProxy
                {
                    DateBeginWork = item.DateBeginWork,
                    Patronymic = item.Patronymic,
                    id = item.id,
                    Surname = item.Surname,
                    Name = item.Name,
                    id_post = item.id_post,
                    Posts = new PostsProxy { id = item.Posts.id, Login = item.Posts.Login, Password = item.Posts.Password, TypePost = item.Posts.TypePost }
                });
            }
            return cashiers;
        }

        public List<CategoriesProxy> GetCategories()
        {
            List<CategoriesProxy> categories = new List<CategoriesProxy>();

            foreach (Categories item in context.Categories)
            {
                categories.Add(new CategoriesProxy
                {
                    id = item.id,
                    Category = item.Category
                });
            }
            return categories;
        }

        public List<ChecksProxy> GetChecks()
        {
            List<ChecksProxy> checks = new List<ChecksProxy>();

            foreach (Checks item in context.Checks)
            {
                checks.Add(new ChecksProxy
                {
                    id = item.id,
                    id_cashier = item.id_cashier,
                    id_product = item.id_product,
                    id_client = item.id_client,
                    DatePurchase = item.DatePurchase.Date,
                    TotalSumm = item.TotalSumm,
                    Info = item.Info,
                    Quantity = item.Quantity,
                    Cashiers = new CashiersProxy { Name = item.Cashiers.Name, Surname = item.Cashiers.Surname, Patronymic = item.Cashiers.Patronymic },
                    Clients = new ClientsProxy { FIO = item.Clients.FIO },
                    Products = new ProductProxy { NameProduct = item.Products.NameProduct }
                });
            }
            return checks;
        }

        public List<ManufacturersProxy> GetManufacturers()
        {
            List<ManufacturersProxy> manufacturers = new List<ManufacturersProxy>();

            foreach (Manufacturers item in context.Manufacturers)
            {
                manufacturers.Add(new ManufacturersProxy
                {
                    id = item.id,
                    Manufactured = item.Manufactured
                });
            }
            return manufacturers;
        }

        public List<PostsProxy> GetPosts()
        {
            List<PostsProxy> posts = new List<PostsProxy>();

            foreach (Posts item in context.Posts)
            {
                posts.Add(new PostsProxy
                {
                    id = item.id,
                    Login = item.Login,
                    Password = item.Password,
                    TypePost = item.TypePost
                });
            }
            return posts;
        }

        public List<WarehouseWorkersProxy> GetWarehouseWorkers()
        {
            List<WarehouseWorkersProxy> wareWork = new List<WarehouseWorkersProxy>();

            foreach (WarehouseWorkers item in context.WarehouseWorkers)
            {
                wareWork.Add(new WarehouseWorkersProxy
                {
                     id = item.id, 
                     DateBeginWork = item.DateBeginWork,
                     id_post = item.id_post,
                     Name = item.Name,
                     Patronymic = item.Patronymic,
                     Surname = item.Surname,
                     Posts = new PostsProxy { id = item.Posts.id, Login = item.Posts.Login, Password = item.Posts.Password, TypePost = item.Posts.TypePost}
                });
            }
            return wareWork;
        }

        
        public List<ProductProxy> ShowAllProduct()
        {
            List<ProductProxy> products = new List<ProductProxy>();

            foreach (Products item in context.Products)
            {
                products.Add(new ProductProxy
                {
                    Composition = item.Composition,
                    BestBefore = item.BestBefore,
                    DateOfManufacture = item.DateOfManufacture,
                    Id_Manufacturer = item.Manufacturers.id,
                    Id_Categories = item.Categories.id,
                    Price = item.Price,
                    CodeProduct = item.CodeProduct,
                    NameProduct = item.NameProduct,
                    id = item.id
                });
            }
            return products;
        }

        public List<ClientsProxy> GetClients()
        {
            List<ClientsProxy> clients = new List<ClientsProxy>();

            foreach (Clients item in context.Clients)
            {
                clients.Add(new ClientsProxy
                {
                    id = item.id,
                    Cash = item.Cash,
                    FIO = item.FIO,
                    NumberCard = item.NumberCard
                });
            }
            return clients;
        }

        
    }
}
