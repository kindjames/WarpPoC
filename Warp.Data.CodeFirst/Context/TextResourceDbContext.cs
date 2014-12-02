using System.Data.Entity;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Util;
using Warp.Data.Entities;
using TextResource = Warp.Data.Entities.TextResource;

namespace Warp.Data.Context
{
    public sealed class TextResourceDbContext : ApplicationDbContextBase, ITextResourceDbContext
    {
        public TextResourceDbContext(IApplicationConfig applicationConfig, IDateTimeProvider dateTimeProvider)
            : base(applicationConfig, dateTimeProvider)
        {
        }

        public IDbSet<TextResource> TextResources { get; set; }
        public IDbSet<TextResourceCode> TextResourceCodes { get; set; }
        public IDbSet<Language> Languages { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}
