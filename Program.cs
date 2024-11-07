// See https://aka.ms/new-console-template for more information

// TRABALHANDO COM STRINGS

/*
using System;

Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);
aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);
Console.WriteLine($"Hello {aFriend}");

string firstFriend = "     Maria     ";

firstFriend = firstFriend.Trim();

string secondFriend = "     Sage     ";

// Interpolação de strings
Console.WriteLine($"My friends are {firstFriend} and {secondFriend.Trim()}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

System.Console.WriteLine(firstFriend.StartsWith("Sa")); // Começa com "Sa"
System.Console.WriteLine(firstFriend.EndsWith("ia"));   // Termina com "ia"
System.Console.WriteLine(firstFriend.Contains("a"));    // Contém a letra "a"
System.Console.WriteLine(firstFriend.IndexOf("a"));    // Posição da letra "a"
System.Console.WriteLine(firstFriend.LastIndexOf("a")); // Última posição da letra "a"
System.Console.WriteLine(firstFriend.Replace("a", "e")); // Troca a letra "a" pela letra "e"
System.Console.WriteLine(firstFriend.ToUpper()); // Deixa tudo em maiúsculas
System.Console.WriteLine(firstFriend.ToLower()); // Deixa tudo em minúsculas
System.Console.WriteLine(firstFriend.Substring(0, 4)); // Pegar 4 caracteres a partir
System.Console.WriteLine(firstFriend.Substring(4)); // Pegar todos os caracteres a partir
System.Console.WriteLine(firstFriend.Split('a')); // Divide a string em substrings
System.Console.WriteLine(firstFriend.Split('a')[0]); // Pegar a primeira substring
*/

// TRABALHANDO COM NÚMEROS EM C#

/*
int a = 2100000000;
int b = 2100000000;
long c = (long)a + (long)b;
//long d = checked(a + b);

System.Console.WriteLine(c);
//System.Console.WriteLine(d);

double e = 42.1;
float f = 38.2F;
double g = e + f;

System.Console.WriteLine($"The answer is {g:F3}");
*/

// TRABALHNDO COM IF

/*
int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

int x = 5;
int y = 3;
int w = 4;
if ((x + y + w > 10) || (x == y))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}
*/

// TRABALHANDO COM LOOP WHILE

/*
int counter = 0;
int outroCounter = 0;

while (counter < 10)
{
    Console.WriteLine("Counter " + counter);
    Console.WriteLine("OutroCounter " + outroCounter);
    counter++;
    outroCounter = counter; // Incrementa outroCounter com o valor atual de counter
}

int numero;

do
{
    Console.Write("Digite um número (0 para sair): ");
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Você digitou: " + numero);
} while (numero != 0);

Console.WriteLine("Programa finalizado.");
*/

// TRABALHANDO COM LOOP FOR

/*
for (
     int i = 0;     // Initialize (start)
     i < 5;         // Conditional
     i++            // Interation (increment)
    )
{
    if (i != 3)
    {
        Console.WriteLine(i);
    }
}

for (int linha = 1; linha < 11; linha++)
{
  for (char coluna = 'a'; coluna < 'k'; coluna++)
  {
    Console.WriteLine($"The cell is ({linha}, {coluna})");
  }
}

int soma = 0;

for(int i = 0; i <= 20; i++)
{
    if(i % 3 == 0)
    {
        soma += i;
    }
}

Console.WriteLine("A soma de todos os inteiros de 1 a 20 devisíveis por 3 é: " + soma);
*/

// TRABALHANDO COM LISTAS



