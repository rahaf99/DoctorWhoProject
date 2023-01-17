using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class EpisodeCompanionsProfile : Profile
    {
        public EpisodeCompanionsProfile()
        {
            CreateMap<EpisodeCompanion, EpisodeCompanionDto>()
                .ForMember(
                dest => dest.EpisodeCompanionId,
                opt => opt.MapFrom(src => $"{src.EpisodeCompanionId}"))
                .ForMember(
                dest => dest.EpisodeId,
                opt => opt.MapFrom(src => $"{src.EpisodeId}"))
                .ForMember(
                dest => dest.CompanionId,
                opt => opt.MapFrom(src => $"{src.CompanionId}"));

            CreateMap<EpisodeCompanionDto,EpisodeCompanion>()
               .ForMember(
               dest => dest.EpisodeCompanionId,
               opt => opt.MapFrom(src => $"{src.EpisodeCompanionId}"))
               .ForMember(
               dest => dest.EpisodeId,
               opt => opt.MapFrom(src => $"{src.EpisodeId}"))
               .ForMember(
               dest => dest.CompanionId,
               opt => opt.MapFrom(src => $"{src.CompanionId}"));
        }
    }
}
