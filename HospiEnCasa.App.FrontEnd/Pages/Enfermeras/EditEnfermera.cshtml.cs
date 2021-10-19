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
    public class EditEnfermeraModel : PageModel
    {
        private readonly IRepositorioEnfermera repositorioEnfermera;
        public Enfermera Enfermera { get; set; }
        public EditEnfermeraModel(IRepositorioEnfermera repositorioEnfermera)
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
                repositorioEnfermera.UpdateEnfermera(Enfermera);
                return RedirectToPage("./ListEnfermeras");
            }
            catch
            {
                return RedirectToPage("../Error");
            }
        }
    }
}
