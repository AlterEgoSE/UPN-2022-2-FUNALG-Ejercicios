// Diseñar un programa para imprimir la suma de los primeros números naturales
// impares menores o iguales que n.

int num, suma = 0;

Console.Write("Ingresa un número: ");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (i%2 == 1)
    {
        suma = suma + i;
    }
}
Console.WriteLine($"La suma de los números impares menores o igual a {num} es {suma}");
Console.ReadKey();
