using System.ComponentModel.DataAnnotations;

namespace RecipeManager.Api.DTOs.Users
{
    public class AddUserRequest
    {
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(125)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public long RoleId { get; set; }
    }
}
