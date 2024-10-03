using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace verificacion_tecnica_vehicular.Models
{
    public class FiscalizadorVTN
    {

        public int CantidadVTV { get; private set; }
        public VTV this[int idx] => evaluaciones[idx]
        {

        }
    }
}
