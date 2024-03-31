using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util
{
    public enum CondicionEnum
    {
        [Description("INSCRIPTO")]
        INSCRIPTO = 1,
        [Description("REGULAR")]
        REGULAR = 2,
        [Description("APROBADO")]
        APROBADO = 3,
        [Description("LIBRE")]
        LIBRE = 4
    }
}
