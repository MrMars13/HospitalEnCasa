using System;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>SignoVital</c>
    /// Modela los signos vitales del Paciente
    /// </summary>
    public class SignoVital
    {
        // Identificador único de cada signo vital
        public int Id { get; set; }
        /// <summary>
        /// Fecha y hora en que se realizó la toma del signo vital
        /// </summary>
        public DateTime FechaHora  { get; set; }
         /// <summary>
         /// Valor numérico del sifno vital
         /// </summary>
        public float Valor {get;set;}
        /// <summary>
        /// Tipo de Signo vital medido
        /// </summary>
        public TipoSigno Signo { get; set; }
    }
}