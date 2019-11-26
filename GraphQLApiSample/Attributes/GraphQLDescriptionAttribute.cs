using System;

namespace GraphQLApiSample.Attributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class GraphQLDescriptionAttribute: Attribute
    {
        public string Description { get; set; }

        public GraphQLDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}
