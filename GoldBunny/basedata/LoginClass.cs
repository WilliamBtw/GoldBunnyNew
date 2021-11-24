using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBunny.basedata
{
    public class LoginClass
    {
        private int flagLogin;
        public string Email { get; set; }
        public string password { get; set; }
        public int flagOkLog
        {
            get { return flagLogin; }
            set { flagLogin = value; }
        }
        public LoginClass (int flagg)
        {
            flagLogin = flagg;
        }
    }
}
