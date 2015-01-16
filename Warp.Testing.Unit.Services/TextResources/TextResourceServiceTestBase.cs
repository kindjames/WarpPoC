using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Entities;
using Warp.Services;

namespace Warp.Testing.Unit.Services.TextResources
{
    protected abstract class TextResourceServiceTestBase : WithSubject<TextResourceService>
    {
        //static TextResource _textResource;

        Because of = () => Subject.SaveTextResource(CreateDto());

        static abstract SaveTextResourceDto CreateDto();
    }

    [Subject("Saving a new TextResource")]
    public class When_saving_a_new_TextResource : TextResourceServiceTestBase
    {
        override 
    }
}
