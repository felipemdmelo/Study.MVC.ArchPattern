using Study.MVC.ArchPattern.Domain.Entities;

namespace Study.MVC.ArchPattern.Application.Commercial.Interfaces
{
    public interface IAddProductWithStock
    {
        void Execute(Product entity);
    }
}
