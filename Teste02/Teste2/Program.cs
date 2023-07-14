// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

string nome; 
int qtd = 0, f; 
double nota, soma = 0, media;


Console.WriteLine("Bem vindo ao Teste 02, para iniciarmos qual é o seu Nome?");
nome = Console.ReadLine();

for (f = 1; f <= 40; f++)
{
  
    Console.WriteLine($"{nome} por favor, nos informe qual foi sua nota da prova");
    nota = double.Parse(Console.ReadLine());
   
    qtd++;
   
    soma += nota;
    
    media = soma / qtd;
    
    Console.WriteLine($"Nome: {nome} \nQuantidade de provas: {qtd} \nTotal de nota: {soma} \nSua média é de: {media}");

}

Console.ReadKey();
