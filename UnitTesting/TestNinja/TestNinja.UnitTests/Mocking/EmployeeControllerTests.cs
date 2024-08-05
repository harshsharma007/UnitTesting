using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class EmployeeControllerTests
    {
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            var storage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(storage.Object);

            controller.DeleteEmployee(1);

            storage.Verify(s => s.DeleteEmployee(1));
        }

        [Ignore("Needs to be fixed")]
        [Test]
        public void DeleteEmployee_WhenCalled_RedirectToActionEmployees()
        {
            var storage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(storage.Object);

            RedirectResult result = (RedirectResult) controller.DeleteEmployee(1);

            Assert.That(result, Does.Contain("Employees"));
        }
    }
}
