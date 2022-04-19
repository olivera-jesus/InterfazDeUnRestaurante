using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazDeUnRestaurante;

namespace InterfazDeUnRestaurante
{
    internal class AccesoLogin
    {

        string usernamevalido = " admin";
        string passwordvalido = "nimda";

        public bool Check(string username, string password)
        {
            if (usernamevalido == username &&
                passwordvalido == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
