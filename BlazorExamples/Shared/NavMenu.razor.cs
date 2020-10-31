using BlazorExamples.Stores.CounterStore;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExamples.Shared
{
    public partial class NavMenu : IDisposable
    {
        [Inject]
        public CounterStore CounterStore { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            CounterStore.AddStateChangeListener(UpdateView); //attach listener to the store
        }

        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        private void UpdateView()
        {
            StateHasChanged();
        }

        public void Dispose()
        {
            CounterStore.RemoveStateChangeListener(UpdateView);
        }
    }
}
