using GraphQLApiSample.Attributes;

namespace GraphQLApiSample.Entities
{
    [GraphQLName("User")]
    [GraphQLDescription("User in the system")]
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
