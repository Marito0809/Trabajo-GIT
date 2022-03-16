using System.Collections.Generic;
namespace EscuelaNet.Entidades
{
    class Carrera
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public Grado Grado { get; set; }
       public string Descripcion { get; set; }
       public int PlanDeEstudios { get; set; }//Año del plan
       public List<Escuela> Escuelas { get; set; } = new List<Escuela>();
       public List<Asignatura> Asignaturas { get; set; } = new List<Asignatura>();
    }
    
    enum Grado
    {
        Licenciatura, Ingeneria, Maestria, Doctorado
    }
}