public class Alumno
{
    private int DNI;
    private string Nombre;
    private double CantFaltas;
    public Alumno(int DNI, string Nombre)
    {
        this.DNI = DNI;
        this.Nombre = Nombre;
        CantFaltas = 0;
    }
    public int DevDNI()
    {
        return DNI;
    }
    public string DevInfo()
    {
        return "DNI: " + DNI + "\r\nNombre: " + Nombre + "\r\nFaltas: " + CantFaltas;
    }
    public void AgregarFalta(double falta)
    {
        CantFaltas += falta;
    }
    public bool EstaLibre()
    {
        return CantFaltas >= 15;
    }
}