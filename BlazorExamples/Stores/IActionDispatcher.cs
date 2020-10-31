using System;

namespace BlazorExamples.Stores
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);
        void Subscribe(Action<IAction> actionHandler);
        void UnSubscribe(Action<IAction> actionHandler);
    }
}