using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente que esta en atencion hospitalaria
    /// </summary>
    public class Paciente : Persona
    {
        public string Direccion { get; set; }
        /// <summary>
        /// Coordenada de la dirección del Paciente
        /// </summary>
        public float Latitud { get; set; }
        /// <summary>
        /// Coordenada de la dirección del Paciente
        /// </summary>
        public float Longitud { get; set; }
        // Ciudad de residencia del Paciente
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// Relacion entre Paciente y su FamiliarDesignado para cuidarlo
        /// </summary>
        public FamiliarDesignado Familiar { get; set; }
        /// <summary>
        /// Relacion entre Paciente y la  Enfermera asignada
        /// </summary>
        public Enfermera Enfermera { get; set; }
        /// <summary>
        /// Relacion entre Paciente y el Medico que lo atiende
        /// </summary>
        public Medico Medico { get; set; }
        /// <summary>
        /// Relacion entre Paciente y su Historia clínica
        /// </summary>
        public Historia Historia { get; set; }
        /// <summary>
        ///  Referencia a la lista de signos vitales de un Paciente
        /// </summary>
        public List<SignoVital> SignosVitales { get; set; }
    }
}
