using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.WhileLabelApp.Localization;
using Acme.WhileLabelApp.Permissions;
using Acme.WhileLabelApp.Web.Components.WhiteLabelSettings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Web.Pages.SettingManagement;

namespace Acme.WhileLabelApp.Web.Settings;

public class WhiteLabelAppSettingPageContributor : ISettingPageContributor
{
    public async Task<bool> CheckPermissionsAsync(SettingPageCreationContext context)
    {
        var authService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();
        return await authService.IsGrantedAsync(WhileLabelAppPermissions.WhiteLabelSettings);
    }

    public Task ConfigureAsync(SettingPageCreationContext context)
    {
        var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<WhileLabelAppResource>>();
         context.Groups.Add(
            new SettingPageGroup(
                "Volo.Abp.MySettingGroup",
                l["WhiteLabelSettings"],
                typeof(WhiteLabelSettingsViewComponent),
                order : 1
            )
        );

        return Task.CompletedTask;
    }
}