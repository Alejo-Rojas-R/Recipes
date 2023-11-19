using Recipes.Shared.Entities;

namespace Recipes.Shared.DTOs
{
    public class TokenDTO
    {
        public string Token { get; set; } = null!;
        public DateTime Expiration { get; set; }
    }
}