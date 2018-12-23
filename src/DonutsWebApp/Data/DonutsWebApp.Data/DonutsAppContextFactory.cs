﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using DonutsWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace DonutsWebApp.Data
{
    public class DonutsAppContextFactory : IDesignTimeDbContextFactory<DonutsAppContext>
    {
        DonutsAppContext IDesignTimeDbContextFactory<DonutsAppContext>.CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .Build();

            var builder = new DbContextOptionsBuilder<DonutsAppContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            // Stop client query evaluation
            builder.ConfigureWarnings(w => w.Throw(RelationalEventId.QueryClientEvaluationWarning));

            return new DonutsAppContext(builder.Options);
        }
    }
}