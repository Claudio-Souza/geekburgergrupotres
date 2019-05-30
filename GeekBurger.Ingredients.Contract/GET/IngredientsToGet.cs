using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.Ingredients.Contract.GET
{
    public class IngredientsToGet
    {
        public List<ItemIngredientsToGet> Restrictions { get; set; }
        public int StoreId { get; set; }

    }
}
