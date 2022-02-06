using RecipeManager.Domain.Base;
using RecipeManager.Domain.Interfaces;
using RecipeManager.Infrastructure.Context;
using RecipeManager.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RecipeContext _dbContext;

        public UnitOfWork(RecipeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity
        {
            return new RepositoryBase<T>(_dbContext);
        }

        public IUserRepository UserRepository()
        {
            return new UserRepository(_dbContext);
        }

        public IRecipeRepository RecipeRepository()
        {
            return new RecipeRepository(_dbContext);
        }

        public IIngredientRepository IngredientRepository()
        {
            return new IngredientRepository(_dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
