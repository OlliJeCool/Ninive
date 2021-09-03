using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninive.Data;
using Ninive.Services;
using Ninive.Models;
using Microsoft.Data.SqlClient;

namespace Ninive.Services
{

    public class AuthService : IAuthService
    {
        private readonly NiniveContext _context;
        public AuthService(NiniveContext context)
        {
            _context = context;
        }
        public UserVm Authenticate(AuthVm model)
        {
            var user = _context.Users.SingleOrDefault(x => x.Code == model.Code && x.PinHash == model.PinHash);

            if (user is null) { return null; }

            return new UserVm
            {
                Name = user.Name
            };

        }
    }
}