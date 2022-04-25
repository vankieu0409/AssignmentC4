using AssignmentC4.Entities;
using AssignmentC4.ViewModels.ModelCommand;
using AssignmentC4.ViewModels.Show;

using AutoMapper;

namespace AssignmentC4.Maping;

public class AutoMapperConfiguration : Profile
{
    public AutoMapperConfiguration()
    {
        CreateMap<Products, ProductViewModel>().ReverseMap();
        CreateMap<ProductViewModel,Products>().ReverseMap();
        CreateMap<Customer, CustomerViewModel>().ReverseMap();
        CreateMap<Products, ViewModels.ModelCommand.Cart.CartViewModels>().ReverseMap();
        CreateMap<ViewModels.ModelCommand.Cart.CartViewModels, Products>().ReverseMap();
        CreateMap<ProductCarts, ViewModels.ModelCommand.Cart.CartViewModels>().ReverseMap();
        CreateMap<ViewModels.ModelCommand.Cart.CartViewModels, ProductCarts>().ReverseMap();
    }
}