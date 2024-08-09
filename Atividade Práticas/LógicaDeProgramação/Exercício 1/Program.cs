Console.WriteLine("Bem-Vindo! Informe o número que deseja saber se é ímpar ou par: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"O número {number} é par!");
}
else
{
    Console.WriteLine($"O número {number} é ímpar!");
}
