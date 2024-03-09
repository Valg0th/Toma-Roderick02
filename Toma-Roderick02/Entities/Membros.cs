using System;
using System.Collections.Generic;
using System.Text;
using Toma_Roderick02.Enums;
using Toma_Roderick02.Entities;

namespace Toma_Roderick02.Entities
{

    internal class Membros : Model
    {
        public string Name { get; set; }
        public Dictionary<Stats, int> Status = new Dictionary<Stats, int>();
        public Class Classe { get; set; }
        public String Raca { get; set; }
        public double ForcaFisica => CalcularForcaFisica();
        public double PoderMagico => CalcularPoderMagico();

        public double PoderTotal { get => CalcularForcaFisica() + CalcularPoderMagico(); }

        public Membros(string id, string name, Class classe, string raca) : base(id)
        {
            Id = id;
            Name = name;
            Raca = raca;
            Classe = classe;
            Raca = raca;
        }
        public Membros(string id) : base(id)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Personagem: Name: {Name};");
            sb.AppendLine($"Classe: {Classe}");
            sb.AppendLine($"Raça: {Raca}");
            sb.AppendLine("Atributos:");
            foreach (var bigode in Status)
            {
                sb.AppendLine($"{bigode.Key}: {bigode.Value}");
            }
            sb.AppendLine($"Força Física: {ForcaFisica}, Poder Mágico: {PoderMagico}");
            sb.AppendLine($"PoderTotal: {PoderTotal}");
            return sb.ToString();
        }

        public double CalcularForcaFisica()
        {
            double somaForca = 0;

            if (Status != null)
            {
                if (Status.ContainsKey(Stats.str))
                    somaForca += Status[Stats.str];
                if (Status.ContainsKey(Stats.agi))
                    somaForca += Status[Stats.agi];
                if (Status.ContainsKey(Stats.vit))
                    somaForca += Status[Stats.vit];
            }

            return somaForca;
        }
        public double CalcularPoderMagico()
        {
            double somaAtributos = 0;

            if (Status != null)
            {
                if (Status.ContainsKey(Stats.sab))
                    somaAtributos += Status[Stats.sab];
                if (Status.ContainsKey(Stats.dex))
                    somaAtributos += Status[Stats.dex];

            }

            return somaAtributos;
        }
        public void AdicionarStatus(Membros membro)
        {
            Console.WriteLine("Escolha os cinco atributos do seu Personagem:");
            try
            {
                Console.Write("Força: ");
                membro.Status.Add(Stats.str, int.Parse(Console.ReadLine()!));
                Console.Write("Agilidade: ");
                membro.Status.Add(Stats.agi, int.Parse(Console.ReadLine()!));
                Console.WriteLine("Vitalidade: ");
                membro.Status.Add(Stats.vit, int.Parse(Console.ReadLine()!));
                Console.Write("Inteligência: ");
                //int é palavra reservada haha
                membro.Status.Add(Stats.sab, int.Parse(Console.ReadLine()!));
                Console.WriteLine("Destreza: ");
                membro.Status.Add(Stats.dex, int.Parse(Console.ReadLine()!));
            } catch (Exception e) {
                Console.WriteLine("Você deve digitar um número inteiro né seu zé.");
            }
            }
            

    }
}