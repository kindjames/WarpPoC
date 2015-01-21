using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Services
{
    public class CommandContext<TCommand> : ICommandContext<TCommand>
        where TCommand : class, ICommand
    {
        private readonly IDispatcher _dispatcher;
        private readonly IValidator _validator;
        private readonly IObjectMapper _objectMapper;

        public CommandContext(IDispatcher dispatcher, IValidator validator, IObjectMapper objectMapper)
        {
            _dispatcher = dispatcher;
            _validator = validator;
            _objectMapper = objectMapper;
        }

        public IResponse UsingDto<TDto>(TDto dto) where TDto : DtoBase
        {
            // Validate Dto.
            var dtoValidation = _validator.Validate(dto);

            if (!dtoValidation.Successful)
            {
                // Return failed Dto validation response.
                return dtoValidation;
            }

            // Map to Command POCO.
            var command = _objectMapper.MapTo<TCommand>(dto);

            // Validate Command POCO.
            var commandValidation = _validator.Validate(command);

            if (!commandValidation.Successful)
            {
                // Return failed Command POCO validation response.
                return commandValidation;
            }

            // Dispatch Command POCO to CommandHandler.
            _dispatcher.Execute(command);

            return new GeneralResponse();
        }
    }
}