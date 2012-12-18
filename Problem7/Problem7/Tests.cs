using NUnit.Framework;

namespace Problem7
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MySolver_Solve_is_correct()
        {
            var solver = new MySolver();
            Assert.That(solver.Solve(6), Is.EqualTo(13));
        }
    }
}