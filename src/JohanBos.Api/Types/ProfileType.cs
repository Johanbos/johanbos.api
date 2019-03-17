using GraphQL.Types;
using JohanBos.Models;

namespace JohanBos.Api.Types
{
    public class ProfileType : ObjectGraphType<Profile>
    {
        public ProfileType()
        {
            Name = "Profile";

            Field(h => h.DateOfBirth);
            Field(h => h.FullName);
            Field(h => h.Motivator, nullable: true);
        }
    }
}