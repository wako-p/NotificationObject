
namespace Domain.Models.Users
{
    public interface IUserDataModelNotification
    {
        void Id(UserId id);
        void Name(UserName name);

        UserDataModel Build();
    }
}
