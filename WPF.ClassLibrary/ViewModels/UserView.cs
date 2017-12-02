

namespace WPF.ClassLibrary.ViewModels
{
    using System;
    using System.Collections.Generic;
    using WPF.ClassLibrary.Interface;
    using WPF.ClassLibrary.Models;
    public class UserView : IUserInterface
    {
        List<UserModel> ListUser = new List<UserModel>();
        public bool UserDelete(UserModel user)
        {
            throw new NotImplementedException();
        }

        public int UserInsert(UserModel user)
        {
            ListUser.Add(new UserModel()
            {
                IdUser=user.IdUser,
                NameUser=user.NameUser,
                FirstName=user.FirstName

            });
            return 1;
        }

        public List<UserModel> UserSearch(UserModel ItemUser)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> UserSelect(UserModel ItemUser)
        {
            throw new NotImplementedException();
        }

        public bool UserUpdate(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
