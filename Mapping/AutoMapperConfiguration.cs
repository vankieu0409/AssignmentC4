using AssignmentC4.Entities;
using AssignmentC4.ViewModels.DTOs;
using AssignmentC4.ViewModels.Show;
using AutoMapper;

namespace AssignmentC4.Maping;

public class AutoMapperConfiguration : Profile
{
    public AutoMapperConfiguration()
    {
        CreateMap<Products, ProductViewModel>().ReverseMap();
        CreateMap<Products, ProductInput>().ReverseMap();
    }
}