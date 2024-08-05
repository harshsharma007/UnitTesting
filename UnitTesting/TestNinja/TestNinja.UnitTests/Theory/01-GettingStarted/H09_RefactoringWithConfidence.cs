using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests.Theory
{
    class H09_RefactoringWithConfidence
    {
        /*
            One thing you can say about the test methods is that they act as some kind of documentation about our source code. This is another benefit of writing tests.
            
            Imagine you join a new team that gives you a new project, and your task is to make some modifications to a class. If that class is properly supported by a 
            bunch of unit tests, you can easily figure out what the responsibility of that class is.
            
            The other benefit of writing Unit Tests is you can refactor your code with confidence. In our reservation class, I want to change the implementation of the 
            CanBeCancelledBy() method. Instead of two if statements, I want to have one if statement.
            
            Rather, to take my code to the next level I can even remove the if statement and only return the expression.
        */
    }
}
