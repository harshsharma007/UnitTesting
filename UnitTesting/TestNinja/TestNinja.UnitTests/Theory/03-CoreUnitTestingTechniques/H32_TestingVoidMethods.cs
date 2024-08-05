namespace TestNinja.UnitTests.Theory._03_CoreUnitTestingTechniques
{
    class H32_TestingVoidMethods
    {
        /*
            How to test void methods? So far all the examples we have seen, were around methods that returned some value.
            
            Memory refresher: Earlier I told you about two types of functions in programming. We have query functions that return some value and command functions which 
            are supposed to perform an action. A void function by definition is a command function.
            
            These command functions often change some kind of state, that means they change the state of an object in memory, they may change thevalue of one or more 
            properties and additionally they may persist a state, they may store the object in database, they may call a web service, they may call a message queue.
            
            We have an ErrorLogger class and it has Log method, which is returning void. To check the outcome of the void method we need to check the property (LastError) 
            which is defined in the ErrorLogger class. We should verify the LastError property is set properly. The method is not returning a value instead it's changing 
            the state of an object in memory.            
        */
    }
}
