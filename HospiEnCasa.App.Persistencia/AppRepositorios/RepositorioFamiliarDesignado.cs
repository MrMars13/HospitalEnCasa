using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliarDesignado : IRepositorioFamiliarDesignado
    {
        private readonly AppContext _appContext;
        public RepositorioFamiliarDesignado(AppContext appContext)
        {
            _appContext = appContext;
        }


        FamiliarDesignado IRepositorioFamiliarDesignado.AddFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarDesignadoAdicionado = _appContext.FamiliaresDesignados.Add(familiarDesignado);
            _appContext.SaveChanges();
            return familiarDesignadoAdicionado.Entity;
        }

        void IRepositorioFamiliarDesignado.DeleteFamiliarDesignado(int idFamiliarDesignado)
        {
            var familiarDesignadoEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
            if (familiarDesignadoEncontrado == null) 
                return; 
            _appContext.FamiliaresDesignados.Remove(familiarDesignadoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<FamiliarDesignado> IRepositorioFamiliarDesignado.GetAllFamiliaresDesignados()
        {
            return _appContext.FamiliaresDesignados;
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.GetFamiliarDesignado(int idFamiliarDesignado)
        {
            return _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == idFamiliarDesignado);
        }

        FamiliarDesignado IRepositorioFamiliarDesignado.UpdateFamiliarDesignado(FamiliarDesignado familiarDesignado)
        {
            var familiarDesignadoEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(p => p.Id == familiarDesignado.Id);
            if (familiarDesignadoEncontrado != null)
            {
                familiarDesignadoEncontrado.Nombre = familiarDesignado.Nombre;
                familiarDesignadoEncontrado.Apellidos = familiarDesignado.Apellidos;
                familiarDesignadoEncontrado.NumeroTelefono = familiarDesignado.NumeroTelefono;
                familiarDesignadoEncontrado.Genero = familiarDesignado.Genero;
                familiarDesignadoEncontrado.Parentesco = familiarDesignado.Parentesco;
                familiarDesignadoEncontrado.Correo = familiarDesignado.Correo;
                
                _appContext.SaveChanges();             
            }
            return familiarDesignadoEncontrado;
        }
    }
}