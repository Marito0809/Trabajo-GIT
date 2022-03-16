namespace EscuelaNet.Entidades
{
    class Calificacion
    {

        public Calificacion(Grupo grupo,Docente docente,Alumno alumno, Asignatura asignatura)
       {
       Grupo = grupo;
       Docente = docente;
       Alumno = alumno;
       Asignatura = asignatura;
       }
       public int Id { get; set; }
       public Grupo Grupo { get; set; }
       public Docente Docente { get; set; }
       public Alumno Alumno { get; set; }
       public Asignatura Asignatura { get; set; }
       public int Inacistencias { get; set; }
       public float PrimerParcial { get; set; }
       public float SegundoParcial { get; set; }
       public float TercerParcial { get; set; }
       public float Promedio { get { return (PrimerParcial + SegundoParcial +  TercerParcial) / 3;} }
       public float Ordinario { get; set; }
       public float Final { get { return (Promedio + Ordinario) / 2; } }


       public override string ToString()
       {
           return $@"
           Grupo:{Grupo.Nombre}, Docente:{Docente.NombreCompleto()} 
           Alumno:{Alumno.NombreCompleto()}, Asignatura:{Asignatura.Nombre}
           Faltas:{Inacistencias}, P1:{PrimerParcial}, P2:{SegundoParcial}, P3:{TercerParcial}
           Promedio:{Promedio}, Ordinario:{Ordinario}, Final:{Final}";
       }
    }
}