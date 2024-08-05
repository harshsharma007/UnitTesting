namespace TestNinja.UnitTests.Theory._02_FundamentalsOfUnitTesting
{
    class H24_IgnoringTests
    {
        /*
            In the real world, as you modify your code, it is possible that you may break one or more tests. When you are new to Unit Testing, you may get frustrated, 
            you may think these tests are getting in the way and they're slowing you down.
            
            So you may get tempted to delete those tests or comment them out. But this is a very bad approach, because there was a reason to write those tests. Instead 
            we can temporarily disable the test and focus on some work somewhere else and then get to fix that test later in the future.
            
            We can decorate our test method with [Ignore("Because I wanted to!")] attribute. It expects a parameter where we can enter the reason to ignore the test case.
        */
    }
}
