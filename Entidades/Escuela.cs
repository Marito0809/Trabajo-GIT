using System;
using System.Collections.Generic;
namespace EscuelaNet.Entidades
{
    class Escuela
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public string Domicilio { get; set; }
       public string UnidadRgional { get; set; }
       public string Director { get; set; }
       public string CorreoElectronico { get; set; }
       public string SitioWebOficial { get; set; }
       public List<Carrera> Carreras { get; set; } = new List<Carrera>();
    }
}