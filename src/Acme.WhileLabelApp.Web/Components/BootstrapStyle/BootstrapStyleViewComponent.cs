using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.WhileLabelApp.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Settings;

namespace Acme.WhileLabelApp.Web.Components.BootstrapStyle;

public class BootstrapStyleViewComponent(ISettingProvider settingProvider) : AbpViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var primaryColor = await settingProvider.GetOrNullAsync(WhileLabelAppSettings.PrimaryColor);
        return View("~/Components/BootstrapStyle/Default.cshtml", primaryColor);
    }
}