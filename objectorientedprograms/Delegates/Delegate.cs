using System;
using System.Collections.Generic;
using System.Text;
using static ObjectOrientedPrograms.Delegates.Operations;

namespace ObjectOrientedPrograms.Delegates
{
    class Delegate
    {
        public static void MultiCasting()
        {
           
            Operation operation = new Operation(Adding);
            operation += Operations.Multiplication;
            operation += Operations.Subtraction;
            operation(8, 9);
            operation -= Operations.Subtraction;
        }
    }
}
