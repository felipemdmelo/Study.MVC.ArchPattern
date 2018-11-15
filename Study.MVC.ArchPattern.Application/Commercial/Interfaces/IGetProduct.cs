using Study.MVC.ArchPattern.Domain.Entities;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Application.Commercial.Interfaces
{
    public interface IGetProduct
    {
        List<Product> GetAll();
    }
}
