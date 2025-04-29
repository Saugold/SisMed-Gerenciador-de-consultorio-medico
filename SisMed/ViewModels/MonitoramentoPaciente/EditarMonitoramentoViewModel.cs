using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace SisMed.ViewModels.MonitoramentoPaciente
{
    public class EditarMonitoramentoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Pressão Arterial")]
        public string PressaoArterial { get; set; } = string.Empty;
        [Display(Name = "Temperatura")]
        public decimal Temperatura { get; set; }
        [Display(Name = "Saturação Oxigênio")]
        public int SaturacaoOxigenio { get; set; }
        [Display(Name = "Frequência Cardiaca")]
        public int FrequenciaCardiaca { get; set; }
        [Display(Name = "Data de Aferição")]
        public DateTime DataAfericao { get; set; }
    }
}
