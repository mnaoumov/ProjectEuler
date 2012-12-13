using System.Diagnostics;
using NUnit.Framework;

namespace Problem3
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MaxPrimeFactor_is_correct()
        {
            var solver = new MySolver();
            Assert.That(solver.GetMaxPrimeFactor(13195), Is.EqualTo(29));
        }
    }
}