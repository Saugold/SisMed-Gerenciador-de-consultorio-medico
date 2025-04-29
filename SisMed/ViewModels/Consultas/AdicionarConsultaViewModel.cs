using SisMed.Models.Enumns;
using System.ComponentModel.DataAnnotations;

namespace SisMed.ViewModels.Consultas
{
    public class AdicionarConsultaViewModel
    {
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public TipoConsulta Tipo { get; set; }
        [Display(Name = "Paciente")]
        public int IdPaciente { get; set; }
        [Display(Name = "Médico")]
        public int IdMedico { get; set; }
    }
}
