namespace ConsoleApp1.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectScores_ShouldCorrectResult()

        {
            //arrange
            var user = new User("Adam", "1234");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-7);
            //act
            var result = user.Result;
            //assert
            Assert.AreEqual(4, result);

        }
        public void WhenUserGetPoints_ShouldCorrectResult()
        {
            var user = new User("Zuzia", "122154");
            user.AddScore(1);
            user.AddScore(6);
            user.AddScore(-3);
            user.AddScore(8);
            user.AddScore(-5);

            var result = user.Result;

            Assert.AreEqual(7, result);
        }
    }
}