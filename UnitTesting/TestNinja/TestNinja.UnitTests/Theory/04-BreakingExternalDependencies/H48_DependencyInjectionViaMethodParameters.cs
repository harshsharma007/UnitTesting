namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H48_DependencyInjectionViaMethodParameters
    {
        /*
            We can inject dependencies via Method parameters, via properties and via constructors. Let's learn dependency injection via method parameters. In our 
            ReadVideoTitle() method, instead of working with concrete implementation of FileReader, I'm going to pass an IFileReader object as a parameter to this method.
            
            Then we can get rid of the new operator and can use the argument which we have passed to the method. With this simple change, our VideoService class becomes 
            loosely coupled and testable. Because in our production code, we can pass a real FileReader object to this project, whereas in our test, we can pass a fake 
            FileReader object.
            
            Code:
            public string ReadVideoTitle(IFileReader fileReader)
            {
                var str = fileReader.Read("video.txt");
                var video = JsonConvert.DeserializeObject<Video>(str);
                if (video == null)
                    return "Error parsing the video.";
                return video.Title;
            }
            
            public class Program
            {
                public static void Main(string[] args)
                {
                    var service = new VideoService();
                    var title = service.ReadVideoTitle(new FileReader());
                }
            }
            
            A dependency injection framework is responsible for newing up the objects and passing them to our methods.
            
            Test Method code via method injection:
            
            [Test]
            public void ReadVideoTitle_EmptyFile_ReturnError()
            {
                var service = new VideoService();

                var result = service.ReadVideoTitle(new FakeFileReader());

                Assert.That(result, Does.Contain("error").IgnoreCase);
            }
        */
    }
}
