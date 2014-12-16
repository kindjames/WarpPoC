namespace Warp.Core.Infrastructure.Models
{
    public interface ITextResourceModelProvider
    {
        object PopulateTextResourcesOnModel(object model);
    }
}