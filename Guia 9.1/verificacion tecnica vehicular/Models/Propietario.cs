using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacion_tecnica_vehicular
{
    public class Propietario
    {
        public int DNI {  get; set; }
        public string ApellidoNombre { get; set; }
        public string Email { get; set; }

        public Propietario(int dni, string ApyNom,string email) 
        {
            this.DNI = dni;
            this.ApellidoNombre = ApyNom;
            this.Email = email;
        }
        public override string ToString() { return $"{DNI} , {ApellidoNombre} , {Email}"; }
    }
}
