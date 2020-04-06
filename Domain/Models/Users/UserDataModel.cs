
namespace Domain.Models.Users
{
    public sealed class UserDataModel
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public UserDataModel(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
