using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestAbpProject.Data;

/* This is used if database provider does't define
 * ITestAbpProjectDbSchemaMigrator implementation.
 */
public class NullTestAbpProjectDbSchemaMigrator : ITestAbpProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
