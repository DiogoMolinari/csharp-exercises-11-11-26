int[] numbers = new int[4];
int accountant = 0;

do
{
    //Console.WriteLine("Informe o número desejado na posição: " + accountant);
    Console.Write($"Informe o número desejado da posição {accountant}: "); //interpolação de strings
    numbers[accountant] = int.Parse(Console.ReadLine());
    accountant++;

} while (accountant < numbers.Length);

Console.WriteLine(numbers);