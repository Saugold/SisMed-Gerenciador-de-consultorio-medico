using FluentValidation;
using SisMed.Models.Contexts;
using SisMed.ViewModels.Pacientes;
using System.Text.RegularExpressions;

namespace SisMed.Validators.Pacientes
{
    public class EditarPacienteValidator : AbstractValidator<EditarPacienteViewModel>
    {
        public EditarPacienteValidator(SisMedContext context)
        {
            RuleFor(x => x.CPF).NotEmpty().Must(cpf => Regex.Replace(cpf, "[^0-9]", "").Length == 11).WithMessage("Campo obrigatório.")
                                .MaximumLength(20).WithMessage("O CPF deve ter até {MaxLength} caracteres.")
                                .Must(cpf => !context.Pacientes.Any(p => p.CPF == cpf)).WithMessage("Este CPF já está em uso.");

            RuleFor(x => x.Nome).NotEmpty().WithMessage("Campo obrigatório.")
                                .MaximumLength(200).WithMessage("O Nome deve ter até {MaxLength} caracteres.");

            RuleFor(x => x.DataNascimento).NotEmpty().WithMessage("Campo obrigatório.")
                                .Must(data => data <= DateTime.Today).WithMessage("A data de nascimento não pode ser futura.");

            RuleFor(x => x).Must(x => !context.Pacientes.Any(paciente => paciente.CPF == Regex.Replace(x.CPF, "[^0-9]", "") && paciente.Id != x.Id)).WithMessage("Este CPF já esta cadastrado!!!");
        }
    }
}
