using GeekBurger.Ingredients.Contract.GET;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.Ingredients.Contract.POST
{
   public class IngredientsToUpsert
    {
        public List<ItemIngredientsToGet> Ingredients { get; set; }
        public int ProductId { get; set; }
    }
}
