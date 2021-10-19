using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.FrontEnd.Pages
{
    public class CreatePacienteModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente PacienteNuevo { get; set; }
        public CreatePacienteModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }
        public void OnGet()
        {
            PacienteNuevo = new Paciente();
        }
        public IActionResult OnPost(Paciente PacienteNuevo)
        {
            try
            {
                repositorioPaciente.AddPaciente(PacienteNuevo);
                return RedirectToPage("./ListPacientes");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
