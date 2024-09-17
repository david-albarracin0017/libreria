using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_common.atributs;
using capa_datos.entities;

namespace capa_dominio.crud
{
    public class dusuario
    {
        usuario user = new usuario();

        public void create(atribustsdb obj)
        {
            user.createuser(obj);
        }
    }
}
