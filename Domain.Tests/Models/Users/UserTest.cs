using Xunit;
using Domain.Models.Users;

namespace Domain.Tests.Models.Users
{
    public class UserTest
    {
        [Fact]
        public void CreateUserDataModel()
        {
            var id   = new UserId("123");
            var name = new UserName("wako-p");
            var user = new User(id, name);

            var userDataModelBuilder = new UserDataModelBuilder();
            user.Notify(userDataModelBuilder);

            var userDataModel = userDataModelBuilder.Build();

            Assert.Equal(userDataModel.Id, "123");
            Assert.Equal(userDataModel.Name, "wako-p");
        }
    }
}
