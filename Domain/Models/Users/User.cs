
namespace Domain.Models.Users
{
    public class User
    {
        private readonly UserId id;
        private UserName name;

        public User(UserId id, UserName name)
        {
            this.id   = id;
            this.name = name;
        }

        public void Notify(IUserDataModelNotification note)
        {
            note.Id(this.id);
            note.Name(this.name);
        }
    }
}
