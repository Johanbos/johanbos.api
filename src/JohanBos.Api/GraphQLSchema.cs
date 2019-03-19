using GraphQL;
using GraphQL.Types;

namespace JohanBos.Api
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<GraphQLQuery>();
        }
    }
}