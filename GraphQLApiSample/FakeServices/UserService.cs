using System.Collections.Generic;
using GraphQLApiSample.Entities;
using GraphQLApiSample.Support;

namespace GraphQLApiSample.FakeServices
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(long id);
    }

    public class UserService : IUserService
    {
        // fake request accessor (same as requestContext)
        private readonly IGraphQLRequestAccessor _request;
        public List<User> GetUsers()
        {

            return new List<User>();
        }

        public User GetUserById(long id)
        {
            return new User();
        }

        public UserService(IGraphQLRequestAccessor request)
        {
            _request = request;
        }
    }
}
