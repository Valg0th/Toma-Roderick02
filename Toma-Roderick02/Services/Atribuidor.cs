using System;
using System.Collections.Generic;
using System.Text;
using Toma_Roderick02.Entities;
using Toma_Roderick02.Enums;

namespace Toma_Roderick02.Services
{
    internal class Atribuidor
    {
        public void AdicionarStatus(Membros membros)
        {
            Console.WriteLine("Escolha os cinco atributos do seu Personagem:");
            Console.WriteLine("Eles são: str; agi; vit; sab; dex;");
            Console.WriteLine("Pode Começar: ");
            membros.Status.Add(Stats.str, int.Parse(Console.ReadLine()));
            membros.Status.Add(Stats.agi, int.Parse(Console.ReadLine()));
            membros.Status.Add(Stats.vit, int.Parse(Console.ReadLine()));
            membros.Status.Add(Stats.sab, int.Parse(Console.ReadLine()));
            membros.Status.Add(Stats.dex, int.Parse(Console.ReadLine()));
        }
    }
}
