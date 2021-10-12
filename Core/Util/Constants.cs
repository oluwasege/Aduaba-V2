using Aduaba.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aduaba.Core.Util
{
    public abstract class Constants
    {
        public static class Authorization
        {
            public const string default_admin = "admin";
            public const string default_admin_email = "admin@secureapi.com";
            public const string default_admin_password = "password";
            public const Roles default_admin_role = Roles.Administrator;

            public const string default_username = "user";
            public const string default_email = "user@secureapi.com";
            public const string default_password = "password";
            public const Roles default_role = Roles.User;
        }

        public static class PaginationConsts
        {
            // The page size
            public const int PageSize = 25;

            /// The page index
            public const int PageIndex = 1;
        }
    }
   
}
