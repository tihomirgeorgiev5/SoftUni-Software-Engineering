namespace Presents.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PresentsTests
    {
        private Present present1;
        private Present present2;
        private Present present3;
        private Bag presents;
        
    }

    [SetUp]
    public void SetUp()
    {
        this.present1 = new Present("Present1", 1);
        this.presents = new Bag();
        
    }

    [Test]
    public void Test_Create_Null_Present()
    {
        Assert.Throws<ArgumentNullException>(() => this.presents.Create(null));
    }





}
