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
                        Img = "https://www.google.ru/imgres?imgurl=https%3A%2F%2Fwww.tesla.com%2Fsites%2Ftesla%2Ffiles%2Fcarousel%2Fimage%2Fcharger-1%25402.jpg&imgrefurl=https%3A%2F%2Fwww.tesla.com%2Fmodels&docid=Ei43u66-EP2a1M&tbnid=_OrQJj69ayB4UM%3A&vet=10ahUKEwi2g6Sfl4_mAhVeAhAIHYnZCrIQMwhMKAMwAw..i&w=2452&h=1124&client=opera&bih=658&biw=1366&q=tesla%20model%20s&ved=0ahUKEwi2g6Sfl4_mAhVeAhAIHYnZCrIQMwhMKAMwAw&iact=mrc&uact=8",
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
                        Img = "https://www.google.ru/imgres?imgurl=https%3A%2F%2Fwww.ford.ru%2Fcontent%2Fdam%2Fguxeu%2Fru%2Fru_ru%2Fcars%2Ffiesta%2Fbillboards%2Fford-fiesta-ru-asset_id-21x9-2160x925-bb-blue.jpg.renditions.extra-large.jpeg&imgrefurl=https%3A%2F%2Fwww.ford.ru%2Fcars%2Ffiesta&docid=Mkx1zriIfN-C1M&tbnid=O8MpUGZPCXp8pM%3A&vet=10ahUKEwjrzeX3l4_mAhUulIsKHRV_AhoQMwhOKAAwAA..i&w=1440&h=616&client=opera&bih=658&biw=1366&q=Ford%20Fiesta&ved=0ahUKEwjrzeX3l4_mAhUulIsKHRV_AhoQMwhOKAAwAA&iact=mrc&uact=8",
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
                        Img = "",
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
                        Img = "",
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
                        Img = "",
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
