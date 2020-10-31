using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples.Stores.CounterStore
{
    public class IncrementAction : IAction
    {
        public const string Increment = "INCREMENT";

        public string Name => Increment;





    }
}
