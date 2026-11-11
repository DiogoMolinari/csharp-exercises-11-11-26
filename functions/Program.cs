void Hello(string name)
{
    Console.WriteLine("Hello, " + name + "!");
}

Console.Write("Informe o seu nome: ");
string name = Console.ReadLine();

Hello(name);