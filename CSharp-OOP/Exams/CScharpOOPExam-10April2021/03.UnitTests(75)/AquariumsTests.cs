namespace Aquariums.Tests
{
    using System;
    using NUnit.Framework;

    public class AquariumsTests
    {
        private Aquarium aquarium;
        [SetUp]
        public void SetUp()
        {
            this.aquarium = new Aquarium("Name", 2);
        }

        [Test]
        public void MustSetCorrectQuantity()
        {
            string expectedName = "Name";
            int expectedCapacity = 3;
            int expectedFishCount = 0;

            string actualName = this.aquarium.Name;
            int actualCapacity = this.aquarium.Capacity;
            int actualFishCount = this.aquarium.Count;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedCapacity, actualCapacity);
            Assert.AreEqual(expectedFishCount, actualFishCount);

        }

        
        [TestCase(null)]
        [TestCase("")]
        public void IfNameIsNotCorrect_ThrowArgumentNullException_NullOrEmptyString(string input)
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(input, 2));
        }

        [Test]
        public void IfCapacityNotValid_ThrowArgumentException_NegariveValue()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("Name", -2));
        }
        [Test]
        public void Check_Add()
        {
            Fish fish = new Fish("Fish");

            this.aquarium.Add(fish);

            int expected = 2;
            int actual = this.aquarium.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_ThrowInvalidOperationException_FullAquarium()
        {
            Fish fish = new Fish("Fish");
            Fish fish2 = new Fish("Fish2");
            Fish fish3 = new Fish("Fish3");


            this.aquarium.Add(fish);
            this.aquarium.Add(fish2);
            this.aquarium.Add(fish3);

            Assert.Throws<InvalidOperationException>(() => this.aquarium.Add(new Fish("Fish")));
        }

        [Test]
        public void Remove_TrydWorkCorrect()
        {
            Fish fish = new Fish("Fish");

            this.aquarium.Add(fish);

            this.aquarium.RemoveFish(fish.Name);

            int expected = 0;
            int actual = this.aquarium.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Remove_ThrowInvalidOperationException_NoExistingName()
        {
            Fish fish = new Fish("Fish");

            this.aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() => this.aquarium.RemoveFish("NoExistingName"));
        }

        [Test]
        public void FishSell_WorkCorrect()
        {
            Fish fish = new Fish("Fish");

            this.aquarium.Add(fish);

            Fish actual = this.aquarium.SellFish(fish.Name);

            Assert.AreSame(fish, actual);
        }

        [Test]
        public void FishSell_ThrowInvalidOperationExceptionWithNoExistingName()
        {
            Fish fish = new Fish("Fish");

            this.aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() => this.aquarium.SellFish("NoExistingName"));
        }

        [Test]
        public void Report_ReturnCorrectInfo()
        {
            Fish fish = new Fish("Fish");
            Fish fish2 = new Fish("Fish2");
            


            this.aquarium.Add(fish);
            this.aquarium.Add(fish2);
            

            string expected = $"Fish available at Name: Fish, Fish2";
            string actual = this.aquarium.Report();

            Assert.AreEqual(expected, actual);
        }


    }
}
