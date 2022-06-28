using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace TestAbpProject.Demo.Services
{
    public class DemoAppService : TestAbpProjectAppService, IDemoAppService
    {
        private readonly IRepository<DemoClass> _repository;

        public DemoAppService(IRepository<DemoClass> repository)
        {
            _repository = repository;
        }
        public async Task<DemoClass> Post(DemoClassDto demoClass)
        {
            var Exist = await _repository.FirstOrDefaultAsync(x=>x.Id==demoClass.Id);
            if (Exist == null)
            {
                var data = new DemoClass
                {
                    Name = demoClass.Name,
                    Description = demoClass.Description,
                    Message = demoClass.Message,
                    CreationTime=demoClass.CreationTime,
                };
                await _repository.InsertAsync(data);
                return data;
            }
            else
                return null;
        }
    }
}
