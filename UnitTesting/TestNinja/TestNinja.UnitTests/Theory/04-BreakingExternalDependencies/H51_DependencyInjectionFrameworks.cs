namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H51_DependencyInjectionFrameworks
    {
        /*
            In the last lecture, I showed you the technique to inject a real or fake FileReader for the VideoService object. This approach works but it's not ideal in 
            enterprise applications. Because in the real world application this class might have a couple more dependencies you don't want to repeat the expression a 
            few times and also make the parameter optional. It looks a little bit ugly.
            
            That's why we refer to this approach as Poor man's dependency injection. In a real enterprise like application, you don't want to do this. You want to keep 
            your code as simple as possible. That's why we use a dependency injection framework. When you use a proper dependency injection framework in your application,
            you can simply the constructor like:
            
            public VideoService(IFileReader fileReader)
            {
                _fileReader = fileReader;
            }
            
            It's far simpler and dependency injection framework will take care of creating and initializing objects at run time. There are various dependency injection 
            frameworks:
            - NInject
            - StructureMap
            - Spring.NET
            - Autofac
            - Unity
            
            All these frameworks follow the same principles. In a dependency injection framework, you have a container. This container is a registry of all your 
            interfaces and their implementations. When your application starts, your dependency injection framework will automatically take care of creating object 
            graphs based on the interfaces and types registered in the container.
            
            For example, in an ASP.NET MVC application, when you receive a request on the server, ASP.NET runtime should create an instance of a controller class. 
            Your controller may have one or more dependencies.
            
            public class MyController
            {
                public MyController(IFileReader reader)
                {
                }
            }
            
            At this point, your dependency injection framework kicks in, it looks at the parameters of the constructor of controller, then it looks at its container or 
            the registry and finds the concrete implementations for these referenced interfaces, instantiates them and passes them to your controller.
            
            If those objects also have dependencies, your dependency injection framework again will take care of creating and initializing an object graph for you.
        */
    }
}
