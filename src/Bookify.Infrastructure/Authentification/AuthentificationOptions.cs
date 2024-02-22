using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Infrastructure.Authentification
{
    public sealed class AuthentificationOptions
    {
        public string Audience { get; init; } = string.Empty;
        public string MetadataUrl { get; init; } = string.Empty;
        public string RequireHttpsMetadata { get; init; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
    }
}
