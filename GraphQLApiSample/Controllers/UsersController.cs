using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQLApiSample.Attributes;
using GraphQLApiSample.Entities;
using GraphQLApiSample.FakeServices;

namespace GraphQLApiSample.Controllers
{
    [GraphQLName("Users")]
    [GraphQLDescription("Methods to manage Users")]
    [GraphQLPath("/Users")]
    public class UsersController: GraphQLController
    {
        private readonly IUserService _users;
        public UsersController(IUserService userService)
        {
            _users = userService;
        }

        [GraphQLPath("Users")]
        public async Task<List<User>> Users()
        {
            return _users.GetUsers();
        }

        [GraphQLPath("UsersById")]
        public async Task<User> UserById(long id)
        {
            return _users.GetUserById(id);
        }
    }
}
