using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.WhileLabelApp.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.BlobStoring;
using Volo.Abp.SettingManagement;

namespace Acme.WhileLabelApp.Settings;

public class WhiteLabelSettingsAppService(ISettingManager settingManager) : ApplicationService, IWhiteLabelSettingsAppService   
{
    [Authorize(WhileLabelAppPermissions.WhiteLabelSettings)]
    public async Task<WhiteLabelSettingsDto> GetAsync()
    {
        return new WhiteLabelSettingsDto
        {
            AppName = await settingManager.GetOrNullForCurrentTenantAsync(WhileLabelAppSettings.AppName),
            AppLogo = await settingManager.GetOrNullForCurrentTenantAsync(WhileLabelAppSettings.AppLogo),
            Theme = await settingManager.GetOrNullForCurrentTenantAsync(WhileLabelAppSettings.Theme),
            PrimaryColor = await settingManager.GetOrNullForCurrentTenantAsync(WhileLabelAppSettings.PrimaryColor)
        };
    }

    [Authorize(WhileLabelAppPermissions.WhiteLabelSettings)]
    public async Task UpdateAsync(WhiteLabelSettingsDto input)
    {
        await settingManager.SetForCurrentTenantAsync(WhileLabelAppSettings.AppName, input.AppName);
        await settingManager.SetForCurrentTenantAsync(WhileLabelAppSettings.AppLogo, input.AppLogo);
        await settingManager.SetForCurrentTenantAsync(WhileLabelAppSettings.Theme, input.Theme);
        await settingManager.SetForCurrentTenantAsync(WhileLabelAppSettings.PrimaryColor, input.PrimaryColor);
    }
}