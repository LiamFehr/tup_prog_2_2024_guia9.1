using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace verificacion_tecnica_vehicular.Models
{
    public class EvaluacionParametrica:Evaluacion
    {
        public double ValorMinimo {  get; private set; }
        public double ValorMaximo { get; private set; }
        public string Unidad {  get; private set; }
        public double ValorTolerado { get; private set; }
        public double ValorMedio { get; set; }

        public EvaluacionParametrica(string nombre, string descripcion, double valorMinimo, double valorMaximo, string unidad, double valorTolerado, double valorMedio):base(nombre , descripcion)
        {
            ValorMinimo = valorMinimo;
            ValorMaximo = valorMaximo;
            Unidad = unidad;
            ValorTolerado = valorTolerado;
            ValorMedio = valorMedio;
        }
        public override TipoAprobacion Evaluar() 
        {
            TipoAprobacion medida =  TipoAprobacion.NoAprobado;
            if ( medida <= 0) { }

        }
        public override string ToString()
        {
            return $"{Nombre} {Descripcion}";
        }
    }
}
