// Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.

Console.WriteLine("Digite um numero para formar a tabuada");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Tabuada do {num}");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}