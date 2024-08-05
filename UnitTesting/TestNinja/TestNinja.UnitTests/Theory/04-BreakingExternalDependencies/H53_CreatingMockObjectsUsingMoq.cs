namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H53_CreatingMockObjectsUsingMoq
    {
        /*
            After installing the Moq framework, to show you that we no longer need the FakeFileReader class, I am going to delete it from our project. Back in our
            VideoServiceTests, instead of newing up a FakeFileReader, we're going to use a Moq library to creat a dynamic mock.
            
            var fileReader = new Mock<IFileReader>();
            
            We are telling the Moq library we want an object that implements this IFileReader interface. The fileReader object that we have created above, is not the
            actual object, it's a mock object because we set this to a new Mock<IFileReader>().
            
            We need to program this mock because by default, it doesn't have any behavior it's like an object that implements the IFileReader interface but doesn't do
            anything, it doesn't have any code. In our VideoService class, we're calling the Read() method of fileReader and we're passing it "video.txt" as an
            argument. So, we need to program our mock, so when we call the Read() method and give it "video.txt" as a string, it's going to return a string.
            
            In our test case, we have to specify the below line of code. With this we're telling this mock fileReader that when we call Read() method with this
            argument it should return some string. In this unit test, the scenario we're testing is for an empty file and I'm going to return an empty string.
            
            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            
            As I told you the fileReader is not that object that implements IFileReader, it's a mock object. But when initializing the VideoService (in the test method),
            we need to get that object. Below is the code for that:
            
            var service = new VideoService(fileReader.Object);
            
            So this is the actual object that implements IFileReader. When you use mocks your test methods get a little bit noisy. That's why you should reserve mocks
            only for dealing with external dependencies. If you want to mock everything, if you want to mock every dependency of the VideoService class, you're going
            to end up with the fat test method. So use mocks only for external dependencies.
            
            When I use mock, I prefer to move some of the Arrange part in the SetUp() method.
        */
    }
}
