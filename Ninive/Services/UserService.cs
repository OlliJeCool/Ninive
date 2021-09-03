using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninive.Data;
using Ninive.Models;
using Ninive.Utilities;

namespace Ninive.Services
{
    public class UserService
    {
        private readonly NiniveContext _context;

        public UserService(NiniveContext context)
        {
            _context = context;
        }

        public UserVm ChangePassword(AuthVm model)
        {
            var user = _context.Users.SingleOrDefault(x => x.Code == model.Code && Utils.Sha512Hash(model.PinHash) == x.PinHash);
            if (user is null) { return null; }
            else { user.PinHash = model.newPinHash; return new UserVm { Name = user.Name, Code = user.Code }; }
        }
    }
}
