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

    public async Task<IEnumerable<ProductViewModel>> GetCollectionAsync()
    {
        var listProductTemp = _product.GetAll().Where(c => c.IsDeleted == false).ToList();
        return _mapper.Map<List<ProductViewModel>>(listProductTemp);
    }
    public async Task<IEnumerable<ProductViewModel>> GetCollectionAdminAsync()
    {
        var listProductTemp = _product.GetAll().ToList();
        return _mapper.Map<List<ProductViewModel>>(listProductTemp);
    }
    public async Task<IEnumerable<ProductViewModel>> GetProductsAsync(Guid id)
    {
        try
        {
             var product = _product.GetAll().Where(x => x.IdProduct.Equals(id)).ToList();
             var resqonse = _mapper.Map<List<ProductViewModel>>(product);
            return resqonse;
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }
    }
    public async Task CreateProductAsync(ProductViewModel productNew)
    {
        var productTemp = _mapper.Map<Products>(productNew);
        productTemp.IdProduct = Guid.NewGuid();
        productTemp.IsDeleted = true;
        await _product.AddAsync(productTemp);
    }

    public async Task UpdateProductAsync(ProductViewModel productUpdate)
    {
        var productTemp = _mapper.Map<Products>(productUpdate);
        await _product.UpdateAsync(productTemp);
    }
    public async Task DeleteProductAsync(ProductViewModel productUpdate)
    {
        var productTemp = _product.GetAll().FirstOrDefault(c => c.IdProduct == productUpdate.IdProduct);
        productTemp = _mapper.Map<Products>(productUpdate);
        productTemp.IsDeleted = false;
        await _product.UpdateAsync(productTemp);
    }
}