using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace verificacion_tecnica_vehicular.Models
{
    public abstract class Evaluacion
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }

        public Evaluacion(string nombre, string descripcion) 
        {
            this.Nombre= nombre;
            this.Descripcion= descripcion;
            
        }
        public abstract TipoAprobacion Evaluar();
        public override string ToString()
        {
            return $"{Nombre} {Descripcion}";
        }


    }
}
