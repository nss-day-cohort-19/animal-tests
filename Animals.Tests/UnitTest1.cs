using System;
using Xunit;

namespace Animals.Tests
{
    public class AnimalShould
    {
        private Animal _animal;
        private Dog _doge;

        public AnimalShould()
        {
            _animal = new Animal("George");
            _doge = new Dog("Lunchbox");
        }

        [Fact]
        public void HaveCorrectNamePropertyValue()
        {
            Assert.Equal(_animal.Name, "George");
        }

        [Fact]
        public void SetSpeciesMethodShouldSetSpeciesProperty()
        {
            // Setting the species will be defined on Animal class
            _animal.SetSpecies("German Shepherd");
            Assert.Equal(_animal.Species, "German Shepherd");

            _doge.SetSpecies("Carolina Labrador");
            Assert.Equal(_doge.Species, "Carolina Labrador");

        }

        [Fact]
        public void HaveWalkingSpeedSetWithWalkMethod()
        {
            _animal.Walk(30);
            Assert.Equal(_animal.WalkingSpeed, 30);

            _doge.Walk(0.75);
            Assert.Equal(_doge.WalkingSpeed, 0.75);
        }

        [Fact]
        public void InstanceShouldBeOfCorrectType()
        {
            Assert.IsType<Animal>(_animal);
            Assert.IsType<Dog>(_doge);
        }
    }
}
