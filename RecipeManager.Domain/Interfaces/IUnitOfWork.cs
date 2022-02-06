using RecipeManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        IUserRepository UserRepository();

        IRecipeRepository RecipeRepository();

        IIngredientRepository IngredientRepository();

        IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity;
    }
}
