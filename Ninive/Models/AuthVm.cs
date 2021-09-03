using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninive.Models
{
    public class AuthVm
    {
        public int Code { get; set; }
        public string PinHash { get; set; }
        public string newPinHash { get; set; }
    }
}
