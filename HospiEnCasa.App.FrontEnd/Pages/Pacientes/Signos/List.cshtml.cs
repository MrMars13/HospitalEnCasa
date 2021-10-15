using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.FrontEnd.Pages.Pacientes.Signos
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        [BindProperty]
        public Paciente Paciente { get; set; }
        public IEnumerable<SignoVital> SignosPaciente { get; set; }
        public ListModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }

        public void OnGet(int? pacienteId)
        {
            if (pacienteId.HasValue)
            {
                Paciente = repositorioPaciente.GetPaciente(pacienteId.Value);
            }
            if (Paciente == null)
            {
                RedirectToPage("./NotFound");
            }
            else
            {
                SignosPaciente = repositorioPaciente.GetSignosPaciente(pacienteId.Value);
            }
        }
    }
}
