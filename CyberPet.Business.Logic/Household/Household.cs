using CyberPet.Business.Logic.Interactions;
using CyberPet.Business.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet.Business.Logic.Household
{
    public class House
    {
        public List<ICyberPetInteractions> peopleWhoLiveInTheHouse = new List<ICyberPetInteractions>();
        public CyberPetStatus cat = new CyberPetStatus();
        public CyberPetStatus giraffe = new CyberPetStatus();

        public void PeopleAdd(ICyberPetInteractions person)
        {
            peopleWhoLiveInTheHouse.Add(person);
        }

        public void SomeoneFeedTheGiraffe()
        {
            var someone = peopleWhoLiveInTheHouse.First();
            someone.Eat(giraffe);
        }

        public void MumTalkToThePet(CyberPetStatus pet)
        {
            var someone = (MumLikeCyberInteraction)peopleWhoLiveInTheHouse.First();
            someone.TalkToThePet(pet);
        }
    }
}
