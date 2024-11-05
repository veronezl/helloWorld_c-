// See https://aka.ms/new-console-template for more information
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


