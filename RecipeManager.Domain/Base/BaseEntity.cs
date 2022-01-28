using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Base
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
