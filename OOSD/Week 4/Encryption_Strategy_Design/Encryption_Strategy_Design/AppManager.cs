using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Strategy_Design
{
    class AppManager
    {
        public IEncrypt myEncrypt { get; set; } 

        public AppManager(IEncrypt myEncrypt)
        {
            this.myEncrypt = myEncrypt;
        }

        public String encrypt(String input)
        {
            return myEncrypt.encrypt(input);
        }

        public String decrypt(String input)
        {
            return myEncrypt.decrypt(input);
        }
    }
}
