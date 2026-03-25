public class Curso
{
    private Dictionary<int, Alumno> DicAlumnos;

    public Curso()
    {
        DicAlumnos = new Dictionary<int, Alumno>();
    }
    public bool AgregarAlumno(int DNI, string nombre)
    {
        bool enDiccionario = DicAlumnos.ContainsKey(DNI);
        if(!enDiccionario)
        {
            Alumno alumno = new Alumno(DNI, nombre);
            DicAlumnos.Add(DNI, alumno);
            return true;    // Se pudo agregar
        }
        return false;
    }
    public Alumno BuscarAlumno(int DNI)
    {
        bool enDiccionario = DicAlumnos.ContainsKey(DNI);
        if(enDiccionario)
            return DicAlumnos[DNI];
        else
            return null;
    }
    public Dictionary<int, Alumno> DevDicAlumnos()
    {
        return DicAlumnos;
    }
    public List<Alumno> ListaAlumnosLibre()
    {
        List<Alumno> alumnosLibres = new List<Alumno>();
        foreach(Alumno alumno in DicAlumnos.Values)
        {
            if(alumno.EstaLibre())
                alumnosLibres.Add(alumno);
        }
        return alumnosLibres;
    }

}