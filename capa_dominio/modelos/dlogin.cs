using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos.model;

namespace capa_dominio.modelos
{
    public class dlogin
    {
        login_user login = new login_user();

        public bool loginp(string user,string pass)
        {
            return login.login(user, pass);
        }
    }
}
