using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using Study.MVC.ArchPattern.Application.Commercial.Interfaces;
using Study.MVC.ArchPattern.Domain.Entities;

namespace Study.MVC.ArchPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IAddProductWithStock _addProductWithStock;
        private readonly IGetProduct _getProduct;

        public ProductController(IAddProductWithStock addProductWithStock, IGetProduct getProduct)
        {
            _addProductWithStock = addProductWithStock;
            _getProduct = getProduct;
        }

        // GET: api/Product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            _addProductWithStock.Execute(new Product
            {
                Name = "Ar Condicionado",
                Price = 899.90
            });

            _addProductWithStock.Execute(new Product
            {
                Name = "Cadeira de Escritório",
                Price = 349.90
            });

            return _getProduct.GetAll();
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        [HttpPost]
        public string Post([FromBody] Product value)
        {
            try
            {
                _addProductWithStock.Execute(value);
                return $"Produto adicionado com sucesso!";
            }
            catch(Exception e)
            {
                return $"Não foi possível adicionar o produto. Detalhe do erro: {e.Message}";
            }
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
