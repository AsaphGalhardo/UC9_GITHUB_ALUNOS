string nome;
string[,] cadastro = new string[5, 7];
int faltas;
int aulas;
int l = 0;  
int c = 0;  
double prova1;
double prova2;   
double prova3;
double trab4;

for (c = 0; c <= 5; c++)
{
    Console.Clear();

    Console.WriteLine("Qual o seu nome?");
    nome = Console.ReadLine();
    Console.WriteLine("Qual numero de aulas?");
    aulas = int.Parse(Console.ReadLine());
    Console.WriteLine("Qual numero de faltas?");
    faltas = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da prova 1");
    prova1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da prova 2");
    prova2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota da prova 3");
    prova3 = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a nota de seu trabalho");
    trab4 = double.Parse(Console.ReadLine());
}
for (l = 0; l<= 5; l++)
{
    for (c = 0; c <= 7; c++)
    {
        Console.Write(cadastro[l, c] + " - ");
    }
    Console.WriteLine("");
}


