using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace RecipeManager.Api.DTOs
{
    public class AddUserRequest
    {
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public long RoleId { get; set; }
    }
    public class AddUserRequestValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage(errorMessage: "Username is mandatory");
            RuleFor(x => x.FirstName).NotNull().Length(3, 100).WithMessage(errorMessage: "Firstname must between 3-100 chars");
            RuleFor(x => x.LastName).NotNull().Length(3, 100).WithMessage(errorMessage: "Lastname must between 3-100 chars");
            RuleFor(x => x.Email).EmailAddress().WithMessage(errorMessage: "Email in not valid");
            RuleFor(x => x.RoleId).InclusiveBetween(1, 2).WithMessage(errorMessage:"Role id must be between 1 - 2");
        }
    }
}
