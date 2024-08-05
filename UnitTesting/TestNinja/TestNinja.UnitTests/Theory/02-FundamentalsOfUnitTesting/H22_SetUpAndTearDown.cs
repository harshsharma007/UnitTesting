namespace TestNinja.UnitTests.Theory._02_FundamentalsOfUnitTesting
{
    class H22_SetUpAndTearDown
    {
        /*
            If we look at the implementation of the Test methods, it looks like its the only test in the world. We're not calling one test in another test. And each 
            test is using a new instance of the Math class. This is extremely important, in each test you want to start with a fresh, clean state.
            
            So you shouldn't create a private field like below and use it across different tests. Because it is possible that one test may leave some state, in the math 
            object and that state will leak into another test and impact the result of the test.
            
            private Math _math;
            
            So each test should be executed with a fresh state. However, I don't like the fact that at the beginning of every test method we are initializing the Math 
            object. It looks a little bit redundant, in this case it's not a big deal because it's only a single line of code.
            
            But in the real world, when you're working with more complex applications, it is possible that you're arranged part might be a few lines of code. You don't 
            want to repeat all those lines in every test method. To deal with it, NUnit has two special attributes
            - SetUp
            - TearDown
            
            You can create a method and decorate it with a SetUp attribute and then NUnit test runner will call that method before running each test. Similarly, if we 
            create a method and decorate it with the TearDown attribute, NUnit test runner will call that method after each test. TearDown attribute is often used with 
            integration tests because in your integration tests, you may create some data in your database and then you want to do cleanup after each test.
            
            private Math _math;
            
            [SetUp]
            public void SetUp()
            {
                _math = new Math();
            }
            
            Here we are using private field and it is used in different tests but I'm reinitializing this to a new instance before each test.
        */
    }
}
