namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H52_MockingFrameworks
    {
        /*
            Earlier in this section, we created the FakeFileReader and we used it to write one unit test for our VideoService class. So in this test, we're testing
            only one of the execution paths in ReadVideoTitle method. But what if we want to test the other execution path?
            
            Well, we need to change our FakeFileReader. Instead of returning an empty string we should return a real video object, serialized as JSON. But here's the
            problem, if you modify the code of FakeFileReader the existing unit test is going to break. So we should create another FakeFileReader that implements
            the IFileReader interface and in that fake object, instead of returning an empty string we should return a real JSON object.
            
            We can see that this approach is very time consuming. Creating all these fake objects by hand takes a lot of time. So that's why we use a mocking or isolation
            framework. So there are frameworks out there that help us dynamically create these fake or mock objects.
            
            So we don't have to hard code them by hand. We can create them dynamically as part of our tests and more interestingly, we can program them to behave any
            way we want. So we can program them to throw exceptions, to return values, to raise events and so on.
            
            We have different isolation or mocking frameworks out there and below is the list:
            - Moq
            - NSubstitute
            - FakeItEasy
            - Rhino Mocks
            
            Out of these frameworks what I personally prefer is Moq.
        */
    }
}
