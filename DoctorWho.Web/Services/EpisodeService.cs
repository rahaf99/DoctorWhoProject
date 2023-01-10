using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Interfaces;
using DoctorWho.Web.Models;
using DoctorWho.Web.Validators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly DoctorWhoCoreDbContext _context;
        private readonly IEpisodeRepository _repository;
        private readonly IMapper _mapper;
        private readonly EpisodeValidator _episodeValidator;
        public EpisodeService(DoctorWhoCoreDbContext context, IEpisodeRepository repository, IMapper mapper, EpisodeValidator episodeValidator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repository = repository;
            _mapper = mapper;
            _episodeValidator = episodeValidator;
        }

        public IEnumerable<EpisodeDto> GetAllEpisodes()
        {
            var episodes = _repository.GetAllEpisodes();
            var response = episodes.Select(x => _mapper.Map<EpisodeDto>(x));
            return response;
        }
        public Episode createEpisode(EpisodeDto episodeDto)
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
                _repository.createEpisode(episode);
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
