using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto1 {
    public class Persona {//Clase que maneja los datos principales de todas las personas
        //Atributos comunes de todas las personas

        // Atributos no encapsulados como propiedad debido a que los fields solo son modificados por el constructor.
        private int _Identificacion = -1;
        private string _Nombre = "";
        private string _Apellido1 = "";
        private string _Apellido2 = "";
        private DateTime _fechaNacimiento = new DateTime(1850, 01, 01);

        public Persona(int identificacion, string nombre, string apellido1, string apellido2, DateTime fanacimiento) {
            _Identificacion = identificacion;
            _Nombre = nombre;
            _Apellido1 = apellido1;
            _Apellido2 = apellido2;
            _fechaNacimiento = fanacimiento;
        }

        new public string ToString() {
            return "Id: " + _Identificacion + "\tNombe: " + _Nombre + " " + _Apellido1 + " " + _Apellido2 + "\tFNacimiento: "+ _fechaNacimiento.ToString("ddMMyyyy");
        }

        public string GetName()
        {
            return _Nombre + " " + _Apellido1 + " " + _Apellido2;
        }


        public bool IsOk() {

            if (_Nombre.Equals("") || _Identificacion == -1 /*|| DateTime.Compare(_fechaNacimiento, new DateTime(1850, 01, 01))==0*/) {
                
                return false;
            }
            return true;
        }

        public bool Match(int input)
        {

            return input==_Identificacion;

        }

        public string[] ToArray() {

            string[] tmp = { _Identificacion.ToString(), _Nombre, _Apellido1, _Apellido1, _Apellido2, _fechaNacimiento.ToString("ddMMyyyy") };
            return (tmp);

        }

    }
}
