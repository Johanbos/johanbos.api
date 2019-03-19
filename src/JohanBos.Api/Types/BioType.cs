using GraphQL.Types;
using JohanBos.Models;

namespace JohanBos.Api.Types
{
    public class BioType : ObjectGraphType<Bio>
    {
        public BioType()
        {
            Name = "Bio";
            Field(h => h.DateOfBirth);
            Field(h => h.FullName);
            Field(h => h.Motivator, nullable: true);
        }
    }
}