// Diseñar un programa para imprimir todos los números primos entre 2 y 100 inclusive.

int num = 0;
for (int i = 2; i <= 100; i++)
{
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            num = num + 1;
        }
    }    
    if (num <= 2)
    {
        Console.WriteLine(i);
    }
    num = 0;
}
Console.ReadKey();

