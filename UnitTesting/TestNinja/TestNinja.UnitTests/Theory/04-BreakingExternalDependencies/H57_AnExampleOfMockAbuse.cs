namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H57_AnExampleOfMockAbuse
    {
        /*
            People who abuse mocks extract an interface from every class. So, in the Product class let's extract an interface from the Customer class.
            
            public interface ICustomer
            {
                bool IsGold { get; set; }
            }
            
            And, in GetPrice(Customer customer) method instead of Customer you pass an ICustomer object.
            
            public float GetPrice(ICustomer customer)
            {
                // Do something
            }
            
            Back to our unit test, our current test is passing.
            
            [Test]
            public void GetPrice_GoldCustomer_Apply30PercentDiscount()
            {
                var product = new Product { ListPrice = 100 };

                var result = product.GetPrice(new Customer { IsGold = true });

                Assert.That(result, Is.EqualTo(70));
            }
            
            But people who use mock everywhere, don't write a unit test like above. Instead they write a unit test like below:
            
            [Test]
            public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
            {
                var customer = new Mock<ICustomer>();
                customer.Setup(c => c.IsGold).Returns(true);

                var product = new Product { ListPrice = 100 };

                var result = product.GetPrice(customer.Object);

                Assert.That(result, Is.EqualTo(70));
            }
            
            Comparing these methods side by side, which method according to you is simpler and easy to understand. Though here we are dealing with very example. Our unit 
            test has two extra lines of code as this setup of a mock object. Imagine in a real life scenario where you are dealing with more complex code, you're going 
            to have a few mock objects, if you are going to mock everything.
            
            And your tests start to get really bulky. You'll have a test that takes the entire script from top to bottom. Your tests should be ideally within 3-5 lines 
            of code. In real life scenarios, it's not always possible to write such short unit tests, but if you follow the best practices that I've taught you in this 
            course, you can achieve small, maintainable and reliable tests.
            
            So, 3-5 lines are ideal even 5-10 lines are okay, as long as you're not doing this kind of mocking, this is really really bad and I used to do this before 
            and I've realized the hard way that this is a recipe for disaster. So one more time, use mocks but removing external resources from your unit tests.
        */
    }
}
