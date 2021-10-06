
namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Medico</c>
    /// Modela un Medico del equipo medico de apoyo
    /// </summary>
    public class Medico : Persona
    {
        /// <summary>
        /// Nombre de la especialidad medica del Médico
        /// </summary>
        public string Especialidad { get; set; }
        /// <summary>
        /// Código único del médico
        /// </summary>
        public string Codigo { get; set; }
         /// <summary>
         /// Registro Unico Nacional del Talento Humano
         /// </summary>
        public string RegistroRethus { get; set; }
    }
}