namespace EscuelaNet.Entidades
{
    class Asignatura
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public string Descripcion { get; set; }
       public float Horas { get; set; }
       public int Semestre { get; set; }
       public bool Seriada { get; set; }
       public Carrera Carrera { get; set; }
    }
}