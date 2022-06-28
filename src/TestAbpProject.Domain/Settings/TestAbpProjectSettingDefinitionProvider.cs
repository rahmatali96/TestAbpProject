using Volo.Abp.Settings;

namespace TestAbpProject.Settings;

public class TestAbpProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TestAbpProjectSettings.MySetting1));
    }
}
