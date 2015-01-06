using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    /// <summary>
    /// Wrapper for SaveTextResourceCommand aggregate
    /// </summary>
    public sealed class SaveNewTextResourceCommand : ICommand
    {
        public int Id { get; internal set; }
    }

    public sealed class SaveNewTextResourceCommandHandler : ICommandHandler<SaveNewTextResourceCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public void Execute(SaveNewTextResourceCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
