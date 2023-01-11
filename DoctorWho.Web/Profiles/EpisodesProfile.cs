using AutoMapper;
using DoctorWho.Db.Entities;

namespace DoctorWho.Web.Profiles
{
    public class EpisodesProfile : Profile
    {
        public EpisodesProfile()
        {
            CreateMap<Episode, Models.EpisodeDto>()
                .ForMember(
                dest => dest.EpisodeId,
                opt => opt.MapFrom(src => $"{src.EpisodeId}"))
                .ForMember(
                dest => dest.EpisodeNumber,
                opt => opt.MapFrom(src => $"{src.EpisodeNumber}"))
                .ForMember(
                dest => dest.SeriesNumber,
                opt => opt.MapFrom(src => $"{src.SeriesNumber}"))
                .ForMember(
                dest => dest.EpisodeDate,
                opt => opt.MapFrom(src => $"{src.EpisodeDate}"))
                .ForMember(
                dest => dest.EpisodeType,
                opt => opt.MapFrom(src => $"{src.EpisodeType}"))
                .ForMember(
                dest => dest.Title,
                opt => opt.MapFrom(src => $"{src.Title}"))
                .ForMember(
                dest => dest.AuthorId,
                opt => opt.MapFrom(src => $"{src.AuthorId}"))
                .ForMember(
                dest => dest.DoctorId,
                opt => opt.MapFrom(src => $"{src.DoctorId}"))
                .ForMember(
                dest => dest.Notes,
                opt => opt.MapFrom(src => $"{src.Notes}"));
        }
    }
}
