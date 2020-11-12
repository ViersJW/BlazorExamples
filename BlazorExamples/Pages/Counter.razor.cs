using BlazorExamples.Stores;
using BlazorExamples.Stores.CounterStore;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples.Pages
{
    public partial class Counter : IDisposable
    {
        [Inject]
        public CounterStore CounterStore { get; set; }
        [Inject]
        public IActionDispatcher ActionDispatcher { get; set; }

        public void Dispose()
        {
            CounterStore.RemoveStateChangeListener(UpdateView);
        }

        private void UpdateView()
        {
            StateHasChanged();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            CounterStore.AddStateChangeListener(UpdateView); //attach listener to the store
        }

        private void IncrementCount()
        {
            ActionDispatcher.Dispatch(new IncrementAction()); //handle actions separately
        }

        private void IncrementCountAsync()
        {
            ActionDispatcher.Dispatch(new IncrementActionAsync()); //handle actions separately
        }

        private void ThrowAsyncException()
        {
            ActionDispatcher.Dispatch(new ThrowTestExceptionActionAsync()); //handle actions separately
        }    
    }
}
