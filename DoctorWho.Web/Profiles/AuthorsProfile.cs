using AutoMapper;
using DoctorWho.Db.Entities;

namespace DoctorWho.Web.Profiles
{
    public class AuthorsProfile:Profile
    {
        public AuthorsProfile()
        {
            CreateMap<Author, Models.AuthorDto>()
                .ForMember(
                dest => dest.AuthorName,
                opt => opt.MapFrom(src => $"{src.AuthorName }"))
                .ForMember(
                dest => dest.AuthorId,
                opt => opt.MapFrom(src => $"{src.AuthorId}"));
        }
    }
}
