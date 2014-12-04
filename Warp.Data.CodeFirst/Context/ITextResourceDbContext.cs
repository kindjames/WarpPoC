using System.Data.Entity;
using Warp.Data.Entities;
using TextResource = Warp.Data.Entities.TextResource;

namespace Warp.Data.Context
{
    public interface ITextResourceDbContext : IApplicationDbContext
    {
        IDbSet<TextResource> TextResources { get; set; }
        IDbSet<TextResourceIdentifier> TextResourceCodes { get; set; }
        IDbSet<Language> Languages { get; set; }
        IDbSet<User> Users { get; set; }
    }
}
