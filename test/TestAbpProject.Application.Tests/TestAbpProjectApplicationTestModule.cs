using Volo.Abp.Modularity;

namespace TestAbpProject;

[DependsOn(
    typeof(TestAbpProjectApplicationModule),
    typeof(TestAbpProjectDomainTestModule)
    )]
public class TestAbpProjectApplicationTestModule : AbpModule
{

}
