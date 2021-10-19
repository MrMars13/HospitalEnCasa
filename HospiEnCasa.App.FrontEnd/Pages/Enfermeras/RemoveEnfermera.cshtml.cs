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
    public class RemoveEnfermeraModel : PageModel
    {
        private readonly IRepositorioEnfermera repositorioEnfermera;
        public Enfermera Enfermera { get; set; }
        public RemoveEnfermeraModel(IRepositorioEnfermera repositorioEnfermera)
        {
            this.repositorioEnfermera = repositorioEnfermera;
        }
        public void OnGet(int Id)
        {
            Enfermera = repositorioEnfermera.GetEnfermera(Id);
        }
        public IActionResult OnPost(Enfermera Enfermera)
        {
            try
            {
                repositorioEnfermera.DeleteEnfermera(Enfermera.Id);
                return RedirectToPage("./ListEnfermeras");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
