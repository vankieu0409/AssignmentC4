using System.Threading.Tasks.Dataflow;
using AssignmentC4.Entities;
using AssignmentC4.Repositories.Interface;
using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.ModelCommand.Cart;
using AssignmentC4.ViewModels.Show;
using AutoMapper;

namespace AssignmentC4.Service.Implement;

public class CartService:ICartService
{
    private readonly GenericInterface<Carts> _cart;
    private readonly GenericInterface<ProductCarts> _giohang;
    private readonly GenericInterface<Products> _product;
    private readonly GenericInterface<Customer> _customer;
    private readonly IMapper _mapper;

    public CartService(GenericInterface<Carts> cart, GenericInterface<ProductCarts> giohang, GenericInterface<Products> product, GenericInterface<Customer> customer, IMapper mapper)
    {
        _cart = cart ?? throw new ArgumentNullException(nameof(cart));
        _giohang = giohang ?? throw new ArgumentNullException(nameof(giohang));
        _product = product ?? throw new ArgumentNullException(nameof(product));
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public Task<List<ProductViewModelsCart>> GetAllListCart()
    {
        var lstCart = _cart.GetAll().ToList();
        return 
    }

    public async Task<List<ProductViewModelsCart>> GetProductsInGioHang(Guid idCart)
    {
        var ProductInCart = _giohang.GetAll().Where(c => c.IdCart == idCart&& c.IsDeleted==true);
        var listProductInCart= ProductInCart.Join(_product.GetAll(), a => a.IdProduct, b => b.IdProduct, (a, b) => new {b.NameProduct,b.Image,a.Quantity,a.Price});
        var listProductInCartShow = _mapper.Map<List<ProductViewModelsCart>>(listProductInCart);
         return listProductInCartShow;
    }

    public async Task<List<ProductViewModelsCart>> AddProductsToGioHang(Guid idcart, AddProToCartViewModel pro)
    {
        var productInCart = new ProductCarts();
        productInCart.IdCart = idcart;
        productInCart.IdProduct = pro.idProduct;
        productInCart.IsDeleted = true;
        productInCart.IdProduct = pro.idProduct;
        productInCart.Quantity = pro.Quantity;
        productInCart.Price = pro.Price;

        _giohang.AddAsync(productInCart);

        return await GetProductsInGioHang(idcart) ;
    }

    public async Task<List<ProductViewModelsCart>> UpdateProductsToGioHang(Guid idcart, AddProToCartViewModel pro)
    {
        var productInCart = _giohang.GetAll().FirstOrDefault(c=> Guid.Equals(c.IdCart,idcart)&& Guid.Equals(c.IdProduct,pro.idProduct));
        productInCart.IsDeleted = true;
        productInCart.IdProduct = pro.idProduct;
        productInCart.Quantity = pro.Quantity;
        productInCart.Price = pro.Price;

        _giohang.Update(productInCart);

        return await GetProductsInGioHang(idcart);
    }

    public async Task<List<ProductViewModelsCart>> DeleteProductsInGioHang(Guid idcart, AddProToCartViewModel pro)
    {
        var productInCart = _giohang.GetAll().FirstOrDefault(c => Guid.Equals(c.IdCart, idcart) && Guid.Equals(c.IdProduct, pro.idProduct));
       _giohang.Delete(productInCart);
       return await GetProductsInGioHang(idcart);
    }
}