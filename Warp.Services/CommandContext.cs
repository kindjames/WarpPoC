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
        private readonly IValidationProvider _validationProvider;
        private readonly IObjectMapper _objectMapper;

        public CommandContext(IDispatcher dispatcher, IValidationProvider validationProvider, IObjectMapper objectMapper)
        {
            _dispatcher = dispatcher;
            _validationProvider = validationProvider;
            _objectMapper = objectMapper;
        }

        public IResponse UsingDto<TDto>(TDto dto) where TDto : DtoBase
        {
            // Validate Dto.
            var dtoValidation = _validationProvider.Validate(dto);

            if (!dtoValidation.Successful)
            {
                // Return failed Dto validation response.
                return dtoValidation;
            }

            // Map to Command POCO.
            var command = _objectMapper.MapTo<TCommand>(dto);

            // Validate Command POCO.
            var commandValidation = _validationProvider.Validate(command);

            // If validation failed, return validation response.
            if (!commandValidation.Successful)
            {
                return commandValidation;
            }

            // Dispatch Command POCO to CommandHandler.
            _dispatcher.Execute(command);

            return new GeneralResponse();
        }
    }
}