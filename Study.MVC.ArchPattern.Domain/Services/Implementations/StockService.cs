using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Exceptions;
using Study.MVC.ArchPattern.Domain.Repositories.Interfaces;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Services.Implementations
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public long Insert(Stock entity)
        {
            List<string> errors = new List<string>();
            #region VALIDATIONS..
            if (entity.Id > 0)
                errors.Add("Não é permitido inserir estoque com Id");
            #endregion

            if (errors.Count > 0)
                throw new StockException.InsertException("Ocorreu falha na inserção do Estoque!", errors);

            return _stockRepository.Insert(entity);
        }

        public List<Stock> GetAll()
        {
            return _stockRepository.GetAll();
        }
    }
}
