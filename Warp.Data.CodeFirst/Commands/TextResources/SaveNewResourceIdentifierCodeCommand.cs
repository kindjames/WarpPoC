﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    public sealed class SaveNewResourceIdentifierCodeCommand : ICommand
    {
        public int Id { get; internal set; }

        [Required]
        public string ResourceIdentifierCode { get; set; }
    }

    public sealed class SaveNewResourceIdentifierCommandHandler : ICommandHandler<SaveNewResourceIdentifierCodeCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public SaveNewResourceIdentifierCodeCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Execute(SaveNewResourceIdentifierCodeCommand command)
        {
            throw new NotImplementedException();
        }
    }
}