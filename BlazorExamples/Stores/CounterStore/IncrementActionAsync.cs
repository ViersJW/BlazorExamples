using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples.Stores.CounterStore
{
    public class IncrementActionAsync : IAction
    {
        public const string IncrementAsync = "INCREMENT_ASYNC";
        public string Name => IncrementAsync;
    }
}
