﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestAbpProject.Data;
using Volo.Abp.DependencyInjection;

namespace TestAbpProject.EntityFrameworkCore;

public class EntityFrameworkCoreTestAbpProjectDbSchemaMigrator
    : ITestAbpProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTestAbpProjectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TestAbpProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TestAbpProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
