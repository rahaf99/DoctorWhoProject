using DoctorWho.Web.Models;
using FluentValidation;

namespace DoctorWho.Web.Validators
{
    public class EpisodeValidator : AbstractValidator<EpisodeDto>
    {
        public EpisodeValidator()
        {
            RuleFor(episode => episode.AuthorId).NotEmpty();
            RuleFor(episode => episode.DoctorId).NotEmpty();
            RuleFor(episode => episode.EpisodeNumber).GreaterThan(0);


        }
    }
    }
