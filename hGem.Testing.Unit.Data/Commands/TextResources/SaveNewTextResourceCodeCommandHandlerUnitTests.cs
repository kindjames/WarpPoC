using System;
using System.Data.Entity;
using AutoMapper;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Data.Commands.Clients;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.General;
using IObjectMapper = Warp.Core.Infrastructure.AutoMapper.IObjectMapper;
using MoqIt = Moq.It;

namespace Warp.Testing.Unit.Data.Commands.TextResources
{
    public static class SaveNewResourceIdentifierCommandHandlerUnitTests
    {
        public class When_saving_an_existing_TextResourceCode : WithSubject<SaveNewResourceIdentifierCodeCommandHandler>
        {
            private static IDbSet<TextResourceIdentifier> _textResourceIdentifierRepository;
        }
    }
}
