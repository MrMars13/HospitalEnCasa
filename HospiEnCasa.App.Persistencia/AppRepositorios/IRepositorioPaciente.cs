using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        Medico AsignarMedico(int idPaciente, int idMedico);
        Enfermera AsignarEnfermera(int idPaciente, int idEnfermera);
        FamiliarDesignado AsignarFamiliarDesignado(int idPaciente, int idFamiliarDesignado);
        Historia AsignarHistoria(int idPaciente, int idHistoria);
        IEnumerable<Paciente> GetPacientesMasculinos();
        IEnumerable<Paciente> GetPacientesCorazon();
        IEnumerable<SignoVital> GetSignosPaciente(int idPaciente);
    }
}