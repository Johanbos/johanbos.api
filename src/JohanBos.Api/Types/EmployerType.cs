using GraphQL.Types;
using JohanBos.Models;

namespace JohanBos.Api.Types
{
    public class EmployerType : ObjectGraphType<Employer>
    {
        public EmployerType()
        {
            Name = nameof(Employer);
            Field(h => h.Title);
            Field(h => h.Started);
            Field(h => h.Ended, nullable: true);
            Field(h => h.Description, nullable: true);
            Field(h => h.Labels);
            Field(h => h.Reference, nullable: true);
        }
    }
}