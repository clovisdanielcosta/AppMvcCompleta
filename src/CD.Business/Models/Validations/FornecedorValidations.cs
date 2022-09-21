using FluentValidation;

namespace CD.Business.Models.Validations
{
    public class FornecedorValidations : AbstractValidator<Fornecedor>
    {
        public FornecedorValidations()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser digitado")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres");
        }
    }
}
