// See https://aka.ms/new-console-template for more information

double nota1, nota2, media;

Console.WriteLine("Digite a nota do primeiro semestre:");
nota1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota do segundo semestre:");
nota2 = Double.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;

Console.WriteLine($"Sua média é de {media}");

Console.ReadKey();