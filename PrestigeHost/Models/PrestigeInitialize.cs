using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PrestigeHost.Models
{
    class PrestigeInitialize : DropCreateDatabaseAlways<PrestigeModels>
    {
        protected override void Seed(PrestigeModels context)
        {
            context.Posts.AddRange(new List<Posts> { new Posts { Login = "admin", Password = "123", TypePost = "admin" } });

            context.SaveChanges();
            context.Admins.AddRange(
                  new List<Admins>
                  {
                    new Admins { Name = "Денис", Surname="Кряковцев", id_post = context.Posts.ToList().Last().id }
                  });

            context.Posts.AddRange(new List<Posts> { new Posts { Login = "cas1", Password = "123", TypePost = "cashier" } });
            context.SaveChanges();
            context.Cashiers.AddRange(new List<Cashiers> {
                new Cashiers {
                    Surname = "Иванов",
                    Name = "Хабиб",
                    Patronymic = "Макгрегорович",
                    id_post = context.Posts.ToList().Last().id,
                    DateBeginWork = new DateTime(2018,10,5)
                }});

            context.Posts.AddRange(new List<Posts> { new Posts { Login = "ware10", Password = "123", TypePost = "warehouse worker" } });
            context.SaveChanges();
            context.WarehouseWorkers.AddRange(new List<WarehouseWorkers> {
                new WarehouseWorkers {
                    Surname = "Цой",
                    Name = "Виктор",
                    Patronymic = "Определенное",
                    id_post = context.Posts.ToList().Last().id,
                    DateBeginWork = new DateTime(2015,5,7)
                }});
            //*********************************************************
            context.Categories.AddRange(new List<Categories> {
                new Categories {
                     Category = "Зерновые изделия"                      
                }, new Categories {
                     Category = "Молочная продукция"
                }, new Categories {
                     Category = "Мясные изделия"
                }, new Categories {
                     Category = "Напитки"
                }, new Categories {
                     Category = "Сладости"
                }, new Categories {
                     Category = "Алкоголь"
                }});
            context.SaveChanges();
            context.Manufacturers.AddRange(new List<Manufacturers> {
                new Manufacturers {
                    Manufactured = "ООО Агролуг г.Луганск" 
                }, new Manufacturers {
                    Manufactured = "Фабрика Рошен г.Харьков"
                }, new Manufacturers {
                    Manufactured = "Роганский Пивзавод"
                }, new Manufacturers {
                    Manufactured = "Салтовский Мясокомбинат"
                }, new Manufacturers {
                    Manufactured = "Молокозавод 'Селянське молоко' г.Харьков"
                }, new Manufacturers {
                    Manufactured = "Бонаква завод г.Житомир"
                }, new Manufacturers {
                    Manufactured = "Харьковсикй завод производства 'Coca Cola'"
                }, new Manufacturers {
                    Manufactured = "Луганский завод производства 'Fanta'"
                }
                });
            context.SaveChanges(); 

            context.Products.AddRange(new List<Products> {
                new Products {
                  NameProduct = "Хлеб",
                  CodeProduct = 12123,
                  Price = 13.0,
                  Id_Categories = 1,
                  Id_Manufacturer = 1, 
                  DateOfManufacture = new DateTime(2018,11,4),
                  BestBefore = new DateTime(2018,12,4),
                  Composition = "Мука,Вода,Соль"
                },
                new Products {
                  NameProduct = "Фанта",
                  CodeProduct = 13232,
                  Price = 16.0,
                  Id_Categories = 4,
                  Id_Manufacturer = 8,
                  DateOfManufacture = new DateTime(2018,9,14),
                  BestBefore = new DateTime(2019,2,18),
                  Composition = "Вода,Сахар,Краситель"
                },
                 new Products {
                  NameProduct = "Молоко",
                  CodeProduct = 2312312,
                  Price = 23.0,
                  Id_Categories = 2,
                  Id_Manufacturer = 5,
                  DateOfManufacture = new DateTime(2018,11,5),
                  BestBefore = new DateTime(2018,12,5),
                  Composition = "Молоко 20% жирности, Вода"
                },
            });
            base.Seed(context);
        }
    }
}
