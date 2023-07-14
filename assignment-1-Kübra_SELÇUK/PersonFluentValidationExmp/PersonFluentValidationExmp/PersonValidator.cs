using FluentValidation;

namespace PersonFluentValidationExmp
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name cannot be empty!")
                .WithName("Staff person name")
                .MinimumLength(5)
                .WithMessage("Name lenght must be at least 5!")
                .MaximumLength(100)
                .WithMessage("Name length must be no more than 100!");

            RuleFor(x => x.Lastname)
                .NotEmpty()
                .WithMessage("Lastname cannot be lastname!")
                .WithName("Staff person name")
                .MinimumLength(5)
                .WithMessage("Lastname lenght must be at least 5!")
                .MaximumLength(100)
                .WithMessage("Last name length must be no more than 100!");

            RuleFor(x => x.Phone)
               // .Phone()
                .NotEmpty()
                .WithName("Staff person phone number")
                .WithMessage("Phone cannot be empty!");

            RuleFor(x => x.AccessLevel)
                .NotEmpty()
                .WithMessage("AccessLevel cannot be empty!")
                .WithName("Staff person access level to system")
                .InclusiveBetween(1, 5)
                .WithMessage("AccessLevel must be between 500 - 50000!");


            RuleFor(x => x.Salary)
                .NotEmpty()
                .WithMessage("Salary cannot be empty!")
                .WithName("Staff person salary")
                //.SalaryAttribute()
                .InclusiveBetween(500,50000)
                .WithMessage("Salary must be between 500 - 50000!");
        }
    }
}
