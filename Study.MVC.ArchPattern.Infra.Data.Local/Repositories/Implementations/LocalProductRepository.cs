using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Repositories.Interfaces;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Infra.Data.Local.Repositories.Implementations
{
    public class LocalProductRepository : IProductRepository
    {
        public long Insert(Product entity)
        {
            entity.Id = NextVal();
            LocalDataBase.Products.Add(entity);

            return entity.Id;
        }

        public List<Product> GetAll()
        {
            return LocalDataBase.Products;
        }

        #region PRIVATE METHODS..
        private long NextVal()
        {
            return LocalDataBase.Products.Count + 1;
        }
        #endregion
    }
}
