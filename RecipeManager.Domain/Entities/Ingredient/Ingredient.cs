using RecipeManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Entities
{
    public partial class Ingredient : BaseEntity
    {

        [Required]
        public string Name { get; set; }
        public StockIngredient StockIngredient { get; set; }
        [Required]
        public long StockIngredientId { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
