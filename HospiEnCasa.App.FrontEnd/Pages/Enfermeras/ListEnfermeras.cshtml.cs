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
    public class ListEnfermerasModel : PageModel
    {
        private readonly IRepositorioEnfermera repositorioEnfermera;
        public IEnumerable<Enfermera> enfermeras;
        public ListEnfermerasModel(IRepositorioEnfermera repositorioEnfermera)
        {
            this.repositorioEnfermera = repositorioEnfermera;
        }
        public void OnGet()
        {
            enfermeras = repositorioEnfermera.GetAllEnfermeras();
        }
    }
}
