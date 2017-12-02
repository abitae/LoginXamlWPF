using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ClassLibrary.Models
{
    public class Authentication
    {
        public static bool Authenticate(UserModel userModel)
        {
            return false; // Do authentication against database, web service, whatever
        }
    }
}
