using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests.Theory
{
    class H11_WhatIsTestDrivenDevelopment
    {
        /*
            Test-Driven Development or TDD also called test first, is an approach to build software. With TDD, you write your test before writing the application or 
            production code.
            
            How can we test a code that we haven't written? How does TDD works?
            You start by writing a failing test. This test should fail because you don't have any application code that would make it pass, right?
            
            Then you will write the simplest application code that will make this test pass. The absolute simplest, you don't want to over engineer here. You don't want 
            to design a class diagram with a zillion classes and methods.
            
            Use the simplest implementation that would make the test pass. Then, refactor your code if necessary. These three steps are the foundation of TDD.
            
            Summary of steps:
            1. Write a failing test.
            2. Write the simplest code to make the test pass.
            3. Refactor if necessary.
            
            You repeat these steps over and over until you build a complete feature. What is so special about TDD? or Benefits of using TDD:
            
            1. You source code will be testable right from the get go. You don't have to make any changes to your code to make it testable.
            2. Every line of your production code is fully covered by tests. Which means you can refactor and deploy with confidence.
            3. It often results in a simpler implementation. When you start with a big class diagram, chances are you are over engineering and making the solution more 
               complex.
            
            If you write enough code to make all the tests pass and that solution works, there is no reason to write more code. The fact that all your tests passed, 
            means you have fulfilled all the business requirements. So, unless there is a new requirement, you don't need to write more code.
            
            If there is new requirement you start with failing test. This is TDD.
            
            Which approach is better?
            In theory, TDD is more promising because of the above benefits. But in practice, sometimes it can get really complex and it may slow you down. If that's 
            the case, it's better to switch to the code first approach and write your tests after.
        */
    }
}
