using AssignmentC4.Entities;
using AssignmentC4.Repositories.Interface;
using AssignmentC4.Service.Interface;
using AssignmentC4.ViewModels.ModelCommand;
using AssignmentC4.ViewModels.Show;

using AutoMapper;

namespace AssignmentC4.Service.Implement;

public class ProductsService : IProductService
{
    private readonly GenericInterface<Products> _product;
    private readonly IMapper _mapper;

    public ProductsService(GenericInterface<Products> product, IMapper mapper)
    {
        _product = product ?? throw new ArgumentNullException(nameof(product));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public IEnumerable<ProductViewModel> GetCollection()
    {
        var listProductTemp = _product.GetAll().Where(c => c.IsDeleted == true).ToList();
        var listProduct = new List<ProductViewModel>();
        listProduct = _mapper.Map<List<ProductViewModel>>(listProductTemp);
        return listProduct;
    }

    public async Task CreateProduct(ProductViewModel productNew)
    {
        var productTemp = _mapper.Map<Products>(productNew);
        productTemp.IsDeleted = true;
        await _product.AddAsync(productTemp);
    }

    public async Task UpdateProduct(ProductCUDViewModel productUpdate)
    {
        var productTemp = _product.GetAll().FirstOrDefault(c => c.IdProduct == productUpdate.IdProduct);
        productTemp = _mapper.Map<Products>(productUpdate);
        await _product.Update(productTemp);
    }
    public async Task DeleteProduct(ProductCUDViewModel productUpdate)
    {
        var productTemp = _product.GetAll().FirstOrDefault(c => c.IdProduct == productUpdate.IdProduct);
        productTemp = _mapper.Map<Products>(productUpdate);
        productTemp.IsDeleted = false;
        await _product.Update(productTemp);
    }
}