using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Web.Interfaces;
using DoctorWho.Web.Models;
using DoctorWho.Web.Validators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IEpisodeRepository _episodeRepository;
        private readonly IMapper _mapper;
        private readonly EpisodeValidator _episodeValidator;
        public EpisodeService(DoctorWhoCoreDbContext context, IEpisodeRepository repository, IMapper mapper, EpisodeValidator episodeValidator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _episodeRepository = repository;
            _mapper = mapper;
            _episodeValidator = episodeValidator;
        }

        public IEnumerable<EpisodeDto> GetAllEpisodes()
        {
            var episodes = _episodeRepository.GetAllEpisodes();
            var response = episodes.Select(x => _mapper.Map<EpisodeDto>(x));
            return response;
        }
        public Episode CreateEpisode(EpisodeDto episodeDto)
        {
            ValidationResult result = _episodeValidator.Validate(episodeDto);
            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine("Property" + failure.PropertyName + "Failed Validation Error was:" + failure.ErrorMessage);
                }
            }
            else
            {
                var episode = _mapper.Map<Episode>(episodeDto);
                _episodeRepository.CreateEpisode(episode);
                return episode;
            }
            return null;
        }

        public void deleteEpisode(int id)
        {
            throw new NotImplementedException();
        }

        public void updateEpisode(EpisodeDto episodeDto)
        {
            throw new NotImplementedException();
        }
    }
}
