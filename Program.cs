string palavra, letra;
Console.WriteLine("Digite uma palavra ");
palavra = Console.ReadLine()!;

Console.WriteLine("Digite uma letra ");
letra = Console.ReadLine()!;
Console.WriteLine($"a letra {letra} existe na palavra {palavra.Contains (letra)}");