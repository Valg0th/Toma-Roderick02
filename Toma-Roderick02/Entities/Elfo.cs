﻿using System;
using System.Text;
using Toma_Roderick02.Enums;
using Toma_Roderick02.Services;

namespace Toma_Roderick02.Entities
{
    internal class Elfo : Membros, IAtributosDeRaca
    {
        public Elfo(string id, string name, Class classe, string raca) : base(id, name, classe, raca)
        {
        }

        public void BonusdeRaca()
        {

        }
    }
}
