using GraphQL;
using GraphQL.Types;

namespace JohanBos.Api
{
    public class JohanBosSchema : Schema
    {
        public JohanBosSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<JohanBosQuery>();
        }
    }
}