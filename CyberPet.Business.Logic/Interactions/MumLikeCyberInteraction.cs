using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberPet.Business.Logic.Models;

namespace CyberPet.Business.Logic.Interactions
{
    public class MumLikeCyberInteraction : ICyberPetInteractions
    {
        public CyberPetStatus Eat(CyberPetStatus petStatus)
        {
            petStatus.Hunger -= 40;
            return petStatus;
        }

        public CyberPetStatus Play(CyberPetStatus petStatus)
        {
            petStatus.Boredom -= 10;
            return petStatus;
        }

        public CyberPetStatus Sleep(CyberPetStatus petStatus)
        {
            petStatus.Tiredness -= 40;
            return petStatus;
        }

        public CyberPetStatus TalkToThePet(CyberPetStatus petStatus)
        {
            petStatus.Tiredness += 20;
            return petStatus;
        }
    }
}
