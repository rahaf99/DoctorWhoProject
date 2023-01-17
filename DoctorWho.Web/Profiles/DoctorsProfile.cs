using AutoMapper;
using DoctorWho.Db;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class DoctorsProfile : Profile
    {
        public DoctorsProfile()
        {
            CreateMap<Doctor,DoctorDto>()
                .ForMember(
                dest => dest.DoctorId,
                opt => opt.MapFrom(src => $"{src.DoctorId}"))
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

            CreateMap<DoctorDto, Doctor>()
                .ForMember(
                dest => dest.DoctorId,
                opt => opt.MapFrom(src => $"{src.DoctorId}"))
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
