using System;
using System.Collections.Generic;
using System.Text;
using static ObjectOrientedPrograms.Delegates.Addition;

namespace ObjectOrientedPrograms.Delegates
{
    class Delegates
    {
        public static void MultiCasting()
        { 
        Addition addition = new Addition();
        Operation operation = new Operation(Addition.adding);
            operation += operation.Muliplication();
    }
}
