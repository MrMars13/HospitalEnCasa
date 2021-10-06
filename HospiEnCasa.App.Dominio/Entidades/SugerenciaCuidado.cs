using System;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>SugerenciaCuidado</c>
    /// Modela las sugerencias de cuidado del Paciente
    /// </summary>
    public class SugerenciaCuidado
    {
        // Identificador único de cada SugerenciaCuidado
        public int Id { get; set; }
        /// <summary>
        /// Fecha y hora en que se escribe la sugerencia
        /// </summary>
        public DateTime FechaHora  { get; set; }
         /// <summary>
         /// Texto con la sugerencia
         /// </summary>
        public string Descripcion {get;set;}
    }
}