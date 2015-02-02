using System.Data.Entity;
using hGem.Core.Infrastructure.Configuration;
using hGem.Core.Infrastructure.General;
using hGem.Data.Entities;

namespace hGem.Data.Context
{
    public sealed class TextResourceDbContext : ApplicationDbContextBase, ITextResourceDbContext
    {
        public IDbSet<TextResource> TextResources { get; set; }
        public IDbSet<TextResourceIdentifier> TextResourceIdentifiers { get; set; }
        public IDbSet<Language> Languages { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Client> Clients { get; set; }

        public TextResourceDbContext(IApplicationConfig applicationConfig, IDateTimeProvider dateTimeProvider)
            : base(applicationConfig, dateTimeProvider)
        {
        }
    }
}
