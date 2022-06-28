using TestAbpProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TestAbpProject;

[DependsOn(
    typeof(TestAbpProjectEntityFrameworkCoreTestModule)
    )]
public class TestAbpProjectDomainTestModule : AbpModule
{

}
