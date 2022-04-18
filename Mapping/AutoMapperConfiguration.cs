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
        CreateMap<Customer, CustomerViewModel>().ReverseMap();
        CreateMap<ProductCUDViewModel, CustomerViewModel>().ReverseMap();
        CreateMap<Carts, CartViewModels>().ReverseMap();
        CreateMap<Products, CartProductFake>().ReverseMap();

    }
}