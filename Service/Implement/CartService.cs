using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using AssignmentC4.Entities;
using AssignmentC4.Repositories.Interface;
using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.ModelCommand.Cart;
using AssignmentC4.ViewModels.Show;
using AutoMapper;

namespace AssignmentC4.Service.Implement;

public class CartService: ICartService
{
    private readonly GenericInterface<ProductCarts> _giohang;
    private readonly GenericInterface<Products> _product;
    private readonly GenericInterface<Customer> _customer;
    private readonly IMapper _mapper;

    public CartService(GenericInterface<ProductCarts> giohang, GenericInterface<Products> product, GenericInterface<Customer> customer, IMapper mapper)
    {
        _giohang = giohang ?? throw new ArgumentNullException(nameof(giohang));
        _product = product ?? throw new ArgumentNullException(nameof(product));
        _customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    public async Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> GetAllProductsInCartAsyn(Guid id)
    {
        var lstProduct = _giohang.GetAll().Where(x=>x.CustomerID == id).ToList();
        var response = _mapper.Map<List<ViewModels.ModelCommand.Cart.CartViewModels>>(lstProduct.ToList());
        return response;
    }
    public async Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> GetProductsInCartAsyn(Guid idCart)
    {
        var ProductInCart = _giohang.GetAll().Where(c => c.CustomerID == idCart&& c.IsDeleted==true);
        var listProductInCart= ProductInCart.Join(_product.GetAll(), a => a.IdProduct, b => b.IdProduct, (a, b) => new {b.IdProduct,b.NameProduct,b.Image,a.Quantity,a.Price});
        var listProductInCartShow = _mapper.Map<List<ViewModels.ModelCommand.Cart.CartViewModels>>(listProductInCart.ToList());
         return listProductInCartShow;
    }

    public async Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> AddProductsToCartAsyn( ViewModels.ModelCommand.Cart.CartViewModels pro)
    {
        try
        {
            var item = _mapper.Map<ProductCarts>(pro);

            await _giohang.AddAsync(item);

            return await GetProductsInCartAsyn(pro.CustomerID);
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }
    }

    public async Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> UpdateProductsToCartAsyn( ViewModels.ModelCommand.Cart.CartViewModels pro)
    {
        var productInCart = _giohang.GetAll().FirstOrDefault(c=> Guid.Equals(c.CustomerID,pro.CustomerID)&& Guid.Equals(c.IdProduct,pro.ProductID));
        productInCart.IsDeleted = true;
        productInCart.IdProduct = pro.ProductID;
        productInCart.Quantity = pro.Quantity;
        productInCart.Price = pro.Price;

        await _giohang.UpdateAsync(productInCart);

        return await GetProductsInCartAsyn(pro.CustomerID);
    }

    public async Task<List<ViewModels.ModelCommand.Cart.CartViewModels>> DeleteProductsInCartAsyn(ViewModels.ModelCommand.Cart.CartViewModels pro)
    {
        var productInCart = _giohang.GetAll().FirstOrDefault(c => Guid.Equals(c.CustomerID, pro.CustomerID) && Guid.Equals(c.IdProduct, pro.ProductID));
       await _giohang.DeleteAsync(productInCart);
       return await GetProductsInCartAsyn(pro.CustomerID);
    }


}