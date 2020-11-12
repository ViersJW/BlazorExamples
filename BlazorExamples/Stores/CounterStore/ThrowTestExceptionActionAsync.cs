using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples.Stores.CounterStore
{
    public class ThrowTestExceptionActionAsync : IAction
    {
        public const string TestExceptionActionAsync = "EXCEPTION_ASYNC";
        public string Name => TestExceptionActionAsync;
    }
}
