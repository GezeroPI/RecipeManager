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
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.FirstName).Length(0, 100);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.RoleId).InclusiveBetween(1, 2).WithMessage(errorMessage:"Role id must be between 1 - 2");
        }
    }
}
