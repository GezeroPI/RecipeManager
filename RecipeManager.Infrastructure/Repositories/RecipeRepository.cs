using RecipeManager.Domain.Entities;
using RecipeManager.Domain.Interfaces;
using RecipeManager.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Infrastructure.Repositories
{
    public class RecipeRepository : RepositoryBase<Recipe>, IRecipeRepository
    {
        public RecipeRepository(RecipeContext dbContext) : base(dbContext)
        {
        }

    }
}
