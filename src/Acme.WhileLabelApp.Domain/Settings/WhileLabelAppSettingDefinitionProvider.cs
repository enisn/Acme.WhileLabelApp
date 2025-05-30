using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace Acme.WhileLabelApp.Settings;

public class WhileLabelAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WhileLabelAppSettings.MySetting1));
        context.Add(
            new SettingDefinition(WhileLabelAppSettings.AppName),
            new SettingDefinition(WhileLabelAppSettings.Theme),
            new SettingDefinition(WhileLabelAppSettings.AppLogo),
            new SettingDefinition(WhileLabelAppSettings.PrimaryColor)
        );
    }
}
