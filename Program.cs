using System;
using System.Linq;
using System.Collections.Generic;
using EscuelaNet.Entidades;

namespace EscuelaNet
{
    class Program
    {
        static Escuela escuela { get; set; } = new Escuela();
        static List<Carrera> ListaDeCarreras { get; set; } = new List<Carrera>();
        static List<Asignatura> ListaDeAsignaturas { get; set; } = new List<Asignatura>();
        static List<Alumno> ListaDeAlumnos { get; set; } = new List<Alumno>();
        static List<Docente> ListaDeDocente { get; set; } = new List<Docente>();
        static List<Grupo> ListaDeGrupo { get; set; } = new List<Grupo>();
        static List<Calificacion> ListaDeCalificaciones { get; set;} = new List<Calificacion>(); 
        static void Main(string[] args)
        {
            InicilizarProyecto();
            //ImprimirAlumnosPorMaetria();
            //ImprimirMateriasDeUnAlumno("15030198");
            //ImprimirCalificacionesPorGrupoAsignatura("01LSC","Desarrollo Web II");
            //ImprimirCalificacionesPorAlumno("19030098");
            ImprimirElResultadoDeLaComparcionDeDosAlumnos();
        }
        private static void ImprimirElResultadoDeLaComparcionDeDosAlumnos()
        {
            Console.WriteLine(ListaDeAlumnos[0].Equals(ListaDeAlumnos[1]));
            Console.WriteLine(ListaDeAlumnos[1].Equals(ListaDeAlumnos[2]));
            Console.WriteLine(ListaDeAlumnos[2].Equals(ListaDeAlumnos[3]));
            Console.WriteLine(ListaDeAlumnos[0].Equals(ListaDeAlumnos[3]));
        }
        private static void ImprimirCalificacionesPorAlumno(string matricula)
        {
            var Calificaciones = ListaDeCalificaciones.Where(c => c.Alumno.Matricula==matricula).ToList();
            try
            {
                System.Console.WriteLine($"Alumno: {Calificaciones[0].Alumno.NombreCompleto()}");
            foreach (var Cal in Calificaciones)
            {
                System.Console.WriteLine($"Asignatura: {Cal.Asignatura.Nombre}");    
                System.Console.WriteLine($"     P1:{Cal.PrimerParcial} P2:{Cal.SegundoParcial} P3{Cal.TercerParcial}" +
                $"PROM:{Cal.Promedio} ORD:{Cal.Ordinario} FINAL:{Cal.Final}");
            }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                System.Console.WriteLine($"No se encontraron los alumnos con la matricula: {matricula}");
            }
        }
        private static void ImprimirCalificacionesPorGrupoAsignatura(string grupo, string asignatura)
        {
            var Calificaciones = ListaDeCalificaciones.Where(c => c.Grupo.Nombre == grupo && c.Asignatura.Nombre == asignatura).ToList();
            if (Calificaciones.Count > 0)
            {
             System.Console.WriteLine($"Grupo: {grupo}, Asignatura: {asignatura}");
             foreach (var cal in Calificaciones)
             {
                System.Console.WriteLine($"Alumno: {cal.Alumno.NombreCompleto()}, " +
                $"P1: {cal.PrimerParcial}, P2: {cal.SegundoParcial}, P3: {cal.TercerParcial}");
             }
            }
            else
            {
                System.Console.WriteLine($"No se encontro registro del grupo:{grupo} y la asignatura:{asignatura}");
            }
        }
        private static void ImprimirMateriasDeUnAlumno(string matricula)
        {
            var Calificaciones = ListaDeCalificaciones.Where(c => c.Alumno.Matricula==matricula).ToList();
            foreach (var Calificacion in Calificaciones)
            {
                System.Console.WriteLine($"Alumno: {Calificacion.Alumno.NombreCompleto()},  Asignatura: {Calificacion.Asignatura.Nombre}");    
            }
        }
        private static void ImprimirAlumnosPorMaetria()
        {
            foreach (var Calificacion in ListaDeCalificaciones)
            {
                Console.WriteLine($"Asignatura: {Calificacion.Asignatura.Nombre}, Alumno: {Calificacion.Alumno.NombreCompleto()}");
            }
        }
        private static void InicilizarProyecto()
        {
            CrearEscuela();
            CrearCarreras();
            CrearAsignaturas();
            CrearAlumnos();
            CrearDocentes();
            CrearGrupos();
            CrearCalificaciones();
        }
        private static void CrearCalificaciones()
        {
             ListaDeCalificaciones.Add(new Calificacion(ListaDeGrupo[0],ListaDeDocente[0],ListaDeAlumnos[0],ListaDeAsignaturas[0])
            {
                Inacistencias = 2,
                PrimerParcial = 8.2f,
                SegundoParcial = 9.4f,
                TercerParcial = 10.0f,
                Ordinario = 9.6f
            });
            ListaDeGrupo[0].Calificacion.Add(ListaDeCalificaciones[0]);
            ListaDeCalificaciones.Add(new Calificacion(ListaDeGrupo[0],ListaDeDocente[1],ListaDeAlumnos[0],ListaDeAsignaturas[1])
            {
                Inacistencias = 2,
                PrimerParcial = 8.2f,
                SegundoParcial = 9.4f,
                TercerParcial = 10.0f,
                Ordinario = 9.6f
            });
            ListaDeGrupo[0].Calificacion.Add(ListaDeCalificaciones[0]);
            ListaDeCalificaciones.Add(new Calificacion(ListaDeGrupo[1],ListaDeDocente[1],ListaDeAlumnos[1],ListaDeAsignaturas[1])
            {
                Inacistencias = 3,
                PrimerParcial = 9.2f,
                SegundoParcial = 7.4f,
                TercerParcial = 8f,
                Ordinario = 8.6f
            });
            ListaDeGrupo[1].Calificacion.Add(ListaDeCalificaciones[2]);

            ListaDeCalificaciones.Add(new Calificacion(ListaDeGrupo[0],ListaDeDocente[2],ListaDeAlumnos[2],ListaDeAsignaturas[2])
            {
                Inacistencias = 2,
                PrimerParcial = 9.6f,
                SegundoParcial = 8.4f,
                TercerParcial = 9f,
                Ordinario = 8.9f
            });
            ListaDeGrupo[0].Calificacion.Add(ListaDeCalificaciones[3]);

            ListaDeCalificaciones.Add(new Calificacion(ListaDeGrupo[0],ListaDeDocente[3],ListaDeAlumnos[2],ListaDeAsignaturas[3])
            {
                Inacistencias = 1,
                PrimerParcial = 7.6f,
                SegundoParcial = 9.4f,
                TercerParcial = 10f,
                Ordinario = 7.9f
            });
            ListaDeGrupo[0].Calificacion.Add(ListaDeCalificaciones[4]);

            ListaDeCalificaciones.Add(new Calificacion(ListaDeGrupo[0],ListaDeDocente[2],ListaDeAlumnos[3],ListaDeAsignaturas[2])
            {
                Inacistencias = 1,
                PrimerParcial = 9.6f,
                SegundoParcial = 9.4f,
                TercerParcial = 9.7f,
                Ordinario = 10f
            });
            ListaDeGrupo[0].Calificacion.Add(ListaDeCalificaciones[3]);

            ListaDeCalificaciones.Add(new Calificacion(ListaDeGrupo[0],ListaDeDocente[3],ListaDeAlumnos[3],ListaDeAsignaturas[3])
            {
                Inacistencias = 2,
                PrimerParcial = 8.6f,
                SegundoParcial = 8.4f,
                TercerParcial = 9f,
                Ordinario = 9.2f
            });
            ListaDeGrupo[0].Calificacion.Add(ListaDeCalificaciones[4]);
        }

