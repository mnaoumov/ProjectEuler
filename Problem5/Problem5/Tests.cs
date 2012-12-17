using NUnit.Framework;

namespace Problem5
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void For_10_is_correct()
        {
            Assert.That(MySolver.MyCommonMultiplier(10), Is.EqualTo(2520));
        }
    }
}