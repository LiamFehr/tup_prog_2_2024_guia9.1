using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacion_tecnica_vehicular.Models
{
    public class EvaluacionSimple : Evaluacion
    {
        public bool HaVerificado {  get; set; }

        public EvaluacionSimple(string nombre, string descripcion) : base(nombre, descripcion) { }
        public override TipoAprobacion Evaluar()
        {
            TipoAprobacion medida = TipoAprobacion.NoAprobado;
            if (HaVerificado)
            { medida = TipoAprobacion.Aprobado; }
            return medida;
        }    
        public override string ToString()
        {
            return $"{Nombre} {Descripcion}";
        }
    }
}
