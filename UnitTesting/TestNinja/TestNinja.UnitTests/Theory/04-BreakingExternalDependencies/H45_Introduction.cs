namespace TestNinja.UnitTests.Theory._04_BreakingExternalDependencies
{
    class H45_Introduction
    {
        /*
            In the real world, our application always use one or more external resources like files, databases. So, how can we unit test a class that depends on an 
            external resource. Well, your unit test should not touch external resources.
            
            A test that touches an external resource is classified as an integration test. But you can still unit test the logic in your classes, while excluding their 
            external dependencies. So, here's a basic principle.
            
            Imagine you have a class called VideoService. This class uses the File class to read the content of a file. In your application, this VideoService may use 
            the db context class of entity framework to read a record from the database, so it has a dependency to an external resource.
            
            In order to unit test the VideoService class, you should do some surgery in your code and decouple the VideoService from the file class or db context or 
            whatever the external dependency is. This way when unit testing this class, you can replace the File class with another class that looks like the file class 
            from the outside, but doesn't talk to the file system.
            
            In fact, it doesn't do anything, it's like a class with a bunch of methods that have no implementation. We call this class a fake, or a test double, just 
            like a stunt double in movies. We have the same concept here.
            
            When unit testing classes with external dependencies, we replace a production object with a test double or fake object.
        */
    }
}
