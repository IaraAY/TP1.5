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
            return false;
        else
        {
            Alumno alumno = new Alumno(DNI, nombre);
            ListaAlumnos.Add(alumno);
        }
        return true;
    }
    public Alumno BuscarAlumno(int DNI)
    {
        int i = 0;
        while(i < ListaAlumnos.Count() && DNI != ListaAlumnos[i].DevDNI())
        {
            i++;
        }
        if(i > ListaAlumnos.Count())
            return ListaAlumnos[i];
        else
            return null;
    }
    public void MostrarAlumnos

}