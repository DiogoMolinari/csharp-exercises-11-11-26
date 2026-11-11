bool isPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }

    int accountant = 0;

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            accountant++;
        }
    }

    return accountant == 2;
}

Console.Write("Informe o número desejado: ");
int number = int.Parse(Console.ReadLine());
bool prime = isPrime(number);

if(prime)
{
    Console.WriteLine("O número informado é primo.");
}
else
{
    Console.WriteLine("O número informado não é primo.");
}

Console.WriteLine("\nOs números primos até o " + number + " são:");
for(int i = 2; i <= number; i++)
{
    if (isPrime(i))
    { 
        Console.WriteLine(i + " ");
    }
}