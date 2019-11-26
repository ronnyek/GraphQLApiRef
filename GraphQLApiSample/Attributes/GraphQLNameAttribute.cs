using System;

namespace GraphQLApiSample.Attributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class GraphQLNameAttribute: Attribute
    {
        public string Name { get; set; }
        public GraphQLNameAttribute(string name)
        {
            Name = name;
        }
    }
}
