namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H49_DependencyInjectionViaProperties
    {
        /*
            Injecting dependencies via method parameters work but this approach run into a couple of issues.
            - One issue is that you're changing the signature of the method. Imagine you have used the ReadVideoTitle method in ten places in your code, and then all of 
              a sudden you introduce a new parameter. Then you have to go and modify those ten places in your code.
            
            - If you have used this method in one or two places that is not an issue at all. The other issue you may run into is that some dependency injection frameworks 
              can not inject dependencies via method parameters. There are quite a few dependency injection frameworks out there, every team loves a different framework. 
              So depending on the dependency injection framework you use in your team, this approach may or may not work for you.
            
            The second way to inject dependencies. Instead of injecting the dependency as a method parameter, we can inject it using a property. So, we can declare a 
            property of type IFileReader and below is the code:
            
            public class VideoService
            {
                public IFileReader FileReader { get; set; }

                public VideoService()
                {
                    FileReader = new FileReader();
                }

                public string ReadVideoTitle()
                {
                    var str = FileReader.Read("video.txt");
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
                    var service = new VideoService();
                    var title = service.ReadVideoTitle(new FileReader());
                }
            }
            
            Test method of property injection:
            
            [Test]
            public void ReadVideoTitle_EmptyFile_ReturnError()
            {
                var service = new VideoService();
                service.FileReader = new FakeFileReader();

                var result = service.ReadVideoTitle();

                Assert.That(result, Does.Contain("error").IgnoreCase);
            }
        */
    }
}
