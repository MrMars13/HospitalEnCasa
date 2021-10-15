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
    public class DetailPacienteModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        public Paciente Paciente { get; set; }
        public DetailPacienteModel(IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }

        public void OnGet(int Id)
        {
            Paciente = repositorioPaciente.GetPaciente(Id);
        }
    }
}
