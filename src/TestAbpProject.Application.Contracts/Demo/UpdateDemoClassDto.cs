using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace TestAbpProject.Demo
{
    public class UpdateDemoClassDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public DateTime LastModificationTime { get; set; }
    }
}
