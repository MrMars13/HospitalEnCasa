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
    public class RemoveMedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public Medico Medico { get; set; }
        public RemoveMedicoModel(IRepositorioMedico repositorioMedico)
        {
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet(int Id)
        {
            Medico = repositorioMedico.GetMedico(Id);
        }
        public IActionResult OnPost(Medico Medico)
        {
            try
            {
                repositorioMedico.DeleteMedico(Medico.Id);
                return RedirectToPage("./ListMedico");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
