int[] numeros = new int[10];
int somaPares = 0;

for (int n = 0; n < 10; n++)
{
    Console.WriteLine($"Digite o {n + 1}° número");
    numeros[n] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        somaPares += numeros[i];
    }
    else
    {
        Console.WriteLine("Nem todos so números informados eram pares!");
        break;
    }
}

Console.WriteLine($"A soma dos números pares é: {somaPares}");

