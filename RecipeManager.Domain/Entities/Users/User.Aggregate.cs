using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Domain.Entities.Users
{
    public partial class User
    {
        public User(string userName
            , string firstName
            , string lastName
            , string email)
        {
            UserName = userName;

            this.Update(
                firstName
                , lastName
                , email
            );
        }

        public void Update(string firstName
            , string lastName
            , string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
