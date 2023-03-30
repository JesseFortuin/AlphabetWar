using AlphabetWar.BL;

namespace AlphabetWar.Test
{
    public class VictoryDeciderTest
    {
        [Theory]
        [InlineData("z", "Right side wins!")]
        [InlineData("zdqmwpbs", "Let's fight again!")]
        [InlineData("zzzzs", "Right side wins!")]
        [InlineData("wwwwwwz", "Left side wins!")]
        public void AlphabetWarTest(string input, string output)
        {
            //arrange
            IVictoryDecider decider = new VictoryDecider();

            //act
            string actual = decider.AlphabetWar(input);

            //assert
            Assert.Equal(output, actual);
        }
    }
}