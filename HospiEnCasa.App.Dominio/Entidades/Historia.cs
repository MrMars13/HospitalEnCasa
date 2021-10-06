
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Historia</c>
    /// Modela la Historia clínica relacionada cpon el cuidado en casa del Paciente
    /// </summary>
    public class Historia
    {
        // Identificador único de la Historia
        public int Id { get; set; }
        /// <summary>
        /// Descripcion detallada del diagnostico del Paciente
        /// </summary>
        public string Diagnostico  { get; set; }
         /// <summary>
         /// Descripción de la casa y habitación del Paciente
         /// </summary>
        public string Entorno { get; set; }
        /// <summary>
        /// Referencia la lista de sugerencias registradas en la Historia del Paciente
        /// </summary>
        public List<SugerenciaCuidado> Sugerencias { get; set; }
    }
}