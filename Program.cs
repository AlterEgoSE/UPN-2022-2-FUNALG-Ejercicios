// Diseñar un programa para calcular la suma de los números naturales,
// comprendidos entre 2 números ingresados por el usuario.

int num1, num2, suma = 0;

Console.Write("Ingresa el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingresa el segundo número: ");
num2 = int.Parse(Console.ReadLine());

for (int i=num1+1; i<num2; i++)
{
    suma=suma+i;
}
Console.WriteLine($"La suma de los números comprendidos entre {num1} y {num2} es {suma}");
Console.ReadKey();

