using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.General;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Services
{
    public interface ICommandContext<TCommand>
        where TCommand : class, ICommand
    {
        IResponse UsingDto<TDto>(TDto dto) where TDto : DtoBase;
    }
}