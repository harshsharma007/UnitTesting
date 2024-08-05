using TestNinja.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        /*
            Every TestMethod has three parts:
            - The first part specifies the name of the method under the test.
            - The second part is the scenario of our testing.
            - The third part is the expected behavior.
        */

        [TestMethod]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            /*
                Arrange:
                The part where we initialize our objects. We prepare the object we want to test, in this case we want to create an instance of the 
                reservation class. So we create Reservation object
            */

            var reservation = new Reservation();

            /*
                Act:
                The Act part is where we act on this object and that basically means we're going to call a method, that's the method we're going
                to test.
            */

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            /*
                Assert:
                In the Assert part, you verify that result is correct. In this case, result should be true.
            */
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            /*
                Arrange:
                The part where we initialize our objects. We prepare the object we want to test, in this case we want to create an instance of the 
                reservation class. So we create Reservation object
            */
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            /*
                Act:
                The Act part is where we act on this object and that basically means we're going to call a method, that's the method we're going
                to test.
            */
            var result = reservation.CanBeCancelledBy(user);

            /*
                Assert:
                In the Assert part, you verify that result is correct. In this case, result should be true.
            */
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            /*
                Arrange:
                The part where we initialize our objects. We prepare the object we want to test, in this case we want to create an instance of the 
                reservation class. So we create Reservation object
            */
            var reservation = new Reservation { MadeBy = new User() };

            /*
                Act:
                The Act part is where we act on this object and that basically means we're going to call a method, that's the method we're going
                to test.
            */
            var result = reservation.CanBeCancelledBy(new User());

            /*
                Assert:
                In the Assert part, you verify that result is correct. In this case, result should be true.
            */
            Assert.IsFalse(result);
        }
    }
}
