using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests.Theory._02_FundamentalsOfUnitTesting
{
    class H25_WritingTrustworthyTests
    {
        /*
            One characteristic of the Unit Test is that a Unit Test should be TrustWorthy. What do you mean by a TrustWorthy test?
            A trustworthy test is the kind of test we can rely upon.
            
            If the test passes, you know your code is working and if it fails, you know that there is something wrong with your code. But how can we write trustworthy 
            tests?
            
            There are two ways:
            - One way is to use Test-Driven Development. With TDD, we start by writing a failing test, then we write enough production code, to make that test pass. So 
              if the test passes that means you have written the right production code to make that test pass. And if thetest fails that means something was wrong with 
              the production code.
            
              But TDD can get complex in some real world scenarios. So far we have been writing tests after the production code. This approach is a little bit risky 
              because you may test the wrong thing. When you test the wrong thing, your test may pass but your production code might have a bug, so this is an example 
              of untrustworthy tests.
            
            - When you write your tests after the production code, run your test if it passes then go in the production code and make a small change on the line that is 
              supposed to make the test pass.
            
              Create a bug, return a different value, maybe comment out that line, if you change the line that is supposed to make the test pass, and then your test 
              still passes that means that test is not testing the right thing.
            
              Because if you modify that line, and create a bug, the test should fail, right?
            
              So make sure to write trustworthy tests that give you value. So when they pass you know your code is working, and when they fail you know that there is 
              probably something wrong with the code.
        */
    }
}
