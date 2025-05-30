using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.WhileLabelApp.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.WhileLabelApp.Web.Components.WhiteLabelSettings;

public class WhiteLabelSettingsViewComponent(IWhiteLabelSettingsAppService whiteLabelSettingsAppService) : AbpViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var settings = await whiteLabelSettingsAppService.GetAsync();
        return View("~/Components/WhiteLabelSettings/Default.cshtml", settings);
    }
}