// Diseñar un programa que permita escribir en una pantalla la frase “¿Desea continuar? S/N”
// hasta que la respuesta sea 'N'

string respuesta;

do
{
    Console.WriteLine("¿Desa continuar? Si / No: ");
    respuesta = Console.ReadLine();
}
while (respuesta != "no" && respuesta != "NO");
Console.ReadKey();

