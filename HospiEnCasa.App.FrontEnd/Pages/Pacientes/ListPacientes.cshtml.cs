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
    // NO olvidar colocar el repositorio en el STRARTUP!
    public class ListPacientesModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public IEnumerable<Paciente> Pacientes;
        public ListPacientesModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }
        public void OnGet()
        {
            try
            {
                Pacientes = repositorioPaciente.GetAllPacientes();
            }
            catch
            {
                RedirectToPage("../Error");
            }
        }
    }
}
