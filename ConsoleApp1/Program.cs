using System.ComponentModel.DataAnnotations;

string apellidos, nombres;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ingrese sus apellidos: ");
apellidos=Console.ReadLine().Trim();
while(apellidos.Any(char.IsDigit))
{
    Console.WriteLine("Hay número!!");
    Console.WriteLine("Ingresé sus apellidos");
    apellidos = Console.ReadLine().Trim();
}
Console.WriteLine("Ingrese sus nombres: ");
nombres = Console.ReadLine().Trim();
while (nombres.Any(char.IsDigit))
{
    Console.WriteLine("Hay número!!");
    Console.WriteLine("Ingresé sus nombres");
    nombres = Console.ReadLine().Trim();
}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Cantidad de caracteres en apellidos: " + apellidos.Length);
Console.WriteLine("Nombres en mayusculas: "+nombres.ToUpper());
Console.WriteLine("Apellidos en minisculas: " + apellidos.ToLower());
if(nombres.CompareTo(apellidos)==0)
{
    Console.WriteLine("Apellidos y nombres son iguales");
}
else
{
    Console.WriteLine("Apellidos y nombres no son iguales"); 
}
Console.ForegroundColor = ConsoleColor.Blue;
if (nombres.Contains("an"))
{
    Console.WriteLine("Existe la palabra \"an\"");
}
else
{
    Console.WriteLine("No existe la palabra \"an\"");
}
if (apellidos.Contains("a"))
{
    int index=apellidos.IndexOf("a");
    if (index != -1)
    {
        Console.WriteLine("La primera posicion de \"a\" es en " + (index + 1));
    }
}
if (apellidos.Contains("a"))
{
    int index = apellidos.LastIndexOf("a");
    if (index != -1)
    {
        Console.WriteLine("La ultima posicion de \"a\" es en " + (index + 1));
    }
}

else
{
    Console.WriteLine("En apellidos no existe la palabra \"a\"");
}
Console.WriteLine("Insertando UPN al inicio de nombre: " + nombres.Insert(0, "UPN"));
Console.WriteLine("Insertando UPN al inicio de apellidos: " + apellidos.Insert(apellidos.Length, "sistemas"));