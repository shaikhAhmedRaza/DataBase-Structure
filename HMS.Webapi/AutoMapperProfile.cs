using AutoMapper;

namespace HMS.Webapi
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<HMS.Domain.Model.Dish, HMS.Domain.Dish>();
        }
    }
}
