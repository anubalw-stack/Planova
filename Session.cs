using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_titans
{
    public static class Session
    {
        // The UserAccount object for the currently logged-in user (set by UserAccount.Login()).
        public static UserAccount CurrentUser { get; set; }

        // Checks whether a user is currently logged in.
        public static bool IsLoggedIn
        {
            get
            {
                return CurrentUser != null;
            }
        }

        // Logs the current user out.
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}