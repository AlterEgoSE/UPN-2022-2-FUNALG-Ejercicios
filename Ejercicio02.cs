// Diseñar un programa que visualice el siguiente triángulo isósceles.
int cant;
Console.Write("Ingrese numero de filas de la piramide: ");
cant = int.Parse(Console.ReadLine());
for (int i = 1; i <= cant; i++)
{
    for (int j = 1; j <= cant - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("*");
    }
    for (int l = 1; l <= i - 1; l++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
