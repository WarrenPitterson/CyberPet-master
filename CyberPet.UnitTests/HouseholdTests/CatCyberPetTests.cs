using CyberPet.Business.Logic;
using CyberPet.Business.Logic.Interactions;
using CyberPet.Business.Logic.Models;
using System;
using Xunit;

namespace CyberPet.UnitTests
{
    public class CatCyberPetTests
    {
        [Fact]
        public void WhenCatIsSleepingTirednessGoesDown()
        {
            var cat = new CyberPetStatus();

            var interaction = new CatCyberPetInteractions();

            interaction.Sleep(cat);

            Assert.Equal(80, cat.Tiredness);
        }


        [Fact]
        public void WhenCatIsPlayingBoredoomGoesDown()
        {
            var cat = new CyberPetStatus();

            var interaction = new CatCyberPetInteractions();

            interaction.Play(cat);

            Assert.Equal(80, cat.Boredom);
        }

        [Fact]
        public void WhenCatEatsDoesHungerGoDown()
        {
            var cat = new CyberPetStatus();

            var interaction = new CatCyberPetInteractions();

            interaction.Eat(cat);

            Assert.Equal(80, cat.Hunger);
        }

        [Fact]
        public void WhenMumFeedsTheCatTheHungerGoesReallyDown()
        {
            var cat = new CyberPetStatus();

            var interaction = new MumLikeCyberInteraction();

            interaction.Eat(cat);

            Assert.Equal(60, cat.Hunger);
        }
    }
}