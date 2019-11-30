using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Img = "/img/tesla_model_s.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _carsCategory.AllCategories.First()
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
                        Category = _carsCategory.AllCategories.Last()
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
                        Category = _carsCategory.AllCategories.Last()
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
                        Category = _carsCategory.AllCategories.Last()
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
                        Category = _carsCategory.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
