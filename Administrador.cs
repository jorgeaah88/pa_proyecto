using System;

namespace Proyecto1 {
    public class Administrador : Persona {
        //Clase cliente que hereda los atributos de la clase persona

        private DateTime _fechaIngreso = new DateTime(1850, 01, 01);

        public Administrador (int identificacion, string nombre, string apellido1, string apellido2, DateTime fechanacimiento, DateTime fechaingreso)//Constructor para las variables heredadas y las nuevas
            : base(identificacion, nombre, apellido1, apellido2, fechanacimiento) {
            _fechaIngreso = fechaingreso;

        }

        new public bool IsOk() {
            if ( base.IsOk() /*&& DateTime.Compare(_fechaIngreso, new DateTime(1850, 01, 01)) == 0*/) {

                return true;

            }

            return false;
        }

        new public string ToString() {
            return base.ToString()+ "\t\t>FIngreso : " + _fechaIngreso.ToString("ddMMyyyy");

        }

        new public string GetName()
        {
            return base.GetName();

        }

        new public string[] ToArray() {
            string[] tmp = base.ToArray();
            string[] tmp2 = { _fechaIngreso.ToString("ddMMyyyy") };

            var tmp3 = new string[tmp.Length + tmp2.Length];
            tmp.CopyTo(tmp3, 0);
            tmp2.CopyTo(tmp3, tmp.Length);

            return (tmp3);

        }


    }
}
