namespace EscuelaNet.Entidades
{
    abstract class Persona
    {
       public string Nombre { get; set; }
       public string Apellidos { get; set; }
       public string Telefono { get; set; }
       public string CorreoElectronicoPersonal { get; set; }
       public string CorreoElectronicoInstitucional { get; set; }

       public string NombreCompleto()
       { return $"{Nombre} {Apellidos}"; } 
    }
}