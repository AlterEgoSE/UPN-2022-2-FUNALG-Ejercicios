// Diseñar un programa que imprima una tabla de m filas por n columnas y un caracter fijado.
// El usuario debe ingresar “m”, “n” y el caracter.

int fila, columna;
char caracter;

Console.Write("Ingrese el número de filas: ");
fila = int.Parse(Console.ReadLine());
Console.Write("Ingrese el número de columnas: ");
columna = int.Parse(Console.ReadLine());
Console.Write("Ingresa el caracter: ");
caracter = char.Parse(Console.ReadLine());

for (int i = 1; i <= fila; i++)
{
    for (int j = 1; j <= columna; j++)
    {
        Console.Write("\t" + "" + caracter + "");
    }
    Console.WriteLine();
}
