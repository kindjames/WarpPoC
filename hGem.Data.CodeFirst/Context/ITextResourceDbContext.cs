using System.Data.Entity;
using hGem.Data.Entities;

namespace hGem.Data.Context
{
    public interface ITextResourceDbContext : IApplicationDbContext
    {
        IDbSet<TextResource> TextResources { get; set; }
        IDbSet<TextResourceIdentifier> TextResourceIdentifiers { get; set; }
        IDbSet<Language> Languages { get; set; }
        IDbSet<User> Users { get; set; }
        IDbSet<Client> Clients { get; set; }
    }
}
