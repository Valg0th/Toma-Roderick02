using System;
using System.Text;
using Toma_Roderick02.Enums;
using Toma_Roderick02.Services;

namespace Toma_Roderick02.Entities
{
    internal class Orc : Membros, IAtributosDeRaca
    {
        public Orc(string id, string name, Class classe, String raca) : base(id, name, classe, raca)
        {
        }

        public void BonusdeRaca()
        {
        }
    }
}
