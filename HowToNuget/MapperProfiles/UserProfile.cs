using AutoMapper;
using BogusExtensions.Models;
using HowToNuget.Models;

namespace HowToNuget.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>()
                .ForMember(dest =>
                            dest.FullName,
                            opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
                .ForMember(dest =>
                            dest.Gender,
                            opt => opt.MapFrom(src => src.Gender.ToString()));
        }
    }
}
