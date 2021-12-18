namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        public void ConstructorMustHaveCorrectProperties()
        {
            string name = "Strange";
            int capacity = 10;

            Aquarium aquarium = new Aquarium(name, capacity);

            string expectedName = "Strange";
            int expectedCapacity = 10;

            string actualName = aquarium.Name;
            int actualCapacity = aquarium.Capacity;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [Test]
        public void SetNameThrowExcepWhenItIsNullOrempty()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, 10));
            Assert.Throws<ArgumentNullException>(() => new Aquarium(string.Empty, 10));
        }

        [Test]
        public void SetCapacityShouldThrowExceptionwhenIsnull()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("strange", -10));
        }

        [Test]
        public void AddFishInAquariumWhenCapacityValid()
        {
            Fish fish = new Fish("Nemo");
            Aquarium aquarium = new Aquarium("strange", 10);

            aquarium.Add(fish);
            int expectedCount = 1;

            Assert.AreEqual(expectedCount, aquarium.Count);
        }

        [Test]
        public void AddFishThrowsExcepWhenCapacityIsInvalid()
        {
            Fish fish = new Fish("Nemo");
            Aquarium aquarium = new Aquarium("strange", 0);

            Assert.Throws<InvalidOperationException>(() => aquarium.Add(fish));
        }

        [Test]
        public void RemoveFishThrowsExcep()
        {
            Fish fish = new Fish("Nemo");
            Aquarium aquarium = new Aquarium("strange", 10);

            aquarium.Add(fish);
            aquarium.RemoveFish("Nemo");
        }

        [Test]
        public void RemovedFishThrowsExcepWhenNameIsInvalid()
        {

            Aquarium aquarium = new Aquarium("strange", 0);

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("none"));
        }

        [Test]
        public void SellFishShoulsetavailablePropertyTofalse()
        {
            Fish fish = new Fish("Nemo");
            Aquarium aquarium = new Aquarium("strange", 10);

            aquarium.Add(fish);
            var soldFish = aquarium.SellFish("Nemo");

            var expectedAvailability = false;

            Assert.AreEqual(expectedAvailability, soldFish.Available);

        }

        [Test]
        public void SellFishThrowsExcepWhenNameIsInvalid()
        {
            Aquarium aquarium = new Aquarium("strange", 0);

            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish("none"));

        }

        [Test]
        public void ValidateReportMessage()
        {
            Fish fish = new Fish("Nemo");
            Fish fish2 = new Fish("Nemo2");
            Aquarium aquarium = new Aquarium("strange", 10);

            aquarium.Add(fish);
            aquarium.Add(fish2);

            string expectedResult = $"Fish available at strange: Nemo, Nemo2";
            string actualResult = aquarium.Report();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }

    
    
     
     //validate Report - correct Message



}
