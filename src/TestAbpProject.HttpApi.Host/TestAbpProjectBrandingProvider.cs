using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestAbpProject;

[Dependency(ReplaceServices = true)]
public class TestAbpProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestAbpProject";
}
