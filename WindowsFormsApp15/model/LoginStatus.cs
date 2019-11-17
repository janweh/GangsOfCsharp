using System;

namespace WindowsFormsApp15.model
{
    public static class LoginStatus
    {

        public static Boolean isLogged = false;
        private static Student currentUser;

        public static Student CurrentUser {
            get
            {
                if (!isLogged) { return null; }
                else { return CurrentUser; }
            }
                set => currentUser = value; }
    }
}
