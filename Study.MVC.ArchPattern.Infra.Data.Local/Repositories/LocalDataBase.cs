using Study.MVC.ArchPattern.Domain.Entities;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Infra.Data.Local.Repositories
{
    public class LocalDataBase
    {
        public static List<Product> _products;
        public static List<Product> Products
        {
            get
            {
                if(_products == null)
                    _products = new List<Product>();

                return _products;
            }
        }
    }
}
