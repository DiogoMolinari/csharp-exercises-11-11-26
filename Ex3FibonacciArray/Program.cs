/*Exercício 3: Faça um programa que leia 1 número inteiro.
Usando este número, crie um vetor com essa quantidade de posições.
Dentro deste vetor, deve conter os itens da sequência Fibonacci até a posição formada.*/

long a = 0;
long b = 1;
long result = 0;

Console.Write("Digite aqui quantos itens de Fibonacci gostaria de ver: ");
int arraySize = int.Parse(Console.ReadLine());

int[] FibonacciArray = new int[arraySize];

void Fibonacci()
{
    for (int i = 0; i < arraySize; i++)
    {
        FibonacciArray[i] = (int)a;

        result = a + b;
        a = b;
        b = result;
    }
}

Fibonacci();

Console.Write("Vetor com os valores de Fibonacci: ");

for (int i = 0; i < arraySize; i++)
{
    Console.Write($"[{FibonacciArray[i]}] ");
}

Console.WriteLine();