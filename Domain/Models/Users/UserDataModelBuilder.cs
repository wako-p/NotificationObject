
namespace Domain.Models.Users
{
    public class UserDataModelBuilder : IUserDataModelNotification
    {
        private string id;
        private string name;

        public UserDataModelBuilder()
        {
        }

        public void Id(UserId id)
        {
            this.id = id.Value;
        }

        public void Name(UserName name)
        {
            this.name = name.Value;
        }

        public UserDataModel Build()
        {
            return new UserDataModel(this.id, this.name);
        }
    }
}
