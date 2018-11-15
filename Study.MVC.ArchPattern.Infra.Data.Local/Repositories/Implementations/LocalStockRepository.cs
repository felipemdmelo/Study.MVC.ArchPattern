using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Repositories.Interfaces;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Infra.Data.Local.Repositories.Implementations
{
    public class LocalStockRepository : IStockRepository
    {
        private List<Stock> _stocks;

        public LocalStockRepository()
        {
            _stocks = new List<Stock>();
        }

        public long Insert(Stock entity)
        {
            entity.Id = NextVal();
            _stocks.Add(entity);

            return entity.Id;
        }

        public List<Stock> GetAll()
        {
            return _stocks;
        }

        #region PRIVATE METHODS..
        private long NextVal()
        {
            return _stocks.Count + 1;
        }
        #endregion
    }
}
