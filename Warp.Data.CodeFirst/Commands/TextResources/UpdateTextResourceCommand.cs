using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Util;
using Warp.Data.Context;

namespace Warp.Data.Commands.TextResources
{
    /// <summary>
    /// Wrapper for UpdateTextResourceCommand aggregate
    /// </summary>
    public class UpdateTextResourceCommand : ICommand
    {
        [IdRequired]
        public Guid Id { get; set; }

        [Required]
        public string ResourceIdentifierCode { get; set; }
        
        [Required]
        public bool ClientOverridable { get; set; }

        Guid ICommand.Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
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

        public void Handle(UpdateTextResourceCommand command)
        {
            CheckArgument.NotNull(command, "UpdateTextResourceCommand");
        }
    }
}
