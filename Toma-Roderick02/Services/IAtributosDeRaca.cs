using System;

namespace Toma_Roderick02.Services
{
    public interface IAtributosDeRaca
    {
        virtual void BonusdeRaca() { 
            if (BonusdeRaca != null) { 
                BonusdeRaca();
            }
            else
            {
                Console.WriteLine("Seu Personagem não tem raça definida");
            }
        }

    }
}
