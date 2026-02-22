using System.ComponentModel.Design;

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
        switch (archivo)
        {
            case 1:
            respuesta= "Ejecutar antivirus en PC";
                break;
            case 2:
                respuesta = "Aislar servidor y reinstalar"; 
                break;
            case 3: 
                respuesta = "Revisar integridad de base de datos"; 
                break;
            case 4: respuesta = "Monitorear tráfico de red"; 
                break;
        }
        break;
    case 2:
        switch (archivo)
        {
            case 1: 
                respuesta = "Bloquear correos sospechosos"; 
                break;
            case 2: 
                respuesta = "Revisar accesos al servidor"; 
                break;
            case 3:
                respuesta = "Verificar credenciales en base de datos";
                break;
            case 4:
                respuesta = "Filtrar tráfico en red";
                break;
        }
        break;
        case 3:
        switch (archivo)
        {
            case 1:
                respuesta = "Cambiar contraseñas en PC";
                break;
            case 2: 
                respuesta = "Revisar logs del servidor"; 
                break;
            case 3:
                respuesta = "Auditar accesos a base de datos";
                break;
            case 4:
                respuesta = "Revisar firewalls";
                break;
        }
        break;
    case 4:
        switch (archivo)
        {
            case 1:
                respuesta = "Analizar origen de fuga en PC";
                break;
            case 2:
                respuesta = "Aislar servidor comprometido";
                break;
            case 3: 
                respuesta = "Revisar permisos en base de datos"; 
                break;
            case 4: 
                respuesta = "Monitorear red y bloquear salida";
                break;
        }
        break;
    default:
        {
            Console.WriteLine("Opción de incidente no válida.");
        }
        break;
}
if (datos == 4)
{
    severidad = "Crítica";
}
else if (datos == 3)
{
    severidad = "Alta";
}
else if (datos == 2)
{
    severidad = "Media";
}
else if (datos == 1)
    {
    severidad = "Baja";
}

if (usuarios>1000)
{
    severidad = "Crítica";    
}
else if (usuarios>500)
{
    severidad = "Alta";    
}
else if (usuarios>100)
{
    severidad = "Media";    
}
else if (usuarios>0)
{
    severidad = "Baja";
}
if (persistencia == "S")
{
    if (incidente == 1&&archivo==2)
    {
        severidad = "Crítica";
    }
    else
    {
        if (severidad == "Media") 
        {
            severidad = "Alta";
        }
        else if (severidad =="Akta")
        {
            severidad = "Crítica";
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Severidad del incidente: {severidad}");
Console.WriteLine($"Respuesta recomendada: {respuesta}");