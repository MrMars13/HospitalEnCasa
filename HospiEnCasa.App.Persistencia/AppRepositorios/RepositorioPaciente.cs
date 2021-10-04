using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;

        /// <summary>
        /// Método Constructor Utiliza
        /// Inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>
        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        // El add, además de agregar al paciente, retonra lo que agrego por eso se debe retornar.

        Enfermera IRepositorioPaciente.AsignarEnfermera(int idPaciente, int idEnfermera)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var enfermeraEncontrado = _appContext.Enfermeras.FirstOrDefault(e => e.Id == idEnfermera);
                if (enfermeraEncontrado != null)
                {
                    pacienteEncontrado.Enfermera = enfermeraEncontrado;
                    _appContext.SaveChanges();
                }
                return enfermeraEncontrado;
            }
            return null;
        }
        FamiliarDesignado IRepositorioPaciente.AsignarFamiliarDesignado(int idPaciente, int idFamiliarDesignado)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var familiarEncontrado = _appContext.FamiliaresDesignados.FirstOrDefault(f => f.Id == idFamiliarDesignado);
                if (familiarEncontrado != null)
                {
                    pacienteEncontrado.Familiar = familiarEncontrado;
                    _appContext.SaveChanges();
                }
                return familiarEncontrado;
            }
            return null;
        }
        Historia IRepositorioPaciente.AsignarHistoria(int idPaciente, int idHistoria)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var historiaEncontrado = _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
                if (historiaEncontrado != null)
                {
                    pacienteEncontrado.Historia = historiaEncontrado;
                    _appContext.SaveChanges();
                }
                return historiaEncontrado;
            }
            return null;
        }
        Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    pacienteEncontrado.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;
        }
        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;  // Retorna un null
            _appContext.Pacientes.Remove(pacienteEncontrado); // si encuentra al paciente, lo borra
            _appContext.SaveChanges();     //Siempre colocar el savechanges
        }
        // Busca en _appContext el primero que encuentre donde p(Paciente).Id sea igual al dado, se se cumple retorena el paciente, en caso contrario null.
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }
        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Familiar = paciente.Familiar;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Historia = paciente.Historia;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
    }
}
