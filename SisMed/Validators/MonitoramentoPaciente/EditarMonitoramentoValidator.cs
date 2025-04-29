using FluentValidation;
using SisMed.ViewModels.Medicos;
using SisMed.ViewModels.MonitoramentoPaciente;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SisMed.Validators.MonitoramentoPaciente
{
    public class EditarMonitoramentoValidator : AbstractValidator<EditarMonitoramentoViewModel>
    {
        public EditarMonitoramentoValidator()
        {
            RuleFor(x => x.PressaoArterial).NotEmpty().WithMessage("Campo obrigatório");

            RuleFor(x => x.SaturacaoOxigenio).NotEmpty().WithMessage("Campo obrigatório")
                    .Must(saturacao => saturacao >= 0 && saturacao <= 100).WithMessage("A saturação de oxigênio deve estar entre 0 e 100%");

            RuleFor(x => x.Temperatura).NotEmpty().WithMessage("Campo obrigatório")
                    .Must(temperatura => temperatura > 0).WithMessage("A temperatura deve ser maior que zero.");

            RuleFor(x => x.FrequenciaCardiaca).NotEmpty().WithMessage("Campo obrigatório")
                    .Must(frequencia => frequencia >= 0).WithMessage("A frequencia cardiaca deve ser maior ou igual a zero.");

            RuleFor(x => x.DataAfericao).NotEmpty().WithMessage("Campo obrigatório")
                    .Must(data => data <= DateTime.Now).WithMessage("A data de aferição não pode ser futura.");
        }
    }
}
