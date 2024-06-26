using CarritoDeCompras.Entidades;

namespace CarritoDeCompras.Interfaces
{
    public interface IShoppingCart
    {
        void AddArticle(Product[] products);
        void ViewCar(Product[] products);
        void DeleteArticle();
    }
}
