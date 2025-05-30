using Volo.Abp.Settings;

namespace Acme.WhileLabelApp.Settings;

public class WhileLabelAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WhileLabelAppSettings.MySetting1));
    }
}
