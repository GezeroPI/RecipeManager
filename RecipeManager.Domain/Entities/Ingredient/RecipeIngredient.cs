using RecipeManager.Domain.Base;
using RecipeManager.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Entities
{
    public partial class RecipeIngredient:BaseEntity
    {
        public Ingredient Ingredient { get; set; }
        [Required]
        public long IngredientId { get; set; }
        public Recipe Recipe { get; set; }
        [Required]
        public long RecipeId { get; set; }
        [Required]
        public double Quantity { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}
