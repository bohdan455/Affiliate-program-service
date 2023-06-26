using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class UserModel
    {
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;

    }
}
