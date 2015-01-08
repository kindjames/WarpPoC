using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Commands.TextResources
{
    public sealed class UpdateResourceStringCommand : ICommand
    {
        public int Id { get; set; }

        [IdRequired]
        public int ResourceIdentifierId { get; set; }

        public int LanguageId { get; set; }

        public bool Active { get; set; }

        [Required]
        public string ResourceString { get; set; }

        public int ClientId { get; set; }
    }

    public sealed class UpdateTextResourceStringCommandHandler : ICommandHandler<UpdateResourceStringCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IObjectMapper _objectMapper;

        public UpdateTextResourceStringCommandHandler(IDomainDbContext dbContext, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _objectMapper = objectMapper;
        }

        public void Execute(UpdateResourceStringCommand command)
        {
            CheckArgument.NotNull(command, "UpdateResourceStringCommand");
            var resourceStringEntity = _objectMapper.Map<UpdateResourceStringCommand, TextResource>(command);

        }
    }
}