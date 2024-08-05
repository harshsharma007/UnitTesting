namespace TestNinja.UnitTests.Theory._02_FundamentalsOfUnitTesting
{
    class H18_NamingAndOrganizingTests
    {
        /*
            If you have a project named TestNinja, you should have a separate project called TestNinja.UnitTests. As I told you before, you want to separate unit and
            integration tests, because unit test execute fast, integration tests take longer.
            
            So, we want to run unit tests frequently as we're writing code, and run integration tests just before committing our code to the repository to make sure
            everything works. So, for each project in the solution, you're going to have a separate unit testing project.
            
            In this project, you often have a test class for each class in your production code. So if you have a class called Reservation, you should have a class
            called ReservationTests. For each method in the Reservation class, you should have one or more test methods.
            
            How many tests do you need?
            It depends on what you're testing. Often, the number of tests is equal to or greater than the number of execution paths.
            Number of Tests >= Number of Execution Paths
            
            The name of your tests should clearly specify the business rule you're testing. Below are some of the poor names:
            - Test1()
            - SaveCustomerTest()
            - GetMovie()
            
            We can't tell which business rule is tested here. That's why we have a convention for naming our tests. The name of the method on our test is"
            [MethodName]_[Scenario]_[ExpectedBehaviour]
            
            With this convention, we can look at the name of a test method and tell what business rule is being tested. Sometimes, you're dealing with a large complex
            method with so many execution paths and edge cases.
            
            In that case, it may be better to dedicate a separate test class for that method. Because otherwise the test for this method may pollute your test class.
            Let's say in our example, CanBeCancelled by method requires several tests. You can extract all the tests for this method, into a separate class and call
            it Reservation_CanBeCancelledByTests. This way you can easily locate the tests for this method.
        */
    }
}
