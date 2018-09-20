using Newtonsoft.Json.Linq;

namespace RealEstate.API.Models
{
    public class GraphQLQuery
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; } 
    }
}
