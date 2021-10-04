using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly AppContext _appContext;
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }
        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
            var historiaAdicionado = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }

        SugerenciaCuidado IRepositorioHistoria.AsignarSugerenciaCuidado(int idhistoria, int idsugerenciaCuidado)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(p => p.Id == idhistoria);
            if (historiaEncontrado != null)
            {
                var sugerenciaCuidadoEncontrado = _appContext.SugerenciasCuidado.FirstOrDefault(m => m.Id == idsugerenciaCuidado);
                if (sugerenciaCuidadoEncontrado != null)
                {
                    historiaEncontrado.Sugerencias.Add(sugerenciaCuidadoEncontrado);
                    _appContext.SaveChanges();
                }
                return sugerenciaCuidadoEncontrado;
            }
            return null;
        }

        void IRepositorioHistoria.DeleteHistoria(int idhistoria)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(p => p.Id == idhistoria);
            if (historiaEncontrado == null)
                return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Historia> IRepositorioHistoria.GetAllHistoria()
        {
            return _appContext.Historias;
        }

        Historia IRepositorioHistoria.GetHistoria(int idhistoria)
        {
            return _appContext.Historias.FirstOrDefault(p => p.Id == idhistoria);
        }

        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(p => p.Id == historia.Id);
            if (historiaEncontrado != null)
            {
                historiaEncontrado.Diagnostico = historia.Diagnostico;
                historiaEncontrado.Entorno = historia.Entorno;
                historiaEncontrado.Sugerencias.Clear(); // TODO, decir que se debe asignar nuevamente las sugerencias, ya que se eliminarn
                //historiaEncontrado.Sugerencias = historia.Sugerencias; //TODO terminar y hacer build

                _appContext.SaveChanges();
            }
            return historiaEncontrado;
        }
    }
}