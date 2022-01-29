using RecipeManager.Domain.Base;
using System;
using System.Collections.Generic;
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

        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public long RoleId { get; set; }
    }
}
