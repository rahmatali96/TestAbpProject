using System;
using System.Collections.Generic;
using System.Text;
using TestAbpProject.Localization;
using Volo.Abp.Application.Services;

namespace TestAbpProject;

/* Inherit your application services from this class.
 */
public abstract class TestAbpProjectAppService : ApplicationService
{
    protected TestAbpProjectAppService()
    {
        LocalizationResource = typeof(TestAbpProjectResource);
    }
}
