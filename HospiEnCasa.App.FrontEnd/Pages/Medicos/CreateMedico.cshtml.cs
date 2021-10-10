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
    public class CreateMedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public Medico MedicoNuevo { get; set; }
        public CreateMedicoModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet()
        {
            MedicoNuevo = new Medico();
        }
        public IActionResult OnPost(Medico MedicoNuevo)
        {
            try
            {
                repositorioMedico.AddMedico(MedicoNuevo);
                return RedirectToPage("./ListMedico");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
