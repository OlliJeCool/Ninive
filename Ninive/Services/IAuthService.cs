using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninive.Models;

namespace Ninive.Services
{
    public interface IAuthService
    {
        UserVm Authenticate(AuthVm model);
    }
}
