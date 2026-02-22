Console.WriteLine("Ingrese el tipo de incidente");
Console.WriteLine("1. Malware");
Console.WriteLine("2. Phishing");
Console.WriteLine("3. Acceso no autorizado");
Console.WriteLine("4. Fuga de información");
int incidente = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese el tipo de archivo afectado");
Console.WriteLine("1. PC");
Console.WriteLine("2. Servidor");
Console.WriteLine("3. Base de datos");
Console.WriteLine("4. Red");
int archivo = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Ingrese los datos comprometidos:");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Internos");
Console.WriteLine("3. Personales");
Console.WriteLine("4. Financieros");
int datos = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("¿Persistencia detectada? (S/N)");
string persistencia = Console.ReadLine().ToUpper();
Console.WriteLine();
Console.WriteLine("Núnero de usuarios afectados:");
int usuarios = int.Parse(Console.ReadLine());
string severidad = "Baja";
string respuesta = "";
switch (incidente)
{
    case 1:
        {

        }
        break;
    case 2:
        {

        }
        break;
        case 3:
        {

        }
        break;
        case 4:
        {

        }
        break;
    default:
        {
            Console.WriteLine("Opción de incidente no válida.");
        }
        break;
}

