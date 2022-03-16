namespace EscuelaNet.Entidades
{
    class Alumno : Persona
    {
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Alumno))
            {
                return false;
            }
             return (this.Matricula==((Alumno)obj).Matricula)
             && (this.Curp==((Alumno)obj).Curp);
            
        }
        public override int GetHashCode()
        {
            return Matricula.GetHashCode() ^ Curp.GetHashCode();
        }
       public int Id { get; set; }
       public string Matricula { get; set; }
       public int Edad { get; set; }
       public string Curp { get; set; }
       public TipoBeca Beca { get; set; }
       public Carrera Carrera { get; set; }
    }

    enum TipoBeca
    {
        Academia, Sindical, Federal, Estatal, Municipal
    }
}