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
    public class RemovePacienteModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente Paciente { get; set; }
        public RemovePacienteModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }
        public void OnGet(int Id)
        {
            Paciente = repositorioPaciente.GetPaciente(Id);
        }
        public IActionResult OnPost(Paciente Paciente)
        {
            try
            {
                repositorioPaciente.DeletePaciente(Paciente.Id);
                return RedirectToPage("./ListPacientes");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
