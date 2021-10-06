namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Enfermera</c>
    /// Modela una Persona del personal de enfermería del equipo medico de apoyo
    /// </summary>
    public class Enfermera : Persona
    {
        /// <summary>
        /// Numero único de la tarjeta profesional
        /// </summary>
        public string TarjetaProfesional { get; set; }
        /// <summary>
        /// Cantidad de horas laborales a la semana
        /// </summary>
        public int HorasLaborales { get; set; }
    }
}