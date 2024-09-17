using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos.model;

namespace capa_dominio.modelos
{
    public class dexiste
    {
        existe_user exist = new existe_user();

        public bool validateuser(string user)
        {
            return exist.validacion(user);
        }
    }
}
