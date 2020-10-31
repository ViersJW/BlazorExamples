using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples.Stores.CounterStore
{
    public class CounterState
    {
        public int Count { get; }

        public CounterState(int count)
        {
            Count = count;
        }
    }

    public class CounterStore
    {
        private readonly IActionDispatcher _actionDispatcher;
        private CounterState _state;

        public CounterStore(IActionDispatcher actionDispatcher)
        {
            _state = new CounterState(0);
            _actionDispatcher = actionDispatcher;
            _actionDispatcher.Subscribe(HandleActions);
        }

        public CounterState GetState() => _state;

        private void HandleActions(IAction action)
        {
            switch (action.Name)
            {
                case IncrementAction.Increment:
                    IncrementCount();
                    break;
                case DecrementAction.Decrement:
                    DecrementCount();
                    break;
                default:
                    break;
            }

        }

        private void IncrementCount()
        {
            var count = _state.Count;
            count++;
            _state = new CounterState(count);
            BroadcastStateChange();
        }

        private void DecrementCount()
        {
            var count = _state.Count;
            count--;
            _state = new CounterState(count);
            BroadcastStateChange();
        }

        #region Observer pattern

        private Action _listeners;

        public void AddStateChangeListener(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListener(Action listener)
        {
            _listeners -= listener;
        }

        private void BroadcastStateChange()
        {
            _listeners.Invoke();
        }

        #endregion
    }
}
