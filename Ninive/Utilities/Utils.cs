using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ninive.Utilities
{
    public static class Utils
    {
        public static string Sha512Hash(string pin)
        {
            using var shaM = new SHA512Managed();

            var resultBytes = shaM.ComputeHash(Encoding.ASCII.GetBytes(pin));

            var hashedInputStringBuilder = new StringBuilder(128);
            foreach (var b in resultBytes)
                hashedInputStringBuilder.Append(b.ToString("X2"));

            return hashedInputStringBuilder.ToString();
        }
    }
}
