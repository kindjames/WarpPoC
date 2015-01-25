
using Warp.Core.Attributes;
namespace Warp.Testing.Unit.Services.TextResources.Fakes
{
    public class TestModelWithoutSetterFake
    {
        private const string _resourceToBeTranslated = "";

        [PopulateWith("Error.Message")]
        public string ResourceToBeTranslated
        {
            get { return _resourceToBeTranslated; }
        }
    }
}