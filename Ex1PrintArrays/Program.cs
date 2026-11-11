/*Exercício 1: Faça um programa que leia até 6 caracteres e grave em um vetor, na ordem inserida.
Imprima o vetor da primeira a última posição e também da última a primeira posição.*/

Console.WriteLine("Digite o tamanho que deseja para o vetor (o número máximo deve ser 6): ");
int sizeArray = int.Parse(Console.ReadLine());

char[] userInput = new char[sizeArray];

void PopulateArray()
{
if (sizeArray > 6)
{
        Console.WriteLine("Você precisa escolher um número menor que 6.");
    }
else
{
        for (int i = 0; i < sizeArray; i++)
        {
            Console.WriteLine($"Escolha um caracter para a posição {i} do vetor: ");
            userInput[i] = char.Parse(Console.ReadLine());
        }
    }
}

void ShowNormalArray()
{
    for (int i = 0; i < sizeArray; i++)
    {
        Console.Write(userInput[i]);
    }
}

void ShowInvertedArray()
{
    for (int i = sizeArray-1; i >= 0; i--)
    {
        Console.Write(userInput[i]);
    }
}

PopulateArray();
ShowNormalArray();
Console.WriteLine("\n");
ShowInvertedArray();