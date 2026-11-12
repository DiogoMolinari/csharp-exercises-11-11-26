/*Exercício 4: Faça um programa que cria um vetor de char com 10 posições. Copie para
um novo vetor cada uma das posições adicionando na próxima o valor da tabela ASC daquele caractere.*/

int size = 10;
char[] array1 = new char[size];
string[] array2 = new string[size*2];

void PopulateArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Informe a letra desejada: ");
        array[i] = char.Parse(Console.ReadLine());
    }
}

int ConvertAscii (char letter)
{
    return (int)letter;
}

void CreateAsciiArray()
{
    for (int i = 0; i < array2.Length; i+=2)
    {
        array2[i] = array1[i/2].ToString();
        array2[i+1] = ConvertAscii(array1[i/2]).ToString();
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine("\n");
}

PopulateArray(array1);
string[] temp = new string[array1.Length];
for (int i = 0; i < array1.Length; i++)
{
    temp[i] = array1.ToString();
}

ShowArray(temp);
CreateAsciiArray();
ShowArray(array2);
