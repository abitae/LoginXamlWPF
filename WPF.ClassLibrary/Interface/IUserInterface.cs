

namespace WPF.ClassLibrary.Interface
{
    using System.Collections.Generic;
    using WPF.ClassLibrary.Models;
    public interface IUserInterface
    {
        bool UserDelete(UserModel user);
        bool UserUpdate(UserModel user);
        int UserInsert(UserModel user);
        List<UserModel> UserSelect(UserModel ItemUser);
        List<UserModel> UserSearch(UserModel ItemUser);
        

    }
}
