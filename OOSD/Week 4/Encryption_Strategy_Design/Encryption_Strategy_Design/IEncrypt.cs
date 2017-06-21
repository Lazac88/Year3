using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Strategy_Design
{
    interface IEncrypt
    {
        String encrypt(String input);
        String decrypt(String input);
    }
}
