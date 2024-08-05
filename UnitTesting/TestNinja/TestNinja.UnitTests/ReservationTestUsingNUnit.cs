using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTestUsingNUnit
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            /*
                Below are the different ways of doing Assertion.
                
                Assert.IsTrue(result);
                Assert.That(result == true);
            */

            Assert.That(result, Is.True);
        }
    }
}
