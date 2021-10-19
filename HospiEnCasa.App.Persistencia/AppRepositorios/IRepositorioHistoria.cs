using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistoria();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        void DeleteHistoria(int idhistoria);
        Historia GetHistoria(int idhistoria);
        SugerenciaCuidado AsignarSugerenciaCuidado(int idhistoria, int idsugerenciaCuidado);
        IEnumerable<Historia> HistoriaPorPaciente(Paciente paciente);
    }
}