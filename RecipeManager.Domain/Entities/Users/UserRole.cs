using RecipeManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Entities
{
    public partial class UserRole:BaseEntity
    {
        public string Title { get; set; }

    }
}
