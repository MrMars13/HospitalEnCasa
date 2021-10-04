using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());

        private static IRepositorioEnfermera _repoEnfermera = new RepositorioEnfermera(new Persistencia.AppContext());

        private static IRepositorioMedico _repoMedico = new RepositorioMedico(new Persistencia.AppContext());

        private static IRepositorioFamiliarDesignado _repoFamiliarDesignado = new RepositorioFamiliarDesignado(new Persistencia.AppContext());

        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!, I'm IN! ");
            //AsignarMedico();
            //AsignarEnfermera();
            //AsignarFamiliarDesignado();
            //AsignarHistoria();
            //CreatePaciente();
            //ReadPaciente(1);
            //UpdatePaciente(1);
            //DeletePaciente(1);
            //GetAllPacientes();
            //AddEnfermera();
            //AddMedico();
            //AddFamiliarDesignado();
            //AddHistoria();
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 3);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }

        private static void AsignarEnfermera()
        {
            var enfermera = _repoPaciente.AsignarEnfermera(1, 2);
            Console.WriteLine(enfermera.Nombre + " " + enfermera.Apellidos);
        }

        private static void AsignarFamiliarDesignado()
        {
            var familiar = _repoPaciente.AsignarFamiliarDesignado(1, 4);
            Console.WriteLine(familiar.Nombre + " " + familiar.Apellidos);
        }

        private static void AsignarHistoria()
        {
            var historia = _repoPaciente.AsignarHistoria(1, 1);
            Console.WriteLine("Historia No. " + historia.Id);
        }

        private static void CreatePaciente()
        {
            var paciente =
                new Paciente
                {
                    Nombre = "Nicolas",
                    Apellidos = "Perez",
                    NumeroTelefono = "300615",
                    Genero = Genero.Masculino,
                    Direccion = "Calle 4 No. 7-4",
                    Longitud = 5.07062F,
                    Latitud = -75.5229F,
                    Ciudad = "Manizales",
                    FechaNacimiento = new DateTime(1990, 04, 12)
                };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void ReadPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            if (paciente == null)
            {
                Console.WriteLine("Paciente no encontrado");
            }
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }

        private static void UpdatePaciente(int idPaciente)
        {
            var paciente =
                new Paciente
                {
                    Id = idPaciente,
                    Nombre = "Nicolay",
                    Apellidos = "Gonzales Jaramillo",
                    NumeroTelefono = "318-061-5142",
                    Genero = Genero.Masculino,
                    Direccion = "Calle 4 No. 7-4",
                    Longitud = 5.5462F,
                    Latitud = -71.5229F,
                    Ciudad = "Villa Maria",
                    FechaNacimiento = new DateTime(1990, 04, 12, 7, 30, 00),
                    //Familiar
                    //Enfermera
                    Medico = _repoPaciente.AsignarMedico(1, 3) // EL ID 3 cambia dependiendo del medico
                    //Historia
                    //SignosVitales
                };
            _repoPaciente.UpdatePaciente(paciente); //TODO terminar...
        }

        private static void DeletePaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
            Console.WriteLine("Paciente eliminado correctamente");
        }

        private static void GetAllPacientes()
        {
            var Paciente = _repoPaciente.GetAllPacientes();
            foreach (var paciente in Paciente)
            {
                Console.WriteLine(paciente.Nombre);
            }
        }

        private static void AddEnfermera()
        {
            var enfermera =
                new Enfermera
                {
                    Nombre = "Esperanza",
                    Apellidos = "Castro",
                    NumeroTelefono = "5002654",
                    Genero = Genero.Femenino,
                    TarjetaProfesional = "877-21657",
                    HorasLaborales = 68
                };
            _repoEnfermera.AddEnfermera(enfermera);
        }

        private static void AddMedico()
        {
            var medico =
                new Medico
                {
                    Nombre = "Juliana",
                    Apellidos = "Perez",
                    NumeroTelefono = "8002759",
                    Genero = Genero.Femenino,
                    Especialidad = "Cardiología",
                    Codigo = "14970",
                    RegistroRethus = "2014-0845ABT"
                };
            _repoMedico.AddMedico(medico);
        }

        private static void AddFamiliarDesignado()
        {
            var familiarDesignado =
                new FamiliarDesignado
                {
                    Nombre = "Mario",
                    Apellidos = "Mendez",
                    NumeroTelefono = "8997412",
                    Genero = Genero.Masculino,
                    Parentesco = "Sobrino",
                    Correo = "mario.mendez@correo.com"
                };
            _repoFamiliarDesignado.AddFamiliarDesignado(familiarDesignado);
        }

        private static void AddHistoria()
        {
            var historia =
                new Historia
                {
                    Diagnostico = "El paciente tiene pereza",
                    Entorno = "Entorno de pereza"
                };
            _repoHistoria.AddHistoria(historia);
        }
    }
}
