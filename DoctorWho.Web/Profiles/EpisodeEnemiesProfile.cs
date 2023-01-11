using AutoMapper;
using DoctorWho.Db.Entities;

namespace DoctorWho.Web.Profiles
{
    public class EpisodeEnemiesProfile : Profile
    {
        public EpisodeEnemiesProfile()
        {
            CreateMap<EpisodeEnemy, Models.EpisodeEnemyDto>()
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
