using CyberPet.Business.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet.Business.Logic
{
    public class CatCyberPetInteractions : ICyberPetInteractions
    {
        public CyberPetStatus Eat(CyberPetStatus petStatus)
        {
            petStatus.Hunger -=20;
            return petStatus;
        }

        public CyberPetStatus Play(CyberPetStatus petStatus)
        {
            petStatus.Boredom -= 20;
            return petStatus;
        }

        public CyberPetStatus Sleep(CyberPetStatus petStatus)
        {
            petStatus.Tiredness -= 20;
            return petStatus;

        }
    }
}
