/* Exercício 2: Faça um programa que leia 5 números inteiros e grave em um vetor.
Este vetor deve ser copiado para um novo na sequência inversa.
Faça o mesmo copiando para um novo vetor os números pares e
para outro os números ímpares. Imprima todos eles ao final.*/

int[] userInput = new int[5];
int[] invertedArray = new int[5];
int[] evenArray;
int[] oddArray;

int evenCount = 0;
int oddCount = 0;


void populateArray()
{
    for (int i = 0; i < userInput.Length; i++)
    {
        Console.Write($"Escolha o elemento {i} do vetor: ");
        userInput[i] = int.Parse(Console.ReadLine());
    }
}

void invertArray()
{
    int j = 0;

    for (int i = userInput.Length - 1; i >= 0; i--)
    {
        invertedArray[j] = userInput[i];
        j++;
    }
}

void separateEvenOddArrays()
{
    for (int i = 0; i < userInput.Length; i++)
    {
        if (userInput[i] % 2 == 0)
        {
            evenCount++;
        }
        else
        {
            oddCount++;
        }
    }
    evenArray = new int[evenCount];
    oddArray = new int[oddCount];
    int evenNumber = 0;
    int oddNumber = 0;


    for (int i = 0; i < userInput.Length; i++)
    {
        if (userInput[i] % 2 == 0)
        {
            evenArray[evenNumber] = userInput[i];
            evenNumber++;
        }
        else
        {
            oddArray[oddNumber] = userInput[i];
            oddNumber++;
        }
    }
}

void showArrays()
{
    Console.Write("Vetor na sequência enviada pelo usuário: ");

    for (int i = 0; i < userInput.Length; i++)
    {
        Console.Write($"[{userInput[i]}] ");
    }

    Console.WriteLine("\n");

    Console.Write("Vetor na ordem invertida: ");

    for (int i = 0; i < invertedArray.Length; i++)
    {
        Console.Write($"[{invertedArray[i]}] ");
    }

    Console.WriteLine("\n");

    Console.Write("Vetor apenas com os números pares: ");

    for (int i = 0; i < evenArray.Length; i++)
    {
        Console.Write($"[{evenArray[i]}] ");
    }

    Console.WriteLine("\n");

    Console.Write("Vetor apenas com os números ímpares: ");

    for (int i = 0; i < oddArray.Length; i++)
    {
        Console.Write($"[{oddArray[i]}] ");
    }
}

populateArray();
invertArray();
separateEvenOddArrays();
showArrays();