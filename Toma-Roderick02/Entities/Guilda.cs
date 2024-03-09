using System;
using System.Collections.Generic;
using Toma_Roderick02.Entities;
using Toma_Roderick02.Enums;
using Toma_Roderick02.Services;
using System.Linq;
using System.Xml.Linq;

namespace Toma_Roderick02.Entities
{
    internal class Guilda : IRepository
    {
        public string Name { get; set; }
        public List<Membros> Personagens { get; set; } = new List<Membros>();

        public Guilda() { }
        public Guilda(string name) {
            Name = name;
        }

        public void Create()
        {
            Console.WriteLine("Vamos criar os membros? \n");
            Console.WriteLine("Quantos pretende criar?\n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tudo bem, vamos lá");
                Console.WriteLine($"Digite o ID do {i} membro:");
                string id = Console.ReadLine();
                Console.WriteLine($"Digite o nome do {i} membro:");
                string name = Console.ReadLine()!;
                Class classe;
                bool deuBom = false;
                do
                {
                    Console.WriteLine("Qual a Classe dele? Até onde sei existe: Paladino, Arqueiro, Mago, Barbaro, Assassino");
                    string classeDele = Console.ReadLine();
                    if (!Enum.TryParse(classeDele, true, out classe))
                    {
                        Console.WriteLine("Que pena, parece que você digitou a classe errada. Digite novamente.");
                    }
                    else
                    {
                        Console.WriteLine($"Muito bem.\n A classe escolhida foi: {classe}");
                        deuBom = true;
                    }
                } while (!deuBom);
                Membros novoMembro;
                Console.WriteLine("Agora escolha a raça dele/dela");
                bool entradaValida = false;
                string racaDele = "biloca";
                do
                {
                    racaDele = Console.ReadLine()!;
                    switch (racaDele.ToLower())
                    {
                        case "elfo":
                            novoMembro = new Elfo(id, name, classe, racaDele);
                            novoMembro.AdicionarStatus(novoMembro);
                            Personagens.Add(novoMembro);
                            entradaValida = true;
                            break;
                        case "orc":
                            novoMembro = new Orc(id, name, classe, racaDele);
                            novoMembro.AdicionarStatus(novoMembro);
                            Personagens.Add(novoMembro);
                            entradaValida = true;
                            break;
                        case "humano":
                            novoMembro = new Humano(id, name, classe, racaDele);
                            novoMembro.AdicionarStatus(novoMembro);
                            Personagens.Add(novoMembro);
                            entradaValida = true;
                            break;
                        default:
                            Console.WriteLine("Você digitou algo incorretamente");
                            break;
                    }
                } while (!entradaValida);
                
                Console.WriteLine("Membro criado com sucesso!");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Digite o nome do personagem você quer deletar?");
            string nomeParaRemover = Console.ReadLine();
            var itemParaRemover = Personagens.FirstOrDefault(biloca => biloca.Name == nomeParaRemover);

            if (itemParaRemover != null)
            {
                Personagens.Remove(itemParaRemover);
                Console.WriteLine("Personagem removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar o personagem na lista.");
            }
        }

        public void FindAll()
        {
            Console.WriteLine("Membros da guilda:");
            foreach (var membro in Personagens)
            {
                Console.WriteLine(membro);
            }

        }

        public void FindById()
        {
            Console.WriteLine("Digite o ID para encontrar o personagem:");
            string idParaAchar = Console.ReadLine();
            var donoID = Personagens.FirstOrDefault(biloca => biloca.Id == idParaAchar);

            if (donoID != null)
            {
                Console.WriteLine($"Personagem encontrado: {donoID.Name}, Classe: {donoID.Classe}, Raça: {donoID.Raca}");
            }
            else
            {
                Console.WriteLine("Nenhum personagem encontrado com o ID fornecido.");
            }
        }

        public void Update()
        {
            Console.WriteLine("Digite o nome do personagem a ser alterado:");
            string nomeParaAchar = Console.ReadLine();

            var donoName = Personagens.FirstOrDefault(biloca => biloca.Name == nomeParaAchar);

            if (donoName != null)
            {
                Console.WriteLine($"Personagem encontrado: {donoName.Name}, Classe: {donoName.Classe}, Raça: {donoName.Raca}");

                Console.WriteLine("Digite o novo ID:");
                string novoId = Console.ReadLine();
                Console.WriteLine("Digite a nova Classe:");
                Class novaClasse;
                while (!Enum.TryParse(Console.ReadLine(), true, out novaClasse))
                {
                    Console.WriteLine("Classe inválida. Por favor, digite novamente.");
                }
                Console.WriteLine("Digite a nova Raça:");
                string novaRaca = Console.ReadLine();

                donoName.Id = novoId;
                donoName.Classe = novaClasse;
                donoName.Raca = novaRaca;

                Console.WriteLine("Informações do personagem atualizadas com sucesso.");
            }
            else
            {
                Console.WriteLine("Nenhum personagem encontrado com o nome fornecido.");
            }
        
        }
    }

    }
