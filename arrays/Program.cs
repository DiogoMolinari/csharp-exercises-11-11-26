int[] numbers = new int[4];
int accountant;

void PopulateArray()
{
    accountant = 0;
    do
    {
        //Console.WriteLine("Informe o número desejado na posição: " + accountant);
        Console.Write($"Informe o número desejado da posição {accountant}: "); //interpolação de strings
        numbers[accountant] = int.Parse(Console.ReadLine());
        accountant++;

    } while (accountant < numbers.Length);
}

void ShowArray()
{
    accountant = 0;

    Console.Write("Os valores escolhidos formaram o vetor: ");
    while (accountant < numbers.Length)
    {
        Console.Write($"[{numbers[accountant]}] ");
        accountant++;
    }
}

PopulateArray();
ShowArray();
