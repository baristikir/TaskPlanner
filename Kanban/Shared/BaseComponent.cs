﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Kanban.Shared
{
    public class SampleBaseComponent : ComponentBase
    {
        [Inject]
        protected IJSRuntime jsRuntime { get; set; }

        [Inject]
        protected SampleService Service { get; set; }

        internal SampleData SampleDetails { get; set; } = new SampleData();
        protected override void OnAfterRender(bool FirstRender)
        {
            Service.Update(new NotifyProperties() { HideSpinner = true, RestricMouseEvents = true });
        }
    }
}
