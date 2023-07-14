// See https://aka.ms/new-console-template for more information

string nome, status;
double n1, n2, media;
int f;

Console.WriteLine("Bem vindo ao Teste 03");

for (f = 1; f <= 100; f++)
{
    
    Console.WriteLine("Informe o nome do Aluno:");
    nome = Console.ReadLine();
    
    Console.WriteLine($"Qual foi a nota do primeiro semestre do aluno {nome}?");
    n1 = double.Parse(Console.ReadLine());
   
    Console.WriteLine($"Qual foi a nota do segundo semestre do aluno {nome}?");
    n2 = double.Parse(Console.ReadLine());
    
    media = (n1 + n2) / 2;
   
    if (media < 6.5)
    {
        status = "Reprovado";
    }
    else
    {
        status = "Aprovado";
    }
    
    Console.WriteLine($"Nome do Aluno: {nome} \nMédia: {media}\nO aluno foi: {status}\n");

}

Console.ReadKey();