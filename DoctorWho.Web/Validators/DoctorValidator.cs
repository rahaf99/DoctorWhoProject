using DoctorWho.Web.Models;
using FluentValidation;

namespace DoctorWho.Web.Validators
{
    public class DoctorValidator : AbstractValidator<DoctorDto>
    {
        public DoctorValidator()
        {
            RuleFor(doctor => doctor.DoctorName).NotEmpty();
            RuleFor(doctor => doctor.DoctorNumber).NotEmpty();
            RuleFor(doctor => doctor.LastEpisodeDate).GreaterThanOrEqualTo(doctor => doctor.FirstEpisodeDate);
            When(doctor => doctor.FirstEpisodeDate == null, () =>
            {
                RuleFor(doctor => doctor.LastEpisodeDate).Null();
            });
        }
    }
}
