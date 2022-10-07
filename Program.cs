/* Diseñar un programa para leer una serie de números hasta obtener un número superior a 100.

int num;

Console.Write("Ingresa un número: ");
num = int.Parse(Console.ReadLine());

while (num <= 100)
{
    Console.WriteLine("Digite de nuevo: ");
    num = int.Parse(Console.ReadLine());
}
*/
int num;

do
{
    Console.Write("Ingresa un número: ");
    num = int.Parse(Console.ReadLine());
}
while (num <=100);