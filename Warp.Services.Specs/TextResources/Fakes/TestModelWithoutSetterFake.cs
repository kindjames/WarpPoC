using Warp.Core.Attributes;

namespace Warp.Services.Specs.TextResources.Fakes
{
    public class TestModelWithoutSetterFake
    {
        private const string _resourceToBeTranslated = "";

        [PopulateWith(182)]
        public string ResourceToBeTranslated
        {
            get { return _resourceToBeTranslated; }
        }
    }
}
