using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class AuthorsProfile : Profile
    {
        public AuthorsProfile()
        {
            CreateMap<Author, AuthorDto>()
                  .ForMember(
                dest => dest.AuthorId,
                opt => opt.MapFrom(src => $"{src.AuthorId}"))
                .ForMember(
                dest => dest.AuthorName,
                opt => opt.MapFrom(src => $"{src.AuthorName}"))
                .ForMember(
                dest => dest.AuthorId,
                opt => opt.MapFrom(src => $"{src.AuthorId}"));

            CreateMap<AuthorDto, Author>()
                 .ForMember(
                dest => dest.AuthorId,
                opt => opt.MapFrom(src => $"{src.AuthorId}"))
                .ForMember(
                dest => dest.AuthorName,
                opt => opt.MapFrom(src => $"{src.AuthorName}"))
                .ForMember(
                dest => dest.AuthorId,
                opt => opt.MapFrom(src => $"{src.AuthorId}"));
        }
    }
}
