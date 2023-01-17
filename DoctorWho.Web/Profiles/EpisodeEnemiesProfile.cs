using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class EpisodeEnemiesProfile : Profile
    {
        public EpisodeEnemiesProfile()
        {
            CreateMap<EpisodeEnemy, EpisodeEnemyDto>()
                .ForMember(
                dest => dest.EpisodeEnemyId,
                opt => opt.MapFrom(src => $"{src.EpisodeEnemyId}"))
                .ForMember(
                dest => dest.EpisodeId,
                opt => opt.MapFrom(src => $"{src.EpisodeId}"))
                .ForMember(
                dest => dest.EnemyId,
                opt => opt.MapFrom(src => $"{src.EnemyId}"));

            CreateMap<EpisodeEnemyDto, EpisodeEnemy>()
                 .ForMember(
                 dest => dest.EpisodeEnemyId,
                 opt => opt.MapFrom(src => $"{src.EpisodeEnemyId}"))
                 .ForMember(
                 dest => dest.EpisodeId,
                 opt => opt.MapFrom(src => $"{src.EpisodeId}"))
                 .ForMember(
                 dest => dest.EnemyId,
                 opt => opt.MapFrom(src => $"{src.EnemyId}"));
        }
    }
}
