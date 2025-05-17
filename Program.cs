Console.Clear();

//isso vai ser complicado-
Console.WriteLine("\n--- Estacionamento ---");

//bagulhos
string TamanhoV;
string valet;
string lavagem;

double P, G, N, S;
double Diaria, TempoP, Horas, total;
double HorasP, DiariaP, LavagemP;
double HorasG, DiariaG, LavagemG;

Console.WriteLine("Tamanho do veículo (P/G).....:");
TamanhoV = (Console.ReadLine());
while (TamanhoV != "P" && TamanhoV !="G")
{
    Console.WriteLine("Informação incoerente, por favor, insira novamente:");
    Console.WriteLine("Tamanho do veículo (P/G).....:");
    TamanhoV = Console.ReadLine();
}

Console.WriteLine("Tempo de permanência (min)...:");
TempoP = Convert.ToDouble(Console.ReadLine());
while (TempoP > 720)
{
    Console.WriteLine("O tempo exerce o limete permitido no estacionamento");
    Console.WriteLine(" por favor, insira novamente: \n");

    Console.WriteLine("Tempo de permanência (min)...:");
    TempoP = Convert.ToDouble(Console.ReadLine());
}
Horas = TempoP / 60;



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

if (TamanhoV == "P")
{
    HorasP = Horas * 10;
    DiariaP = Horas * 50;
    LavagemP = 50;
}
else if (TamanhoV == "G") ;
{
    HorasG = Horas * 20;
    DiariaG = Horas * 80;
    LavagemG = 100;
}
