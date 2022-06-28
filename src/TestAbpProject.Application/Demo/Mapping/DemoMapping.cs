using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbpProject.Demo.Mapping
{
    public class DemoMapping:Profile
    {
        public DemoMapping()
        {
            CreateMap<DemoClass, DemoClassDto>();
            CreateMap<DemoClass, UpdateDemoClassDto>();
        }
    }
}
