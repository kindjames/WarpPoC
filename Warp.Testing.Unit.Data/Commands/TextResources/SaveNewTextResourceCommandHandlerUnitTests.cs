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
    [Subject("SaveNewTextResourceCommandHandler Unit Tests")]
    public static class SaveNewTextResourceCommandHandlerUnitTests
    {
        public class When_saving_a_new_TextResource_with_an_existing_ResourceString :
            WithSubject<SaveNewTextResourceCommandHandler>
        {
            private static IDbSet<TextResource> _textResourceRepository;
        }


    }
}
