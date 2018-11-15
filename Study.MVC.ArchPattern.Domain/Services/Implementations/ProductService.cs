using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Exceptions;
using Study.MVC.ArchPattern.Domain.Repositories.Interfaces;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public long Insert(Product entity)
        {
            List<string> errors = new List<string>();
            #region VALIDATIONS..
            if (entity.Id > 0)
                errors.Add("Não é permitido inserir produto com Id");

            if (string.IsNullOrEmpty(entity.Name))
                errors.Add("Nome é obrigatório");

            if (entity.Price <= 0)
                errors.Add("Preço inválido");
            #endregion

            if(errors.Count > 0)
                throw new ProductException.InsertException("Ocorreu falha na inserção do Produto!", errors);

            return _productRepository.Insert(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
