using System;

namespace GraphQLApiSample.Attributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class GraphQLPathAttribute: Attribute
    {
        public string Path { get; set; }

        public GraphQLPathAttribute(string path)
        {
            Path = path;
        }
    }
}
