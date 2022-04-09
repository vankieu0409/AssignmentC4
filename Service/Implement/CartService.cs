using AssignmentC4.Entities;
using AssignmentC4.Repositories.Interface;

namespace AssignmentC4.Service.Implement;

public class CartService
{
    private readonly GenericInterface<Carts> _cart;
    private readonly GenericInterface<ProductCarts> _giohang;
    private readonly GenericInterface<Products> _product;
    private readonly GenericInterface<Customer> _customer;

    public CartService(GenericInterface<Carts> cart, GenericInterface<ProductCarts> giohang, GenericInterface<Products> product, GenericInterface<Customer> customer)
    {
        _cart = cart ?? throw new ArgumentNullException(nameof(cart));
        _giohang = giohang ?? throw new ArgumentNullException(nameof(giohang));
        _product = product ?? throw new ArgumentNullException(nameof(product));
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
    }

    //public async Task<List<Products>> GetProductsInGioHang(Guid IdCart)
    //{

    //}
}