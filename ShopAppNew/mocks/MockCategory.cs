using ShopAppNew.interfaces;
using ShopAppNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppNew.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Спорт", desc= "Виды спорта для ставок"},
                    new Category { categoryName = "Киберспорт", desc="Соревнования в киберпространстве"}
                };
            }
            set
            {

            }
        }
    }
}
