using FluentValidation;

namespace RecipeManager.Api.DTOs
{
    public class IngredientCreateReq
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
    }
    public class IngredientCreateReqValidator : AbstractValidator<IngredientCreateReq>
    {
        public IngredientCreateReqValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage(errorMessage: "Name is mandatory");
            RuleFor(x => x.Quantity).NotNull().GreaterThan(1).WithMessage(errorMessage: "Quantity must greater than 1");
        }
    }
}
