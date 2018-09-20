using GraphQL;
using RealEstate.API.Mutations;
using RealEstate.API.Queries;

namespace RealEstate.API.Schema
{
    public class RealEstateSchema : GraphQL.Types.Schema
    {
        public RealEstateSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PropertyQuery>();
            Mutation = resolver.Resolve<PropertyMutation>();
        }
    }
}
