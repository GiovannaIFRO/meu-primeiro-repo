
Console.WriteLine("----------------------");
Console.WriteLine("[1] - Saudação. ");
Console.WriteLine("----------------------");

Console.WriteLine("Escolha uma opção: ");
int opção = Convert.ToInt32(Console.ReadLine());

if(opção == 1)
{
    Console.WriteLine("Qual é o seu nome? ");
    string nome = Console.ReadLine();

    Console.WriteLine("Olá, " + nome + "!");
}