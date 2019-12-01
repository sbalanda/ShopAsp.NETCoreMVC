using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    
                new Car
                {
                    Name = "Tesla Model S",
                    ShortDesc = "Быстрый автомобиль",
                    LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                    Img = "/img/tesla_model_s.jpg",
                    Price = 45000,
                    IsFavourite = true,
                    Available = true,
                    Category = Categories["Электромобили"]
                },
                new Car
                {
                    Name = "Ford Fiesta",
                    ShortDesc = "Тихий и спокойный",
                    LongDesc = "Удобный автомобиль",
                    Img = "/img/ford_fiesta.jpeg",
                    Price = 11000,
                    IsFavourite = false,
                    Available = true,
                    Category = Categories["Классические автомобили"]
                },

                new Car
                {
                    Name = "BMW M3",
                    ShortDesc = "Дерзкий и сильный",
                    LongDesc = "Удобный автомобиль для городской жизни",
                    Img = "/img/bmw_m3.jpg",
                    Price = 65000,
                    IsFavourite = true,
                    Available = true,
                    Category = Categories["Классические автомобили"]
                },

                new Car
                {
                    Name = "Mercedes C class",
                    ShortDesc = "Уютный и большой",
                    LongDesc = "Удобный автомобиль для городской жизни",
                    Img = "/img/mercedes_c_class.jpg",
                    Price = 40000,
                    IsFavourite = false,
                    Available = false,
                    Category = Categories["Классические автомобили"]
                },

                new Car
                {
                    Name = "Nissan Leaf",
                    ShortDesc = "бесшумный и экономный",
                    LongDesc = "Удобный автомобиль для городской жизни",
                    Img = "/img/nissan_leaf.jpg",
                    Price = 14000,
                    IsFavourite = true,
                    Available = true,
                    Category = Categories["Электромобили"]
                }
             
                );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category; 

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Электромобили",
                                    Desc = "Современный вид транспорта" },
                        new Category { CategoryName = "Классические автомобили",
                                    Desc = "Машины с двигателем внетреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }

                return category; 
            }
        }
    }
}
