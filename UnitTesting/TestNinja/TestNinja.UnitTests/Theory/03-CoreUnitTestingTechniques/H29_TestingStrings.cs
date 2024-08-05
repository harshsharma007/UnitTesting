namespace TestNinja.UnitTests.Theory._03_CoreUnitTestingTechniques
{
    class H29_TestingStrings
    {
        /*
            Good unit tests should not be too specific or too general. In case of a specific assertion like below, there could be a problem when we are returning some 
            error message. Because below we are returning some specific content which is true for this case but in case of error message it may fail.
            
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            
            In contrast, they should not be too general, because if they are too general they may pass all the time even if your production code has an issue.
            
            Takeaway:
            - When testing strings, it's better if your Assertions are a little bit more general, because if they are too specific, your tests can break easily.
            
            - If the method is returning some kind of error message, I could use StartWith, EndWith and Contain to look for specific words in that error message.
            
            - When you are writing Assertions against strings, by default these Assertions are case sensitive, if you want to disable that you can use the ignore case 
              property.
        */
    }
}
