using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples.Stores.CounterStore
{
    public class DecrementAction : IAction
    {
        public const string Decrement = "DECREMENT";

        public string Name => Decrement;



    }
}
