namespace TestNinja.UnitTests.Theory._03_CoreUnitTestingTechniques
{
    class H34_TestingMethodsThatRaiseAnEvent
    {
        /*
            In our Log() method, once the event is stored in our storage, you raise the event ErrorLogged. We can see ErrorLogged is an event of type EventHandler of 
            Guid.
            
            The lambda expression below represents our EventHandler. When the ErrorLogged event is raised, the function will be executed. So in the body of the function, 
            I can get the event argument, in this case Event ID.
            
            logger.ErrorLogged += (sender, args) => { id = args };
            
            Our assertion is very simple. If the event is raised, the function is executed and that means id will no longer be an empty Guid. It will be the value that 
            comes with the event.
            
            Recap:
            To test the method that raises an event, all we have to do is to subscribe to that event in your test method, before Acting (Act).
            In your event handler you're going to get some value. In this case, we are getting a new Guid. So, if the event is raised then our id should no longer be an 
            empty Guid after acting.
            
            That's why we have a simple assertion to make sure ID is not an empty Guid.
        */
    }
}
