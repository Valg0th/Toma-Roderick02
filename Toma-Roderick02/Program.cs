using System;
using System.Linq;
using System.Collections.Generic;
using Toma_Roderick02.Entities;
using Toma_Roderick02.Services;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Este programa serve exclusivamente para criar uma guilda.");
        Console.WriteLine("Pode me dizer o nome que quer dar a ela?");
        string nomeGuilda = Console.ReadLine();
        Guilda guilda = new Guilda(nomeGuilda);
        Console.WriteLine($"Certo. O nome da guilda será: {guilda.Name}.");
        Console.WriteLine("Agora escolha uma opção:");
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Digite 1 para criar um ou mais membros");
            Console.WriteLine("Digite 2 para excluir um membro da lista");
            Console.WriteLine("Digite 3 para ver a lista completa dos membros");
            Console.WriteLine("Digite 4 para atualizar os dados de alguém");
            Console.WriteLine("Digite 5 para sair do programa");

            Dictionary<int, Action> Menu = new Dictionary<int, Action>()
            {
                { 1, guilda.Create },
                { 2, guilda.Delete },
                { 3, guilda.FindAll },
                { 4, guilda.Update }
            };

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida, tente novamente");
                continue;
            }

            if (opcao == 5)
            {
                break;
            }

            if (Menu.ContainsKey(opcao))
            {
                Menu[opcao].Invoke();
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente");
            }
            Thread.Sleep(3000);
        }
    }
}