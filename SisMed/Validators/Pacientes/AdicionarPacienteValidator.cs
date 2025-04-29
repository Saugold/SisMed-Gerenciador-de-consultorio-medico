using FluentValidation;
using SisMed.Models.Contexts;
using SisMed.ViewModels.Pacientes;
using System.Text.RegularExpressions;

namespace SisMed.Validators.Pacientes
{
    public class AdicionarPacienteValidator : AbstractValidator<AdicionarPacienteViewModel>
    {
        public AdicionarPacienteValidator(SisMedContext context)
        {
            RuleFor(x => x.CPF).NotEmpty().Must(cpf => Regex.Replace(cpf, "[^0-9]", "").Length == 11).WithMessage("Campo obrigatório.")
                                .MaximumLength(20).WithMessage("O CPF deve ter até {MaxLength} caracteres.")
                                .Must(cpf => !context.Pacientes.Any(p => p.CPF == Regex.Replace(cpf, "[^0-9]", ""))).WithMessage("Este CPF já está em uso.");

            RuleFor(x => x.Nome).NotEmpty().WithMessage("Campo obrigatório.")
                                .MaximumLength(200).WithMessage("O Nome deve ter até {MaxLength} caracteres.");

            RuleFor(x => x.DataNascimento).NotEmpty().WithMessage("Campo obrigatório.")
                                .Must(data => data <= DateTime.Today).WithMessage("A data de nascimento não pode ser futura.");
        }
    }
}
