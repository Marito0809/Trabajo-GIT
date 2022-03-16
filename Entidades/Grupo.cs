using System.Collections.Generic;
namespace EscuelaNet.Entidades
{
    class Grupo
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public Turno Turno { get; set; }
       public int Semestre { get; set; }
       public Carrera Carrera { get; set; }
       public string Periodo { get; set; }
       public Escuela Escuela { get; set; }
       public List<Calificacion> Calificacion { get; set; } = new List<Calificacion>();
    }

    enum Turno
    {
        Matutino, Vespertino
    }
}