        static void CrearEscuela()
        {
            escuela.Nombre = "Universidad Autonoma de Occidente";
            escuela.Domicilio = "Blvd Universitario SN";
            escuela.UnidadRgional = "Guasave";
            escuela.Director = "Carlos Manuel Lopez Reyes";
            escuela.CorreoElectronico = "guasave@uadeo.mx";
            escuela.SitioWebOficial = "https://uadeo.mx/guasave";
        } 

        private static void CrearGrupos()
        {
            ListaDeGrupo.Add(new Grupo
            {
                Nombre = "01LSC5M",
                Turno = Turno.Matutino,
                Semestre = 5,
                Carrera = ListaDeCarreras[0],
                Periodo = "Agosto 2021 - Enero 2022"
            });
            ListaDeGrupo.Add(new Grupo
            {
                Nombre = "01ISF1M",
                Turno = Turno.Matutino,
                Semestre = 5,
                Carrera = ListaDeCarreras[1],
                Periodo = "Agosto 2021 - Enero 2022"
            });
        }

        private static void CrearDocentes()
        {
            ListaDeDocente.Add(new Docente
            {
                Nombre = "Jose Luis",
                Apellidos = "Gaxiola Castro",
                Telefono = "1234567890",
                CorreoElectronicoPersonal = "joseluis.gaxiola@personal.com",
                CorreoElectronicoInstitucional = "jose.gaxiola@uadeo.mx",
                NumeroDeEmpleado = 1234,
                Rfc = "JLGC010203XYZ",
                Departamento = "Ciencia economica-administrativas"
            });
            ListaDeDocente.Add(new Docente
            {
                Nombre = "Francisco Javier",
                Apellidos = "totoo",
                Telefono = "1234567890",
                CorreoElectronicoPersonal = "fco.totoo@personal.com",
                CorreoElectronicoInstitucional = "fco.totoo@uadeo.mx",
                NumeroDeEmpleado = 1234,
                Rfc = "FCOC010203XYZ",
                Departamento = "Ingeneria y Tecnologia"
            });
            ListaDeDocente.Add(new Docente
            {
                Nombre = "Juan Carlos",
                Apellidos = "Lopez Jimenez",
                Telefono = "1234567890",
                CorreoElectronicoPersonal = "juan.lopez@personal.com",
                CorreoElectronicoInstitucional = "juan.lopez@uadeo.mx",
                NumeroDeEmpleado = 1234,
                Rfc = "JCLJ010203XYZ",
                Departamento = "Ingeneria y Tecnologia"
            });
            ListaDeDocente.Add(new Docente
            {
                Nombre = "Juan Francisco",
                Apellidos = "Urias Gutierrez",
                Telefono = "1234567890",
                CorreoElectronicoPersonal = "juan.urias@personal.com",
                CorreoElectronicoInstitucional = "juan.urias@uadeo.mx",
                NumeroDeEmpleado = 1234,
                Rfc = "JFUG010203XYZ",
                Departamento = "Ingeneria y Tecnologia"
            });
        }

