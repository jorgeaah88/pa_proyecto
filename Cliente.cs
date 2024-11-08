using System;

namespace Proyecto1 {
    public class Cliente : Persona {
        //Clase Supervisor que hereda los atributos de la clase persona

        private bool _Activo = false;

        public Cliente (int identificacion, string nombre, string apellido1, string apellido2, bool activo, DateTime fechanacimiento)//Constructor para las variables heredadas y las nuevas
            : base(identificacion, nombre, apellido1, apellido2, fechanacimiento) {
            _Activo = activo;
        }


        new public bool IsOk() {

            if (base.IsOk() ) {

                return true;

            }

            return false;
        }

        public string Status()
        {
            if (_Activo)
            {
                return "Activo";
            }

            return "Inactivo";
        }

        new public string ToString() {
            return base.ToString() + "\t>Estado : " + Status();

        }

        new public string[] ToArray() {
            string[] tmp = base.ToArray();
            string[] tmp2 = { Status() };

            var tmp3 = new string[tmp.Length + tmp2.Length];
            tmp.CopyTo(tmp3, 0);
            tmp2.CopyTo(tmp3, tmp.Length);

            return (tmp3);

        }


    }
}
