using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsManagerLib
{
    public class AccountsManager
    {
        public string ValidateUser(string userId, string password)
        {
            string outputMsg;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                throw new FormatException("Both user id and password are mandatory");
            }

            if ((userId.Equals("user_11") && password.Equals("secret@user11")) || (userId.Equals("user_22") && password.Equals("secret@user22")))
            {
                outputMsg = string.Format("Welcome {0}!!!", userId);
            }
            else
            {
                outputMsg = "Invalid user id/password";
            }

            return outputMsg;
        }
    }
}
