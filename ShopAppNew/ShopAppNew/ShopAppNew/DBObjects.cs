using ShopAppNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppNew
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        { 

            if (!content.Category.Any())
                content.Category.AddRange(categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                 new Car
                 {
                     name = "Navi vs Envy",
                     shortDesc = "Полуфинал",
                     longDesc = "Полуфинал!",
                     price = 45000,
                     img = "/img/Navi.jpeg",
                     isFavorite = true,
                     availible = true,
                     Category = categories["Киберспорт"]
                 },
                 new Car
                 {
                    name = "Gambit",
                    shortDesc = "Квалификации",
                    longDesc = "Star",
                    price = 20000,
                    img = "/img/Gambit.jpg",
                    isFavorite = true,
                    availible = true,
                    Category = categories["Киберспорт"]
                 },
                 new Car
                 {
                     name = "Спартак vs Зенит",
                     shortDesc = "Кубок России",
                     longDesc = "1/4 Финала",
                     price = 10000,
                     img = "/img/Spartak.jpg",
                     isFavorite = true,
                     availible = true,
                     Category = categories["Спорт"]
                 },
                new Car
                {
                    name = "Маккрегор vs Карлсон",
                    shortDesc = "Бой за титул чемпиона",
                    longDesc = "Чемпиона мма",
                    price = 10000, //priceless
                    img = "/img/Conor.jpg",
                    isFavorite = true,
                    availible = true,
                    Category = categories["Спорт"]
                }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Киберспорт", desc= "Игры"},
                        new Category { categoryName = "Спорт", desc="Спортивная"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
