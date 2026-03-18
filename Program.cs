class Program
{
    static void Main(string[] args)
    {
        int opcion, DNI;
        Curso Colegio = new Curso();
        Alumno Estudiante;
        do
        {
            opcion = IngresarInt("1. Agregar alumnos nuevos. \r\n2. Buscar alumnos.\r\n3. Agregar faltas.\r\n4. Mostrar todos los alumnos.\r\n5. Mostrar alumnos libres.\r\n6. Salir.", 1, 6);
            switch (opcion){
                case 1:
                    string nombre = IngresarStr("Ingrese el nombre del alumno.");
                    DNI = IngresarInt("Ingrese el DNI del alumno.", 0, int.MaxValue);
                    Colegio.AgregarAlumno(DNI, nombre);
                    Console.WriteLine("Alumno agregado exitosamente.")
                    break;
                case 2:
                    DNI = IngresarInt("Ingrese el DNI del alumno.", 0, int.MaxValue);
                    Estudiante = Colegio.BuscarAlumno(DNI);
                    if(Estudiante == null)
                        Console.WriteLine("No se encontró al alumno.");
                    else
                        Console.WriteLine(Estudiante.DevInfo());
                    break;
                case 4:
                    

            }
        }while (opcion!=6);
    }
    static int IngresarInt(string mensaje, int min, int max)
    {
        Console.WriteLine(mensaje);
        int opcion = int.Parse(Console.ReadLine());
        while(opcion<min || opcion > max)
        {
            Console.WriteLine("ERROR. Ingrese nuevamente.");
            opcion = int.Parse(Console.ReadLine());
        }
        return opcion;
    }
    static string IngresarStr(string mensaje)
    {
        Console.WriteLine(mensaje);
        string opcion = Console.ReadLine();
        while(string.IsNullOrEmpty(opcion))
        {
            Console.WriteLine("ERROR. Ingrese nuevamente.");
            opcion = Console.ReadLine();
        }
        return opcion;
    }
}