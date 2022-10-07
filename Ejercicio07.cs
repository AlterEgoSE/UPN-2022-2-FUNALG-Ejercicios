// Diseñar un programa para buscar y escribir la primera vocal leída del teclado.
// (Se supone que se leen, uno a uno, caracteres desde el teclado.)

char letra;

Console.Write("Digite una letra: ");
letra = char.Parse(Console.ReadLine());

while (letra != 'a' && letra != 'e' && letra != 'i' && letra != 'o' && letra != 'u' && letra != 'A' && letra != 'E' && letra != 'I' && letra != 'O' && letra != 'U')
{
    Console.Write("Digite de nuevo: ");
    letra = char.Parse(Console.ReadLine());
}
Console.ReadKey();

