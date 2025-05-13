Console.Clear();
//isso vai ser complicado-
Console.WriteLine("\n--- Estacionamento ---");

//bagulhos
string TamanhoV;
string valet;
string lavagem;

double P, G, N, S;

Console.WriteLine("Tamanho do veículo (P/G).....:");
TamanhoV = (Console.ReadLine());
while (TamanhoV != "P" && TamanhoV !="G")
{
    Console.WriteLine("Informação incoerente, por favor, insira novamente:");
    Console.WriteLine("Tamanho do veículo (P/G).....:");
    TamanhoV = Console.ReadLine();
}

Console.WriteLine("Tempo de permanência (min)...:");
double TempoP = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Serviço de valet (S/N).......:");
valet = (Console.ReadLine());
while (valet != "S" && valet !="N")
{
    Console.WriteLine("Informação incoerente, por favor, insira novamente:");
    Console.WriteLine("Serviço de valet (S/N).......:");
    valet = Console.ReadLine();
}

Console.WriteLine("Serviço de lavagem (S/N).....:");
lavagem = (Console.ReadLine());
while (lavagem != "S" && lavagem !="N")
{
    Console.WriteLine("Informação incoerente, por favor, insira novamente:");
    Console.WriteLine("Serviço de lavagem (S/N).....:");
    lavagem = Console.ReadLine();
}

//calculos

if (TamanhoV != "P");
{

}