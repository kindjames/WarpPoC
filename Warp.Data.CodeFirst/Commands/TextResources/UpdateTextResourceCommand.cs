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

namespace Warp.Data.Commands.TextResources
{
    /// <summary>
    /// Update command aggregate wrapper
    /// </summary>
    public class UpdateTextResourceCommand : ICommand
    {
        [IdRequired]
        public int Id { get; internal set; }

        [Required]
        public string ResourceIdentifierCode { get; set; }
        
        [Required]
        public bool ClientOverridable { get; set; }
    }

    public sealed class UpdateTextResourceCommandHandler : ICommandHandler<UpdateTextResourceCommand>
    {
        private readonly IDomainDbContext _dbContext;
        readonly ObjectMapper _objectmapper;

        public UpdateTextResourceCommandHandler(IDomainDbContext dbContext, ObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _objectmapper = objectMapper;
        }

        public void Execute(UpdateTextResourceCommand command)
        {
            CheckArgument.NotNull(command, "UpdateTextResourceCommand");

            var resource

        }
    }
}
