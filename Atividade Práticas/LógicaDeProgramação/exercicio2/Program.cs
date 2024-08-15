// Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.

string[] nomes = ["","","","",""];

for (int i = 0; i <= 4; i++)
{
    Console.WriteLine($"{i+1}) digite um nome:");
    nomes[i] = Console.ReadLine()!;
}

Array.Sort(nomes);

Console.WriteLine(" ");
Console.WriteLine("Nomes cadastrados:");
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);   
}