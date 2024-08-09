string[] nomes = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome {i + 1}:");
    nomes[i] = Console.ReadLine();
}

int n = nomes.Length;
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (String.Compare(nomes[j], nomes[j + 1]) > 0)
        {
            string temp = nomes[j];
            nomes[j] = nomes[j + 1];
            nomes[j + 1] = temp;
        }
    }
}

Console.WriteLine("Nomes cadastrados:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}