        private static void CrearAlumnos()
        {
            var Armando = new Alumno
            {
                Nombre = "Jose Armando",
                Apellidos = "huicho llanes",
                Matricula = "19030098",
                Curp = "AOGM010908HSLCNRA4",
                Carrera = ListaDeCarreras[1]
            };
            var JoseLuis = new Alumno
            {
                Nombre = "Jose Luis",
                Apellidos = "Gaxiola Lopez",
                Matricula = "19031058",
                Carrera = ListaDeCarreras[0]
            };
            var Jazmin = new Alumno
            {
                Nombre = "Jazmin Guadalupe",
                Apellidos = "Hernandez Rodriguez",
                Matricula = "19030545",
                Carrera = ListaDeCarreras[0]
            };
            var Mario = new Alumno
            {
                Nombre = "Mario Daniel",
                Apellidos = "Acosta Gonzalez",
                Matricula = "19030098",
                Edad = 20,
                Curp = "AOGM010908HSLCNRA4",
                Telefono = "6871538457",
                Beca = TipoBeca.Sindical,
                Carrera = ListaDeCarreras[0],   
                CorreoElectronicoPersonal = "marito12252@gmail.com",
                CorreoElectronicoInstitucional = "19030098@uadeo.mx"
            };
            ListaDeAlumnos.Add(Mario);
            ListaDeAlumnos.Add(Armando);
            ListaDeAlumnos.Add(JoseLuis);
            ListaDeAlumnos.Add(Jazmin);
        }

        private static void CrearAsignaturas()
        {
            ListaDeAsignaturas.Add(new Asignatura
            {
                Nombre = "Desarrollo Web II",
                Descripcion = "ASP.Net",
                Horas = 4.5f,
                Semestre = 5,
                Seriada = true,
                Carrera = ListaDeCarreras[0]
            });
            ListaDeAsignaturas.Add(new Asignatura
            {
                Nombre = "Programcion Basica",
                Descripcion = "C++",
                Horas = 4.5f,
                Semestre = 1,
                Seriada = false,
                Carrera = ListaDeCarreras[1]
            });
            ListaDeAsignaturas.Add(new Asignatura
            {
                Nombre = "Sistemas operativos II",
                Descripcion = "Linux",
                Horas = 3f,
                Semestre = 5,
                Seriada = true,
                Carrera = ListaDeCarreras[0]
            });
            ListaDeAsignaturas.Add(new Asignatura
            {
                Nombre = "Desarrollo de Aplicaciones Moviles",
                Descripcion = "Android",
                Horas = 4.5f,
                Semestre = 5,
                Seriada = true,
                Carrera = ListaDeCarreras[0]
            });
        }

        private static void CrearCarreras()
        {
            var carrera2 = new Carrera
            {
                Nombre="Ingeneria de Software",
                Descripcion="Ing. se soft.",
                Grado=Grado.Ingeneria,
                PlanDeEstudios=2020
            };
            Carrera carrera = new Carrera()
            {
                Nombre = "Sistemas Computacional",
                Grado = Grado.Licenciatura,
                Descripcion = "Carrera de programacion",
                PlanDeEstudios = 2019
            };
            ListaDeCarreras.Add(carrera);
            ListaDeCarreras.Add(carrera2);
        }
    }
}
