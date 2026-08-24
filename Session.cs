using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_titans
{
    internal class Session
    {
        // Stores the email of the currently logged-in user
        public static string LoggedInEmail { get; set; }

        // Checks whether a user is currently logged in
        public static bool IsLoggedIn
        {
            get
            {
                return !string.IsNullOrEmpty(LoggedInEmail);
            }
        }

        // Logs the current user out
        public static void Logout()
        {
            LoggedInEmail = null;
        }
    }
}
