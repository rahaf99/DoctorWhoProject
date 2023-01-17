using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class EnemiesProfile: Profile
    {
        public EnemiesProfile()
        {
            CreateMap<Enemy, EnemyDto>()
                    .ForMember(
                    dest => dest.EnemyId,
                    opt => opt.MapFrom(src => $"{src.EnemyId}"))
                    .ForMember(
                    dest => dest.EnemyName,
                    opt => opt.MapFrom(src => $"{src.EnemyName}"))
                    .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => $"{src.Description}"));

            CreateMap<EnemyDto, Enemy>()
                    .ForMember(
                    dest => dest.EnemyId,
                    opt => opt.MapFrom(src => $"{src.EnemyId}"))
                    .ForMember(
                    dest => dest.EnemyName,
                    opt => opt.MapFrom(src => $"{src.EnemyName}"))
                    .ForMember(
                    dest => dest.Description,
                    opt => opt.MapFrom(src => $"{src.Description}"));
        }
    }
}
