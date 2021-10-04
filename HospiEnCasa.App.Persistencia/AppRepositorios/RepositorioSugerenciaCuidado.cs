using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
    {
        private readonly AppContext _appContext;
        public RepositorioSugerenciaCuidado(AppContext appContext)
        {
            _appContext = appContext;
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoAdicionado = _appContext.SugerenciasCuidado.Add(sugerenciaCuidado);
            _appContext.SaveChanges();
            return sugerenciaCuidadoAdicionado.Entity;
        }

        void IRepositorioSugerenciaCuidado.DeleteSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado = _appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == idSugerenciaCuidado);
            if (sugerenciaCuidadoEncontrado == null)
                return;
            _appContext.SugerenciasCuidado.Remove(sugerenciaCuidadoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<SugerenciaCuidado> IRepositorioSugerenciaCuidado.GetAllSugerenciasCuidado()
        {
            return _appContext.SugerenciasCuidado;
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.GetSugerenciaCuidado(int idSugerenciaCuidado)
        {
            return _appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == idSugerenciaCuidado);
        }

        SugerenciaCuidado IRepositorioSugerenciaCuidado.UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrado = _appContext.SugerenciasCuidado.FirstOrDefault(p => p.Id == sugerenciaCuidado.Id);
            if (sugerenciaCuidadoEncontrado != null)
            {
                sugerenciaCuidadoEncontrado.FechaHora = sugerenciaCuidado.FechaHora;
                sugerenciaCuidadoEncontrado.Descripcion = sugerenciaCuidado.Descripcion;

                _appContext.SaveChanges();
            }
            return sugerenciaCuidadoEncontrado;
        }
    }
}