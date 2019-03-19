using GraphQL.Types;
using JohanBos.Models;

namespace JohanBos.Api.Types
{
    public class PassionAreaType : ObjectGraphType<PassionArea>
    {
        public PassionAreaType()
        {
            Name = "PassionArea";
            Field(h => h.Title);
            Field(h => h.Passion);
        }
    }
}