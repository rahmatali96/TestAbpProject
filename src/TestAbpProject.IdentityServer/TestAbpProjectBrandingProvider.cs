using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TestAbpProject;

[Dependency(ReplaceServices = true)]
public class TestAbpProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestAbpProject";
}
