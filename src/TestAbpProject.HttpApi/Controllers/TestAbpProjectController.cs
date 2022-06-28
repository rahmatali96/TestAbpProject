using TestAbpProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestAbpProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestAbpProjectController : AbpControllerBase
{
    protected TestAbpProjectController()
    {
        LocalizationResource = typeof(TestAbpProjectResource);
    }
}
