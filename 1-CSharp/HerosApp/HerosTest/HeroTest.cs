using System;
using Xunit;
using HerosLib;
namespace HerosTest
{
    public class HeroTest
    {
        Hero testHero = new Hero();

        [Theory]
        [InlineData("Unit testing god")]
        [InlineData("Flying")]
        [InlineData("Laser Eyes")]
        public void AddSuperPowerShouldAddSuperpower(string superPower)
        {
            //Act (Do the thing you wanna test)
            testHero.AddSuperPower(superPower);

            //Assert
            Assert.Equal(superPower, Hero.superPowers.Peek());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddSuperPowerShouldThrowArgumentException(string superPower)
        {
            //Catching exceptions in unit tests, act and assert are in same 
            //Act and Assert are in the same line
            Assert.Throws<ArgumentException>(() => testHero.AddSuperPower(superPower));
        }

    }
}
