public class Curso
{
    private List<Alumno> ListaAlumnos;

    public Curso()
    {
        ListaAlumnos = new List<Alumno>();
    }
    public bool AgregarAlumno(int DNI, string nombre)
    {
        if(BuscarAlumno(DNI) == null)
        {
            Alumno alumno = new Alumno(DNI, nombre);
            ListaAlumnos.Add(alumno);   // Estaba repetido
            return true;
        }
        else
            return false;
    }
    public Alumno BuscarAlumno(int DNI)
    {
        int i = 0;
        while(i < ListaAlumnos.Count() && DNI != ListaAlumnos[i].DevDNI())
        {
            i++;
        }
        if(i < ListaAlumnos.Count())
            return ListaAlumnos[i];
        else
            return null;
    }
    public List<Alumno> DevListaAlumnos()
    {
        return ListaAlumnos;
    }
    public List<Alumno> DevListaAlumnosLibre()
    {
        List<Alumno> alumnosLibres = new List<Alumno>();
        foreach(Alumno alumno in ListaAlumnos)
        {
            if(alumno.EstaLibre())
                alumnosLibres.Add(alumno);
        }
        return alumnosLibres;
    }

}