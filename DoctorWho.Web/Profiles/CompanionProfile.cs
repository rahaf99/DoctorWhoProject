using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class CompanionProfile: Profile
    {
        public CompanionProfile()
        {
            CreateMap<Companion, CompanionDto>()
                    .ForMember(
                    dest => dest.CompanionId,
                    opt => opt.MapFrom(src => $"{src.CompanionId}"))
                    .ForMember(
                    dest => dest.CompanionName,
                    opt => opt.MapFrom(src => $"{src.CompanionName}"))
                    .ForMember(
                    dest => dest.WhoPlayed,
                    opt => opt.MapFrom(src => $"{src.WhoPlayed}"));

            CreateMap<CompanionDto, Companion>()
                    .ForMember(
                    dest => dest.CompanionId,
                    opt => opt.MapFrom(src => $"{src.CompanionId}"))
                    .ForMember(
                    dest => dest.CompanionName,
                    opt => opt.MapFrom(src => $"{src.CompanionName}"))
                    .ForMember(
                    dest => dest.WhoPlayed,
                    opt => opt.MapFrom(src => $"{src.WhoPlayed}"));
        }
    }
}
