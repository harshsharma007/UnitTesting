namespace TestNinja.UnitTests.Theory._03_CoreUnitTestingTechniques
{
    class H35_TestingPrivateMethods
    {
        /*
            How should I test my private or protected methods?
            The answer is, don't test them, you shouldn't. You shouldn't test private methods!
            
            Because these methods are implementation details. What does that mean?
            Think of a DVD player. A DVD player has a few buttons on the outside, and a complex logic board on the inside. What you see on the outside is what we call a 
            public API, or the public interface of a DVD player.
            
            What is inside this black box that we don't see, is what we call implementation details. An implementation can change from one version to another. But the 
            buttons on the outside they stay the same.
            
            In Object Oriented Programming, we want to design our classes like a DVD player, so we want to have very few public members and these members represent the 
            public API or the public interface of our classes.
            
            Private and protected members represent the implementation detail. But they can change easily as you refactor and restructure your code. There are tools out 
            there that allow you to write tests against private members.
            
            Or you can make a private member public and test it, but you shouldn't do this because when you write tests that use private members, your tests are coupled 
            with an implementation detail.
            
            And as you change this implementation, these tests are going to break. They get in the way and they slow you down. As in our ErrorLogger class, in Log() 
            method we raise the ErrorLogged event. Let's extract this line and put it in a protected virtual void method.
            
            protected virtual void OnErrorLogged(Guid errorId)
            {
                ErrorLogged?.Invoke(this, errorId);
            }
            
            The method above is an implementation detail and it can change from one version to another. So we shouldn't write tests against this method, instead we 
            should write tests of our Log() method.
            
            What happens when we write tests for this protected method? (By changing the access modifier to public)
            This is bad because this is about implementation detail. You shouldn't leak these to the outside. This is like designing a DVD player that exposes the 
            internal chips to the outside.
            
            Let's say we have written a test case for this method. But let's see what happens when we refactor our code and change our implementation. Back to our 
            ErrorLogger, tomorrow we decides that instead of passing the errorId here, storing the errorId in a private field.
            
            For example, we may introduce a field globally
            private Guid _errorId;
            
            And instead of passing the Guid Id as a parameter, we want to read that global private field in the protected method itself. So we have changed our 
            implementation, we have refactored our code, we have restructured it. Now, our test will broke.
            
            We have to change the test and have to remove the parameter from the method call. This is a simplified application and we have only a single test for this 
            method, but in a real world application you might have ten or twenty tests for a given method.
            
            As you refactor the code, as you change the implementation all those tests are going to break. Again, let's say tomorrow we again refactor our code and 
            drops the method totally. And we decide to directly raise the event directly in the log method.
            
            Once again our test will broke again. This is the problem with testing private or protected members. They are about implementation detail and they can change 
            easily, when you write tests for these methods your tests become very fragile and they break often.
            
            Instead, if we focus on just testing the public methods even though they would be making a call to the private methods, in this case changing or refactoring 
            our code won't result in test break instead we will be getting the same result as before.
            
            What if in your application you have a public method that calls a private method and that private method calls another private method, perhaps you have a 
            chain of private methods and each private method has five to ten lines of logic.
            
            In this case if you want to write all the tests for the public method, your tests are going to get so complicated. May be you have so many execution paths. 
            If that's the case that could be a symptom of a design smell in your application.
            
            So chances are those fat private methods shouldn't really be private methods in that class. Maybe they belong to a separate class, and there they can be 
            public methods that can be reused in other cases.
            
            In that case you move those private methods to a new class, make them public and properly unit test that class.
        */
    }
}
