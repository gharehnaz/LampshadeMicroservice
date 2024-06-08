using FluentValidation;

namespace ShopManagement.Core.Contracts.Commands.ProductCategoryAgg
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCategory>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(u => u.Name)
                   .NotEmpty().WithMessage("this field is required")
                   .MaximumLength(50).WithMessage("first name must be less than 50");
        }
    }
}
