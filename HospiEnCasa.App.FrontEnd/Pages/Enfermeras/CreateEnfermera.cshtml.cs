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
    public class CreateEnfermeraModel : PageModel
    {
        private readonly IRepositorioEnfermera repositorioEnfermera;
        public Enfermera EnfermeraNuevo { get; set; }
        public CreateEnfermeraModel(IRepositorioEnfermera repositorioEnfermera)
        {
            this.repositorioEnfermera = repositorioEnfermera;
        }
        public void OnGet()
        {
            EnfermeraNuevo = new Enfermera();
        }
        public IActionResult OnPost(Enfermera EnfermeraNuevo)
        {
            try
            {
                repositorioEnfermera.AddEnfermera(EnfermeraNuevo);
                return RedirectToPage("./ListEnfermeras");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
