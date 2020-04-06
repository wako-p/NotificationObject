
namespace Domain.Models.Users
{
    public class User
    {
        public UserId   Id   { get; private set; }
        public UserName Name { get; private set; }

        public User(UserId id, UserName name)
        {
            this.Id   = id;
            this.Name = name;
        }

        public void Notify(IUserDataModelNotification note)
        {
            note.Id(this.Id);
            note.Name(this.Name);
        }
    }
}
