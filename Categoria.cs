namespace Proyecto1 {
    public class Categoria {

        private int _id =- 1;
        private string _Nombre = "";
        private string _Descripcion = "";

        public Categoria(int id, string nombre, string descripcion)
        {
            _Nombre = nombre;
            _Descripcion = descripcion;
            _id = id;
        }

        public bool IsOk() {
            if (_Nombre.Equals("") || _id==-1 ) {
                return false;
            }

            return true;
        }

        new public string ToString() {

            return "Id: "+_id.ToString() + "\tNombre: " + _Nombre+ "\tDescripcion: " + _Descripcion;
        }

        public string[] ToArray() {

            string[] tmp = { _id.ToString(), _Nombre, _Descripcion};
            return (tmp);

        }

        public bool Match(string input) {

            return _Nombre.Equals(input);

        }

        public string GetDesc() {
            return _Descripcion;
        }
    }
}
