using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.App.Domains
{
    //classe para cargos da igreja
    class Office
    {
        public string Name
        { get; set; }
        public string Responsibility //responsabilidade do cargo
        { get; set; }
        public string PermissionApp //qual a permissão do cargo, dentro do sistema? pode ver relatórios, cadastrar dados?
        { get; set; }

    }
}
