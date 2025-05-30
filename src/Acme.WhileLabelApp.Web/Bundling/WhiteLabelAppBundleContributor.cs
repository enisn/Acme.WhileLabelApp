using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.WhileLabelApp.Settings;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Settings;

namespace Acme.WhileLabelApp.Web.Bundling;

public class WhiteLabelAppBundleContributor() : BundleContributor
{
    public override async Task ConfigureBundleAsync(BundleConfigurationContext context)
    {
        var settingProvider = context.ServiceProvider.GetRequiredService<ISettingProvider>();
        var theme = await settingProvider.GetOrNullAsync(WhileLabelAppSettings.Theme);

        if (theme.IsNullOrEmpty())
        {
            return;
        }

        context.Files.RemoveAll(f => f.FileName.Contains("bootstrap"));
        context.Files.Add($"/themes/{theme}.min.css");
    }
}