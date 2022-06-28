using System.Threading.Tasks;

namespace TestAbpProject.Data;

public interface ITestAbpProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
