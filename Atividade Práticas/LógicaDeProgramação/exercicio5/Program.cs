// Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
// letra do alfabeto aparece no texto.

Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine()!;

char[] caracteres = texto.ToCharArray();
Dictionary<char, int> letter = new Dictionary<char, int>();

for (int i = 0; i < caracteres.Length; i++)
{
    if (letter[caracteres[i]] >= 1)
    {
        letter[caracteres[i]] ++;
    }
    else
    {
        letter.Add(caracteres[i],1);
    }
}

Console.WriteLine(letter);