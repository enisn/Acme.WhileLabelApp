using Acme.WhileLabelApp.Localization;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.WhileLabelApp.Permissions;

public class WhileLabelAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WhileLabelAppPermissions.GroupName);

        myGroup.AddPermission(WhileLabelAppPermissions.WhiteLabelSettings, L("Permission:WhiteLabelSettings"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WhileLabelAppResource>(name);
    }
}
