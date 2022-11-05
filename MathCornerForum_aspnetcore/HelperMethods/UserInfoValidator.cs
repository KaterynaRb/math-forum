using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MathCornerForum_aspnetcore.HelperMethods
{
    public static class UserInfoValidator
    {
        
        //Write method for checking email
        public static bool IsValidEmailAddress(this string email)
        {
            return true;
        }

        //Write method for checking password
        public static bool IsValidPassword(this string password)
        {
            return true;
        }
    }
}
