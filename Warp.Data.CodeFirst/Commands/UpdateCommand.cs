using Warp.Core.Command;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Data.Commands
{
    public abstract class UpdateCommand : ICommand
    {
        [IdRequired]
        public int Id { get; set; }
    }
}