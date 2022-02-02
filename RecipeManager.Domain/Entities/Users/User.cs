using RecipeManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Entities
{
    public partial class User:BaseEntity
    {
        public User(string userName
            , string firstName
            , string lastName
            , string email
            ,long roleId)
        {
            UserName = userName;

            this.Update(
                firstName
                , lastName
                , email
                , roleId
            );
        }

        public void Update(string firstName
            , string lastName
            , string email
            , long roleId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RoleId = roleId;
        }
        [Required]
        public string UserName { get; private set; }
        [Required]
        public string Password { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        [Required]
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public long RoleId { get; set; }
    }
}
