namespace EscuelaNet.Entidades
{
    class Docente : Persona
    {
       public int Id { get; set; }
       public int NumeroDeEmpleado { get; set; }
       public string Rfc { get; set; }
       public string Departamento { get; set; }
    }
}