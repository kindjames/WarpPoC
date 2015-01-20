
using System;
using System.ComponentModel.DataAnnotations;
namespace Warp.Core.Services.Dtos.TextResources
{
    public class SaveTextResourceDto : DtoBase
    {
        [Required]
        public string ResourceString { get; set; }
        [Required]
        public string ResourceIdentifierCode { get; set; }
        [Required]
        public Guid LanguageId { get; set; }
        [Required]
        public bool ClientOverridable { get; set; }
        [Required]
        public Guid ClientId { get; set; }
    }
}
