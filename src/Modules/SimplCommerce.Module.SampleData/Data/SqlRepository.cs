﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StormyCommerce.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplCommerce.Module.SampleData.Data
{
    public class SqlRepository : ISqlRepository
    {
        private readonly DbContext _dbContext;
        private readonly ILogger _logger;

        public SqlRepository(StormyDbContext dbContext, ILogger<SqlRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void RunCommand(string command)
        {
            _logger.LogDebug(command);
            _dbContext.Database.ExecuteSqlCommand(command);
        }

        public void RunCommands(IEnumerable<string> commands)
        {
            foreach (var command in commands)
            {
                _dbContext.Database.ExecuteSqlCommand(command);
            }
        }

        public IEnumerable<string> ParseCommand(IEnumerable<string> lines)
        {
            var sb = new StringBuilder();
            var commands = new List<string>();
            foreach (var line in lines)
            {
                if (string.Equals(line, "GO", StringComparison.OrdinalIgnoreCase))
                {
                    if (sb.Length > 0)
                    {
                        commands.Add(sb.ToString());
                        sb = new StringBuilder();
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        sb.Append(line);
                    }
                }
            }

            return commands;
        }

        public IEnumerable<string> PostgresCommands(IEnumerable<string> lines)
        {
            var commands = new List<string>();
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    commands.Add(line);
                }
            }

            return commands;
        }

        public string GetDbConnectionType()
        {
            var dbConntionType = _dbContext.Database.GetDbConnection().GetType();
            return dbConntionType.ToString();
        }
    }
}
