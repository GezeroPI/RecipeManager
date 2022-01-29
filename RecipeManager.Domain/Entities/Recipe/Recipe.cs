using RecipeManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Entities
{
    public partial class Recipe : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
