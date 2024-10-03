using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacion_tecnica_vehicular.Models
{
    public class VTV : IComparable
    {
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }
        public int CantidadVerificaciones { get; private set; }

        public List<Evaluacion> evaluaciones = new List<Evaluacion>();

        public Evaluacion this[int idx]
        {
            get
            {
                return evaluaciones[idx];
            }
        }
        public TipoAprobacion Aprobacion { // Ejemplo de compañero en clase
            get 
            {
                int min = 0;
                for (int i = 0; i < CantidadVerificaciones; i++)
                {
                    Evaluacion e = this[i];
                    int valor = (int)e.Evaluar();
                    if (valor == 0 || valor < min) { min = valor; }
                    return (TipoAprobacion)min;
                }

            }
            
             }
        public Propietario Propietario { get; private set; }

        public VTV(string patente, Propietario propietario)
        {
            this.Patente = patente;

        }
        public string[] EmitirComp() { }
    }       
}
