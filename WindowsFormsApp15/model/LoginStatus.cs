using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.model
{
    class LoginStatus
    {
         public static Boolean isLogged = false;
        private static Student currentUser;

        public static Student CurrentUser
        {
            get
            {
                if (!isLogged) 
                {
                    return null;
                }
                else
                { 
                    return currentUser;
                }
            }
            set => currentUser = value;
        }
    }
}
