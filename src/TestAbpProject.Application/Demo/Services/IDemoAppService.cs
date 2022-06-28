using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace TestAbpProject.Demo.Services
{
    public interface IDemoAppService:IApplicationService
    {
        Task<DemoClass>Post(DemoClassDto demoClass);
    }
}
