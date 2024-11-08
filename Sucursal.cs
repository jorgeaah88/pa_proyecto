namespace Proyecto1 {
    public class Sucursal
    {

        private int _Id = -1;
        private string _Nombre = "";
        private Administrador _Admin ;
        private string _Direccion = "";
        private string _Telefono = "";
        private bool _Activo = false;

        public Sucursal(int id, string nombre, Administrador admin, string direccion, string telefono, bool activo) {
            _Id = id;
            _Nombre = nombre;
            _Admin = admin;
            _Direccion = direccion;
            _Telefono = telefono;
            _Activo = activo;
        }

        public bool IsOk() {
            if ( _Id==-1 || _Nombre.Equals("") || _Telefono.Equals("") || _Direccion.Equals("") || !_Admin.IsOk() ) {
                return false;
            }

            return true;
        }

        public bool Match(int input) {

            return _Id==input;

        }

        public string Status()
        {
            if (_Activo)
            {
                return "Activo";
            }

            return "Inactivo";
        }

        public new string ToString() {

            return "Id: " + _Id + "\tNombre: " + _Nombre + "\tAdministrador: " + _Admin.GetName() + "\tDireccion: " + _Direccion + "\tTel: " + _Telefono + "\tEstado: " + Status();
        }

        public string ToStringSmall() {

            return "Id: " + _Id + "    Nombre: " + _Nombre + "    Direccion: " + _Direccion;
        }
        public string[] ToArray() {

            string[] tmp = { _Id.ToString(), _Nombre, _Admin.GetName(), _Direccion, _Telefono, Status() };
            return (tmp);

        }

        public string GetName() {
            return _Nombre;
        }
    }
}
