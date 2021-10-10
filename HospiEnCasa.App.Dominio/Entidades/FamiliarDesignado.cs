namespace HospiEnCasa.App.Dominio
{
    // Modela al familiar asignado para cuidar al paciente
    public class FamiliarDesignado : Persona
    {
        public string Parentesco { get; set; }
        // Dirección de correo electrónico del FamiliarDesignado
        public string Correo { get; set; }
    }
}
