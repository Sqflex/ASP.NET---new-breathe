using ShopAppNew.interfaces;
using ShopAppNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppNew.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name="Navi vs Envy",
                        shortDesc="Финал",
                        longDesc="Финал мажора",
                        price= 45000,
                        img="/img/Navi.jpeg",
                        isFavorite=true,
                        availible=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name="Gambit vs Esports",
                        shortDesc="Квалификации",
                        longDesc="Квалификации к минору",
                        price= 20000,
                        img="/img/Gambit.jpg",
                        isFavorite=true,
                        availible=true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name="Спартак vs Зенит",
                        shortDesc="Кубок России",
                        longDesc="1/4 Финала",
                        price= 10000,
                        img="/img/Spartak.jpg",
                        isFavorite=true,
                        availible=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name="Маккрегор vs Карлсон",
                        shortDesc="Бой за титул чемпиона",
                        longDesc="Чемпиона мма",
                        price= 10000, //priceless
                        img="/img/Conor.jpg",
                        isFavorite=true,
                        availible=true,
                        Category = _categoryCars.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
