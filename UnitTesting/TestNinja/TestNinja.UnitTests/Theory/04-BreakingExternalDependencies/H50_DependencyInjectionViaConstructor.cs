namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H50_DependencyInjectionViaConstructor
    {
        /*
            Dependency Injection via properties works in a lot of scenarios, but some dependency injection frameworks can't inject dependencies via properties. So 
            alternative way is to inject dependencies via constructor parameters.
            
            public class VideoService
            {
                private IFileReader _fileReader;

                public VideoService(IFileReader fileReader)
                {
                    _fileReader = fileReader;
                }

                public string ReadVideoTitle()
                {
                    var str = _fileReader.Read("video.txt");
                    var video = JsonConvert.DeserializeObject<Video>(str);
                    if (video == null)
                        return "Error parsing the video.";
                    return video.Title;
                }
            }
            
            public class Program
            {
                public static void Main(string[] args)
                {
                    var service = new VideoService(new FileReader());
                    var title = service.ReadVideoTitle();
                }
            }
            
            Instead of passing the parameter of FileReader at the time of initialization of the class, we can create a new default constructor and then write the below 
            code:
            
            public VideoService()
            {
                _fileReader = new FileReader();
            }
            
            With this approach our legacy code will no longer be broken or we can even make our code better. Instead of creating two constructors we can create a 
            parameterized constuctor with optional parameter.
            
            public VideoService(IFileReader fileReader = null)
            {
                _fileReader = fileReader ?? new FileReader();
            }
            
            What does the code inside the constructor mean?
            It means the fileReader is not null, you're going to use to set this private field otherwise, if it's null you're going to new up a real FileReader object.
            
            Test method code:
            
            [Test]
            public void ReadVideoTitle_EmptyFile_ReturnError()
            {
                var service = new VideoService(new FakeFileReader());

                var result = service.ReadVideoTitle();

                Assert.That(result, Does.Contain("error").IgnoreCase);
            }
        */
    }
}
