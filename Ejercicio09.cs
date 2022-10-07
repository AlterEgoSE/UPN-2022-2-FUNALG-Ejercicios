// Diseñar un programa para leer sucesivamente números del teclado hasta que aparezca
// un número comprendido entre 1 y 5.;

int num;

Console.Write("Digite un número: ");
num = int.Parse(Console.ReadLine());

while ( num <2 || num > 4)
{
    Console.WriteLine("Digite de nuevo: ");
    num = int.Parse(Console.ReadLine());
}
Console.ReadKey();
