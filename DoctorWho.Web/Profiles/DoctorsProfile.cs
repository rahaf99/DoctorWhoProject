using AutoMapper;
using DoctorWho.Db;
using DoctorWho.Db.Entities;

namespace DoctorWho.Web.Profiles
{
    public class DoctorsProfile : Profile
    {
        public DoctorsProfile()
        {
            CreateMap<Doctor, Models.DoctorDto>()
                .ForMember(
                dest => dest.DoctorName,
                opt => opt.MapFrom(src => $"{src.DoctorName}"))
                .ForMember(
                dest => dest.DoctorNumber,
                opt => opt.MapFrom(src => $"{src.DoctorNumber}"))
                .ForMember(
                dest => dest.BirthDate,
                opt => opt.MapFrom(src => $"{src.BirthDate}"))
                .ForMember(
                dest => dest.FirstEpisodeDate,
                opt => opt.MapFrom(src => $"{src.FirstEpisodeDate}"))
                .ForMember(
                dest => dest.LastEpisodeDate,
                opt => opt.MapFrom(src => $"{src.LastEpisodeDate}"));
        }
    }
}
