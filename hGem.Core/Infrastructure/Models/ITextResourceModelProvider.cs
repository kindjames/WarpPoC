namespace hGem.Core.Infrastructure.Models
{
    public interface ITextResourceModelProvider
    {
        object PopulateTextResourcesOnModel(object model);
    }
}